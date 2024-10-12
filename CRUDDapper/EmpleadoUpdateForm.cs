using CRUDDapper.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CRUDDapper.Datos.EmpleadoData;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUDDapper
{
    public partial class EmpleadoUpdateForm : Form
    {
        private readonly IEmpleadoData _empleadoData;
        public EmpleadoUpdateForm(IEmpleadoData empleadoData, EmpleadoinicioForms.Valor valor1)
        {
            InitializeComponent();
            _empleadoData = empleadoData;
            label13.Text = valor1.id.ToString();
            dataGridView1.AutoGenerateColumns = false;


        }

        private void EmpleadoUpdateForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _empleadoData.LoadEmpleadoa(int.Parse(label13.Text));
            _empleadoData.cargarcombo(comboBox1);
            _empleadoData.cargarcomboTe(comboBox2);
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Eliminar";
            buttonColumn.Text = "Eliminar";
            buttonColumn.UseColumnTextForButtonValue = true; 
            dataGridView1.Columns.Add(buttonColumn);
            comboBox2.Text = " ";
            comboBox1.Text = " ";

        }


        private void button3_Click(object sender, EventArgs e)
        {

            
            string nuevoProductoId = (String)comboBox2.SelectedValue;
       


            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                selectedRow.Cells["Territorio"].Value = nuevoProductoId;
                
                dataGridView1.Refresh();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
               
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                
                string productoId = selectedRow.Cells["Territorio"].Value.ToString();


              
                comboBox2.Text = productoId;

            }
        }


        private void BtModificar_Click(object sender, EventArgs e)
        {
            
            int EmpleadoID = int.Parse(label13.Text);
            
            var orderDetails = _empleadoData.LoadEmpleadoa(int.Parse(label13.Text));

            var orderDetailsTemp1 = new DataTable();
            orderDetailsTemp1.Columns.Add("EmployeeID", typeof(int));
            orderDetailsTemp1.Columns.Add("TerritoryID", typeof(string));

            byte[] imagenBytes = null; 
            if (pictureBox1.Image != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
                    imagenBytes = stream.ToArray();
                }
            }



            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    orderDetailsTemp1.Rows.Add(
                        EmpleadoID,
                        row.Cells["Territorio"].Value);

                }

            }
            _empleadoData.UpdateEmpleadoTerritorio(EmpleadoID, Txtnombre.Text, Txtapellido.Text, Txtitulo.Text, txtcortesia.Text, dateTimePicker1.Value, dateTimePicker2.Value,
    Txtdirrecion.Text, txtciudad.Text, txtregion.Text, txtcodpos.Text, txtpais.Text, Txttelefono.Text, txtextens.Text, imagenBytes, txtNotas.Text,
    ((Empleado)comboBox1.SelectedItem).EmployeeID, orderDetailsTemp1);
     MessageBox.Show("Cambios realizados correctamente");
            dataGridView1.DataSource = _empleadoData.LoadEmpleadoa(int.Parse(label13.Text));


        }
    }
}
