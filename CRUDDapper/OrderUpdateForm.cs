using CRUDDapper.Datos;
using CRUDDapper.Validator;
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
using static CRUDDapper.Datos.OrdenData;

namespace CRUDDapper
{
    public partial class OrderUpdateForm : Form
    {
        private readonly IOrdenData _ordenData;
        public OrderUpdateForm(IOrdenData ordenData, Orders.Valor info)
        {
            InitializeComponent();
            _ordenData = ordenData;
            label1.Text = info.id.ToString();
            dataGridView2.AutoGenerateColumns = false;
        }

        private void OrderUpdateForm_Load(object sender, EventArgs e)
        {

            _ordenData.cargarcomboEmpleado(CbEmpleadoId);
            _ordenData.cargarcomboCliente(CbCLienteID);
            _ordenData.cargarcomboProducto(comboBox1);
            _ordenData.cargarcomboShipper(CbShipvia);
            string c = label1.Text;
            var orderDatatable = _ordenData.GetOrderDetailsByOrderID(c);
            dataGridView2.DataSource = orderDatatable;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Eliminar";
            buttonColumn.Text = "Eliminar";
            buttonColumn.UseColumnTextForButtonValue = true; // Muestra el texto en lugar del botón de estilo de celda
            dataGridView2.Columns.Add(buttonColumn);
            
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                row.Cells["Op"].Value = "Eliminar";
            }

        }



        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];

                
                string productoId = selectedRow.Cells["ProductID"].Value.ToString();
                string precio = selectedRow.Cells["UnitPrice"].Value.ToString();
                string discount = selectedRow.Cells["Discount"].Value.ToString();
                string cantidad = selectedRow.Cells["Quantity"].Value.ToString();

              
                comboBox1.Text = productoId;
                textBox1.Text = precio;
                textBox2.Text = cantidad;
                textBox3.Text = discount;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            int orderId = int.Parse(label1.Text);
            string a = Convert.ToString(label1.Text);
            var orderDetails = _ordenData.GetOrderDetailsByOrderID(a);

            var orderDetailsTemp1 = new DataTable();
            orderDetailsTemp1.Columns.Add("OrderID", typeof(int));
            orderDetailsTemp1.Columns.Add("ProductID", typeof(int));
            orderDetailsTemp1.Columns.Add("UnitPrice", typeof(decimal));
            orderDetailsTemp1.Columns.Add("Quantity", typeof(int));
            orderDetailsTemp1.Columns.Add("Discount", typeof(float));


            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (!row.IsNewRow)
                {
                    orderDetailsTemp1.Rows.Add(
                        orderId,
                        row.Cells["ProductID"].Value,
                        row.Cells["UnitPrice"].Value,
                        row.Cells["Quantity"].Value,
                        row.Cells["Discount"].Value != null ? Convert.ToSingle((decimal)row.Cells["Discount"].Value) : 0.0f);
                }
            }




            string customerID = CbCLienteID.SelectedValue as string;
            int employeeID = (int)CbEmpleadoId.SelectedValue;
            DateTime orderDate = DateTime.Parse(DateFechadeorden.Text);
            DateTime requiredDate = DateTime.Parse(DateFEcharequerida.Text);
            DateTime shippedDate = DateTime.Parse(dateFechaenvio.Text);
            int shipVia = (int)CbShipvia.SelectedValue;
            SqlMoney freight = string.IsNullOrEmpty(TxtFlete.Text) ? SqlMoney.Null : SqlMoney.Parse(TxtFlete.Text);
            string shipName = TxtNombreEnvio.Text;
            string shipAddress = TxtDireccionEnvio.Text;
            string shipCity = Txtciudadenvio.Text;
            string shipRegion = txtregiondeenvio.Text;
            string shipPostalCode = TxtCodPostal.Text;
            string shipCountry = TxtPaisEnvio.Text;

            _ordenData.UpdateDetalleCompleto(orderId, customerID, employeeID, orderDate, requiredDate, shippedDate, shipVia, freight, shipName, shipAddress, shipCity, shipRegion, shipPostalCode, shipCountry, orderDetailsTemp1);


            MessageBox.Show("Procedimiento almacenado ejecutado correctamente.");

            dataGridView2.Refresh();
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            
            
            string  nuevoProductoId =(string) comboBox1.SelectedValue;
            string nuevoPrecio = textBox1.Text;
            string nuevaCantidad = textBox2.Text;
            string nuevoDescuento = textBox3.Text;


            if (dataGridView2.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                selectedRow.Cells["ProductID"].Value = nuevoProductoId;
                selectedRow.Cells["UnitPrice"].Value = nuevoPrecio;
                selectedRow.Cells["Quantity"].Value = nuevaCantidad;
                selectedRow.Cells["Discount"].Value = nuevoDescuento;
                dataGridView2.Refresh();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridView2.Columns["Op"].Index)
                return;
            dataGridView2.Rows.RemoveAt(e.RowIndex);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
