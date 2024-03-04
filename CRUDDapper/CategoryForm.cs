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
        }


        private void button1_Click(object sender, EventArgs e)
        {

            //var categoriesData = new CategoriesDatos();
            //categoriesDataTable = categoriesData.LoadCategories();
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
            // var categoriesData = new CategoriesDatos();


            int selectedRowIndex = dataGridView2.SelectedCells[0].RowIndex;
            int categoryId = Convert.ToInt32(dataGridView2.Rows[selectedRowIndex].Cells["CategoryID"].Value);


            //categoriesData.DeleteCategory(categoryId);
            categoriesDatos.DeleteCategory(categoryId);
            var categoriesDataTable = categoriesDatos.LoadCategories();


            dataGridView2.DataSource = categoriesDataTable;
            dataGridView2.Columns["CategoryID"].HeaderText = "ID de Categoría";
            dataGridView2.Columns["CategoryName"].HeaderText = "Nombre de Categoría";
            dataGridView2.Columns["Description"].HeaderText = "Descripción";
            dataGridView2.Columns["Picture"].HeaderText = "Imagen";


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // textBox1.Text = dataGridView2.SelectedCells[0].RowIndex.ToString();

        }

        private void BTactualizar_Click(object sender, EventArgs e)
        {
            // var categoriesData = new CategoriesDatos();

            int selectedRowIndex = dataGridView2.SelectedCells[0].RowIndex;
            int categoryId = Convert.ToInt32(dataGridView2.Rows[selectedRowIndex].Cells["CategoryID"].Value);


            // categoriesData.UpdateCategory(categoryId, txtxNombre.Text, Txtdescripcion.Text, null);
            categoriesDatos.UpdateCategory(categoryId, txtxNombre.Text, Txtdescripcion.Text, null);
            var categoriesDataTable = categoriesDatos.LoadCategories();


            dataGridView2.DataSource = categoriesDataTable;
            dataGridView2.Columns["CategoryID"].HeaderText = "ID de Categoría";
            dataGridView2.Columns["CategoryName"].HeaderText = "Nombre de Categoría";
            dataGridView2.Columns["Description"].HeaderText = "Descripción";
            dataGridView2.Columns["Picture"].HeaderText = "Imagen";


        }

        private void BTagregar_Click(object sender, EventArgs e)
        {
            var categoriaValidator = new CategoriaValidator();

            var ValidatorResult = categoriaValidator.Validate(_usercategoria);
            if (ValidatorResult.IsValid)
            {
                categoriesDatos.InsertCategory(txtxNombre.Text, Txtdescripcion.Text, null);
                //categoriesData.InsertCategory(txtxNombre.Text, Txtdescripcion.Text, null);

                var categoriesDataTable = categoriesDatos.LoadCategories();


                dataGridView2.DataSource = categoriesDataTable;
                dataGridView2.Columns["CategoryID"].HeaderText = "ID de Categoría";
                dataGridView2.Columns["CategoryName"].HeaderText = "Nombre de Categoría";
                dataGridView2.Columns["Description"].HeaderText = "Descripción";
                dataGridView2.Columns["Picture"].HeaderText = "Imagen";

            }
            else
            {
                var message = string.Join("\n", ValidatorResult.Errors.Select(a => a.ErrorMessage));
                MessageBox.Show(message, "Validation Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } 

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {

            //  usercategoriaBindingSource.Add(_usercategoria1);
            userCategoriaBindingSource.Add(_usercategoria);

        }

     
    }


}
    

