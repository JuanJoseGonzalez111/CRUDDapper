using CRUDDapper.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUDDapper
{
    public partial class RedionTerriUpdate : Form
    {
        private readonly IRegion _region;
        public RedionTerriUpdate(IRegion region, int orderid)
        {
            InitializeComponent();
            _region = region;
            label4.Text = orderid.ToString();
            dataGridView1.AutoGenerateColumns = false;

        }

        private void RedionTerriUpdate_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _region.loaterritory(int.Parse(label4.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Verificar si se ha hecho clic en una celda válida
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Obtener los valores de las celdas de la fila seleccionada
                string descripcion = selectedRow.Cells[0].Value.ToString();
                string id = selectedRow.Cells[1].Value.ToString();

                textBox2.Text = descripcion;
                textBox3.Text = id;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Id = textBox3.Text;
            string Description = textBox2.Text;


            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                selectedRow.Cells[0].Value = Description;
                selectedRow.Cells[1].Value = Id;

                dataGridView1.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int regionId= int.Parse(label4.Text);
            var orderDetailsTemp1 = new DataTable();
            orderDetailsTemp1.Columns.Add("TerritoryID", typeof(string ));
            orderDetailsTemp1.Columns.Add("TerritoryDescription", typeof(string));
           


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    orderDetailsTemp1.Rows.Add(

                        row.Cells[1].Value,
                        row.Cells[0].Value);
                     
                }
            }




            _region.UpdateDetalleCompleto(textBox1.Text, regionId, orderDetailsTemp1);

            MessageBox.Show("Procedimiento almacenado ejecutado correctamente.");
        }
    }
}
