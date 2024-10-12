using CRUDDapper.Datos;
using CRUDDapper.Validator;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CRUDDapper
{
    public partial class Suplierform : Form
    {
        private UserSuplidores _userSuplidores = new UserSuplidores();
        private readonly ISuplidoresData _suplidoresData;
        public Suplierform(ISuplidoresData suplidoresData)
        {
            InitializeComponent();
            this._suplidoresData = suplidoresData;
            dataGridView1.Hide();
        }

        private void Suplierform_Load(object sender, EventArgs e)
        {

            userSuplidoresBindingSource.Add(_userSuplidores);
        }

        private void BtAgregar_Click(object sender, EventArgs e)
        {

            var categoriaValidator = new serSuplidoresValidator();

            var ValidatorResult = categoriaValidator.Validate(_userSuplidores);
            if (ValidatorResult.IsValid)
            {
                _suplidoresData.InsertarProveedorCompleto(txtNombreCon.Text, txtNombreconta.Text, txtcontatoTitle.Text, txtDirrecion.Text, txtciudad.Text, txtRegion.Text, txtCodigopostal.Text, txtPais.Text, txttelefono.Text, txtFax.Text, txtHomepage.Text);


            }
            else
            {
                var message = string.Join("\n", ValidatorResult.Errors.Select(a => a.ErrorMessage));
                MessageBox.Show(message, "Validation Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                // Verificar si el índice de fila seleccionado es válido
                if (selectedRowIndex >= 0)
                {
                    int categoryId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["SupplierID"].Value);
                    _suplidoresData.EliminarProveedor(categoryId);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoría antes de intentar eliminar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Btmodificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                // Verificar si el índice de fila seleccionado es válido
                if (selectedRowIndex >= 0)
                {
                    int categoryId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["SupplierID"].Value);
                    _suplidoresData.ModificarProveedorCompleto(categoryId, txtNombreCon.Text, txtNombreconta.Text, txtcontatoTitle.Text, txtDirrecion.Text, txtciudad.Text, txtRegion.Text, txtCodigopostal.Text, txtPais.Text, txttelefono.Text, txtFax.Text, txtHomepage.Text);

                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoría antes de intentar modifiar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            var SuplierDatatable = _suplidoresData.LoadSuplidores();
            dataGridView1.DataSource = SuplierDatatable;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // Si el usuario elige "Sí", cerrar la aplicación
                Application.Exit();
            }
        }
    }
}
