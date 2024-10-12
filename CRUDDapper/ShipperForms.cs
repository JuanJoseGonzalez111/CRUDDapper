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
    public partial class ShipperForms : Form
    {
        private readonly IShipperData _data;
        public ShipperForms(IShipperData shipperData)
        {
            InitializeComponent();
            _data = shipperData;
        }

        private void ShipperForms_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _data.LoadCategories();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _data.Create(txtCompaniname.Text, txtTelefono.Text);
            MessageBox.Show("Guardado correctamente");
            dataGridView1.DataSource = _data.LoadCategories();
            txtCompaniname.Text = " ";
            txtTelefono.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                if (selectedRowIndex >= 0)
                {
                    int categoryId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);
                    _data.Update(categoryId,txtCompaniname.Text, txtTelefono.Text);

                    dataGridView1.DataSource = _data.LoadCategories();
                    MessageBox.Show("Categoria actualizada correctamente");


                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoría antes de intentar actualizarla.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                if (selectedRowIndex >= 0)
                {
                    int categoryId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);
                    _data.Delete(categoryId);

                    dataGridView1.DataSource = _data.LoadCategories();
                    MessageBox.Show("Categoria actualizada correctamente");


                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoría antes de intentar actualizarla.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
