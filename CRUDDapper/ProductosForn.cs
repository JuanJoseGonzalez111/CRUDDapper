using CRUDDapper.Datos;
using CRUDDapper.Validator;
using Dapper;
using Microsoft.Data.SqlClient;
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
    public partial class ProductosForn : Form
    {

        private UserProducto _userProducto = new UserProducto();
        private readonly IProductdata _productdata;
        private readonly ISqlConnectionFactory _connectionfactory;
        public ProductosForn(IProductdata productdata, ISqlConnectionFactory sqlConnectionFactory)
        {
            InitializeComponent();
            this._productdata = productdata;
            this._connectionfactory = sqlConnectionFactory;
            dataGridView1.Hide();
            txtprecioporunidad.Text = " ";
            
        }

        private void ProductosForn_Load(object sender, EventArgs e)
        {

            _productdata.cargarcomboCate(comboBox1);
            _productdata.cargarcomboSuplidor(COMBOSuplidor);
            userProductoBindingSource.Add(_userProducto);


        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool esInterrumpido;
            decimal precioporunidad;
            short unidadenstock, unidadesenordenes, reordenamiento;

            var categoriaValidator = new productoVAlidator();

            var ValidatorResult = categoriaValidator.Validate(_userProducto);
            if (ValidatorResult.IsValid)
            {
                if (bool.TryParse(comboBox2.Text, out esInterrumpido) &&
              decimal.TryParse(txtprecioporunidad.Text, out precioporunidad) &&
              short.TryParse(txtUnidadStock.Text, out unidadenstock) &&
              short.TryParse(txtUnidadesenordenes.Text, out unidadesenordenes) &&
              short.TryParse(txtReordenaenivel.Text, out reordenamiento))
                {

                    _productdata.InsertarProductoCompleto(txtNombreProducto.Text, (int)comboBox1.SelectedValue, (int)COMBOSuplidor.SelectedValue,
                       txtCatidadporunidad.Text, precioporunidad, unidadenstock, unidadesenordenes, reordenamiento, esInterrumpido);

                    var productoDatatable = _productdata.LoadProductos();
                    dataGridView1.DataSource = productoDatatable;
                }
                else
                {
                    // Manejar el caso en el que la conversión falla, por ejemplo, mostrar un mensaje al usuario.
                    MessageBox.Show("Alguno de los valores no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                var message = string.Join("\n", ValidatorResult.Errors.Select(a => a.ErrorMessage));
                MessageBox.Show(message, "Validation Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                // Verificar si el índice de fila seleccionado es válido
                if (selectedRowIndex >= 0)
                {

                    int categoryId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["ProductID"].Value);

                    bool? esInterrumpido = null;
                    decimal? precioporunidad = null;
                    short? unidadenstock = null, unidadesenordenes = null, reordenamiento = null;

                    if (!string.IsNullOrWhiteSpace(comboBox2.Text))
                    {
                        if (!bool.TryParse(comboBox2.Text, out bool parsedValue))
                        {
                            MessageBox.Show("El valor de 'esInterrumpido' no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        esInterrumpido = parsedValue;
                    }

                    if (!string.IsNullOrWhiteSpace(txtprecioporunidad.Text))
                    {
                        if (!decimal.TryParse(txtprecioporunidad.Text, out decimal parsedValue))
                        {
                            MessageBox.Show("El valor de 'precioporunidad' no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        precioporunidad = parsedValue;
                    }

                    if (!string.IsNullOrWhiteSpace(txtUnidadStock.Text))
                    {
                        if (!short.TryParse(txtUnidadStock.Text, out short parsedValue))
                        {
                            MessageBox.Show("El valor de 'unidadenstock' no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        unidadenstock = parsedValue;
                    }

                    if (!string.IsNullOrWhiteSpace(txtUnidadesenordenes.Text))
                    {
                        if (!short.TryParse(txtUnidadesenordenes.Text, out short parsedValue))
                        {
                            MessageBox.Show("El valor de 'unidadesenordenes' no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        unidadesenordenes = parsedValue;
                    }

                    if (!string.IsNullOrWhiteSpace(txtReordenaenivel.Text))
                    {
                        if (!short.TryParse(txtReordenaenivel.Text, out short parsedValue))
                        {
                            MessageBox.Show("El valor de 'reordenamiento' no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        reordenamiento = parsedValue;
                    }
                                _productdata.ModificarProductoCompleto(categoryId,
                        txtNombreProducto.Text,
                        (int)comboBox1.SelectedValue,
                        (int)comboBox1.SelectedValue,
                        txtCatidadporunidad.Text,
                        precioporunidad ?? 0,
                        unidadenstock ?? 0,
                        unidadesenordenes ?? 0,
                        reordenamiento ?? 0,
                        esInterrumpido ?? false);



                    var productoDatatable = _productdata.LoadProductos();
                    dataGridView1.DataSource = productoDatatable;

                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoría antes de intentar eliminar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                // Verificar si el índice de fila seleccionado es válido
                if (selectedRowIndex >= 0)
                {
                    int categoryId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["ProductID"].Value);
                    MessageBox.Show($"OrderID: {categoryId}");
                    _productdata.DeleteProductos(categoryId);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoría antes de intentar eliminar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            var productoDatatable = _productdata.LoadProductos();
            dataGridView1.DataSource = productoDatatable;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (resultado == DialogResult.Yes)
            {
                
                Application.Exit();
            }
        }
    }
}
