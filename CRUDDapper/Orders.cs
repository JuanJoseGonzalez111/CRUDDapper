using CRUDDapper.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CRUDDapper.Orders;

namespace CRUDDapper
{
    public partial class Orders : Form
    {
        private Valor valor1;
        private readonly IOrdenData _ordenData;
        public Orders(IOrdenData ordenData)
        {
            InitializeComponent();
            _ordenData = ordenData;
         

        }

        private void Orders_Load(object sender, EventArgs e)
        {

            var orderDatatable = _ordenData.LoadOrden();
            dataGridView1.DataSource = orderDatatable;
        }

        private void btLeer_Click(object sender, EventArgs e)
        {

            var orderDatatable = _ordenData.LoadOrden();
            dataGridView1.DataSource = orderDatatable;
        }


        
        private void bteliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
               
                if (selectedRowIndex >= 0)
                {
                    int orderid = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["OrderID"].Value);

                    DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar este pedido?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        _ordenData.DeleteOrderAndDetails(orderid);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = _ordenData.LoadOrden();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un pedido antes de intentar eliminar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

          
            if (resultado == DialogResult.Yes)
            {
                
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public class Valor
        {
            public int id { get; set; }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
               
                if (selectedRowIndex >= 0)
                {
                    Valor valor1 = new Valor(); 
                    int orderid = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["OrderID"].Value);
                    valor1.id = orderid;

                    OrderUpdateForm txtRegionEnvioForm = new OrderUpdateForm(_ordenData, valor1);
                    txtRegionEnvioForm.ShowDialog();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = _ordenData.LoadOrden();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un pedido antes de intentar editar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

     
        private void btAgregar_Click_1(object sender, EventArgs e)
        {
            
            txtRegionEnvio txtRegionEnvio = new txtRegionEnvio(_ordenData, valor1);
            txtRegionEnvio.ShowDialog();
        }


    }
}
