using CRUDDapper.Datos;
using CRUDDapper.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CRUDDapper.Datos.OrdenData;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CRUDDapper
{
    public partial class txtRegionEnvio : Form
    {
        private readonly IOrdenData _ordenData;
        private readonly UserOrdenes _userOrdenes = new UserOrdenes();
        public txtRegionEnvio(IOrdenData ordenData, Orders.Valor info)
        {
            InitializeComponent();

            this._ordenData = ordenData;
        }



        private void OrdersForm_Load(object sender, EventArgs e)
        {
            _ordenData.cargarcomboEmpleado(CbEmpleadoId);
            _ordenData.cargarcomboCliente(CbCLienteID);
            _ordenData.cargarcomboProducto(comboBox1);
            _ordenData.cargarcomboShipper(CbShipvia);
            userOrdenesBindingSource.Add(_userOrdenes);


        }


        private void button2_Click(object sender, EventArgs e)
        {


            var orderDetailsTemp = new DataTable();
            orderDetailsTemp.Columns.Add("ProductID", typeof(int));
            orderDetailsTemp.Columns.Add("UnitPrice", typeof(decimal));
            orderDetailsTemp.Columns.Add("Quantity", typeof(int));
            orderDetailsTemp.Columns.Add("Discount", typeof(float));

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (!row.IsNewRow)
                {
                    orderDetailsTemp.Rows.Add(
                        row.Cells["ProductID"].Value,
                        row.Cells["UnitPrice"].Value,
                        row.Cells["Quantity"].Value,
                        row.Cells["Discount"].Value
                    );
                }

            }

            var categoriaValidator = new OrdenesValidator();

            var ValidatorResult = categoriaValidator.Validate(_userOrdenes);
            if (ValidatorResult.IsValid)
            {
                _ordenData.InsertarDetalleCompleto((string)CbCLienteID.SelectedValue, (int)(CbEmpleadoId.SelectedValue), DateTime.Parse(DateFechadeorden.Text), DateTime.Parse(DateFEcharequerida.Text), DateTime.Parse(dateFechaenvio.Text),
                         (int)CbShipvia.SelectedValue, SqlMoney.Parse(TxtFlete.Text), TxtNombreEnvio.Text, TxtDireccionEnvio.Text, Txtciudadenvio.Text
                         , txtregiondeenvio.Text, TxtCodPostal.Text, TxtPaisEnvio.Text, orderDetailsTemp);
                MessageBox.Show("Procedimiento almacenado ejecutado correctamente.");

                dataGridView2.Refresh();
            }
            else
            {
                var message = string.Join("\n", ValidatorResult.Errors.Select(a => a.ErrorMessage));
                MessageBox.Show(message, "Validation Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }


        private void button4_Click(object sender, EventArgs e)
        {


            string productoId = (string)comboBox1.SelectedValue;
            string precio = textBox2.Text;
            string cantidad = textBox1.Text;
            string Discount = textBox3.Text;
            _ = dataGridView2.Rows.Add(new object[] { productoId, precio, cantidad, Discount, "Eliminar" });
            MessageBox.Show("Insertado correctamente");


            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Focus();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridView2.Columns["Op"].Index)
                return;
            dataGridView2.Rows.RemoveAt(e.RowIndex);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (resultado == DialogResult.Yes)
            {
                
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            string productoId = (string)comboBox1.SelectedValue;
            string precio = textBox2.Text;
            string cantidad = textBox1.Text;
            string Discount = textBox3.Text;
            _ = dataGridView2.Rows.Add(new object[] { productoId, precio, cantidad, Discount, "Eliminar" });
            MessageBox.Show("Cambio realizado");


            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Focus();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
