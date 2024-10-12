using CRUDDapper.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDDapper
{
    public partial class RegionForms : Form
    {
        private readonly IRegion _region;
        public RegionForms(IRegion region)
        {
            InitializeComponent();
            this._region = region;
        }

        private void RegionForms_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _region.loadReion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegionTerritoioForms region = new RegionTerritoioForms(_region);
            region.ShowDialog();
        }
        public class Valor
        {
            public int id { get; set; }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                // Verificar si el índice de fila seleccionado es válido
                if (selectedRowIndex >= 0)
                {

                    Valor valor1 = new Valor(); // Crear una nueva instancia de Valor
                    int orderid = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);
                    //MessageBox.Show(orderid.ToString);
                    valor1.id = orderid;
                    RedionTerriUpdate redionTerriUpdate = new RedionTerriUpdate(_region,orderid);
                    redionTerriUpdate.ShowDialog();
                   
                }
            }
        }
    }
}
