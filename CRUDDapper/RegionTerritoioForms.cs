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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUDDapper
{
    public partial class RegionTerritoioForms : Form
    {
        private readonly IRegion _region;
        public RegionTerritoioForms(IRegion region)
        {
            InitializeComponent();
            this._region = region;
        }

        private void RegionTerritoioForms_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string TerritoryId = textBox3.Text;
            string Descripcion = textBox2.Text;

            _ = dataGridView1.Rows.Add(new object[] { TerritoryId, Descripcion, "Eliminar" });
            MessageBox.Show("Insertado correctamente");


            textBox2.Text = "";
            textBox3.Text = "";
        }
            
        private void button2_Click(object sender, EventArgs e)
        {
            var RegioTerritorio = new DataTable();
            RegioTerritorio.Columns.Add("TerritorioID");
            RegioTerritorio.Columns.Add("TerritorioDespcricion");


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    RegioTerritorio.Rows.Add(
                     row.Cells[0].Value,
                     row.Cells[1].Value);



                }

            }
            _region.InsertarDetalleCompleto(textBox1.Text, RegioTerritorio);
            MessageBox.Show("Ejecutado correctamente");
        }
    }
}
