using CRUDDapper.Datos;
using CRUDDapper.Validator;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
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
    public partial class CategoryForm : Form
    {
        private UserCategoria _usercategoria = new UserCategoria();
        private readonly ICategoriesDatos categoriesDatos;

        public CategoryForm(ICategoriesDatos categoriesDatos)
        {
            InitializeComponent();

            this.categoriesDatos = categoriesDatos;
            dataGridView2.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Show();

            var categoriesDataTable = categoriesDatos.LoadCategories();


            dataGridView2.DataSource = categoriesDataTable;
            dataGridView2.Columns["CategoryID"].HeaderText = "ID de Categoría";
            dataGridView2.Columns["CategoryID"].Width = 100;
            dataGridView2.Columns["CategoryName"].HeaderText = "Nombre de Categoría";
            dataGridView2.Columns["CategoryName"].Width = 200;
            dataGridView2.Columns["Description"].HeaderText = "Descripción";
            dataGridView2.Columns["Description"].Width = 250;
            dataGridView2.Columns["Picture"].HeaderText = "Imagen";
            dataGridView2.Columns["Picture"].Width = 150;
        }

        private void BTeliminar_Click(object sender, EventArgs e)
        {


            if (dataGridView2.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView2.SelectedCells[0].RowIndex;

                if (selectedRowIndex >= 0)
                {
                    int categoryId = Convert.ToInt32(dataGridView2.Rows[selectedRowIndex].Cells["CategoryID"].Value);
                    categoriesDatos.DeleteCategory(categoryId);
                    dataGridView2.DataSource = categoriesDatos.LoadCategories();
                    MessageBox.Show("Categoria eliminada correctamente " + "Eliminado ");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoría antes de intentar eliminar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void BTactualizar_Click(object sender, EventArgs e)
        {

            if (dataGridView2.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView2.SelectedCells[0].RowIndex;

                if (selectedRowIndex >= 0)
                {
                    int categoryId = Convert.ToInt32(dataGridView2.Rows[selectedRowIndex].Cells["CategoryID"].Value);

                    categoriesDatos.UpdateCategory(categoryId, txtxNombre.Text, Txtdescripcion.Text, null);
                    limpiar();
                    dataGridView2.DataSource = categoriesDatos.LoadCategories();
                    MessageBox.Show("Categoria actualizada correctamente");


                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoría antes de intentar actualizarla.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void BTagregar_Click(object sender, EventArgs e)
        {
            var categoriaValidator = new CategoriaValidator();

            var ValidatorResult = categoriaValidator.Validate(_usercategoria);
            if (ValidatorResult.IsValid)
            {
                categoriesDatos.InsertCategory(txtxNombre.Text, Txtdescripcion.Text, null);
                MessageBox.Show("Categoria agregada  correctamente");
                limpiar();
                dataGridView2.DataSource = categoriesDatos.LoadCategories();



            }
            else
            {
                var message = string.Join("\n", ValidatorResult.Errors.Select(a => a.ErrorMessage));
                MessageBox.Show(message, "Validation Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = categoriesDatos.LoadCategories();
            userCategoriaBindingSource.Add(_usercategoria);
            txtxNombre.Focus();

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes)
            {

                Application.Exit();
            }
        }
        public void limpiar()
        {
            txtxNombre.Text = " ";
            txtxNombre.Focus();
            Txtdescripcion.Text = " ";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
    

