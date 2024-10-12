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
    public partial class TerritorioForms : Form
    {
        private readonly ITerritorio _territorio;
        public TerritorioForms(ITerritorio territorio)
        {
            InitializeComponent();
            _territorio = territorio;
            _territorio.cargarcomboProducto(CbShipvia);

        }

        private void TerritorioForms_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _territorio.LoadTerritories();
        }

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            int regionId = int.Parse(CbShipvia.SelectedValue.ToString());
            _territorio.Insert(txtTerritorioID.Text, txtTerritorioDescrip.Text, regionId);

            MessageBox.Show("Guardado correctamente");
        }

        private void Btmodificar_Click(object sender, EventArgs e)
        {


            int regionId = int.Parse(CbShipvia.SelectedValue.ToString());
            _territorio.Update(txtTerritorioID.Text, txtTerritorioDescrip.Text, regionId);

            MessageBox.Show("Actualizado Correctamente ");
            txtTerritorioID.Text = " ";
            txtTerritorioDescrip.Text = " ";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                string territorioID = Convert.ToString(selectedRow.Cells[0].Value);
                txtTerritorioID.Text = territorioID;
            }
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            _territorio.Delete(txtTerritorioID.Text) ;
            MessageBox.Show("Eliminado correctamente ");
        }
    }
}
