using CRUDDapper.Datos;
using CRUDDapper.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDDapper
{
    public partial class ClientesForm : Form
    {
        private UserCliente _cliente = new UserCliente();
        
        private readonly IClientesData _data;
        public ClientesForm(IClientesData clientesData)
        {
            InitializeComponent();
            _data = clientesData;
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _data.LoadCategories();
            userClienteBindingSource.Add(_cliente);
        }

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            var clienteValidator = new ClientesValidator();

            var ValidatorResult = clienteValidator.Validate(_cliente);
            if (ValidatorResult.IsValid)
            {
                _data.SaveCustomer(TxtClienteID.Text, TxtNombrecomñia.Text, TxtNombreComtacto.Text, TxtTitulocontacto.Text, TxtDireccion.Text, Txtciudad.Text, TxtRegion.Text,
                TxtCodpostal.Text, Txtciu.Text, TxtTelefono.Text, TxtFax.Text);
                MessageBox.Show("Registro insertado corretamnete");
                limpiar();
                dataGridView1.DataSource = _data.LoadCategories();
            }
            else
            {
                var message = string.Join("\n", ValidatorResult.Errors.Select(a => a.ErrorMessage));
                MessageBox.Show(message, "Validation Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        private void BtModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                
                if (selectedRowIndex >= 0)
                {
                    string customerId = dataGridView1.Rows[selectedRowIndex].Cells["CustomerID"].Value.ToString();

                    
                    TxtClienteID.Text = customerId;

                    
                    _data.UpdateCustomer(customerId, TxtNombrecomñia.Text, TxtNombreComtacto.Text, TxtTitulocontacto.Text, TxtDireccion.Text, Txtciudad.Text, TxtRegion.Text, TxtCodpostal.Text, Txtciu.Text, TxtTelefono.Text, TxtFax.Text);

                    MessageBox.Show("Registro actualizado correctamente");
                    limpiar();
                    
                    dataGridView1.DataSource = _data.LoadCategories();

                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente antes de intentar modificar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void limpiar()
        {
            TxtClienteID.Text = "";
            TxtNombrecomñia.Text = "";
            TxtNombreComtacto.Text = "";
            TxtTitulocontacto.Text = "";
            TxtDireccion.Text = "";
            Txtciudad.Text = "";
            TxtRegion.Text = "";
            TxtCodpostal.Text = "";
            Txtciu.Text = "";
            TxtTelefono.Text = "";
            TxtFax.Text = "";
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

               
                if (selectedRowIndex >= 0)
                {
                    string customerId = dataGridView1.Rows[selectedRowIndex].Cells["CustomerID"].Value.ToString();

                    TxtClienteID.Text = customerId;

                    
                    _data.Deletecustomer(TxtClienteID.Text);
                    MessageBox.Show("Eliminado correctamente");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un cliente antes de intentar eliminar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                dataGridView1.DataSource = _data.LoadCategories();

            }
        
             
       }      
        
    }
}

