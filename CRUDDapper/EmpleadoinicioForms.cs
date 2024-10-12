using CRUDDapper.Datos;
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
    public partial class EmpleadoinicioForms : Form
    {
        private readonly IEmpleadoData _empleadoData;
        public EmpleadoinicioForms(IEmpleadoData empleadoData)
        {
            InitializeComponent();
            _empleadoData = empleadoData;
        }

        public class Valor
        {
            public int id { get; set; }
        }
        private void EmpleadoinicioForms_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _empleadoData.LoadEmpleado();
        }

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            EmpleadoForm empleadoForm = new EmpleadoForm(_empleadoData);
            empleadoForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                // Verificar si el índice de fila seleccionado es válido
                if (selectedRowIndex >= 0)
                {

                    Valor valor1 = new Valor(); // Crear una nueva instancia de Valor
                    int orderid = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["EmployeeID"].Value);
                    //MessageBox.Show(orderid.ToString);
                    valor1.id = orderid;
                    EmpleadoUpdateForm empleadoUpdateForm = new EmpleadoUpdateForm(_empleadoData, valor1);
                    empleadoUpdateForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un pedido antes de intentar editar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                if (selectedRowIndex >= 0)
                {

                    int orderid = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["EmployeeID"].Value);

                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este empleado y sus asignaciones de territorios?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        _empleadoData.UpdateEmpleadoTerritorio(orderid);
                        dataGridView1.DataSource = _empleadoData.LoadEmpleado();
                        MessageBox.Show("Confirmación de eliminación");

                    }

                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un pedido antes de intentar editar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
