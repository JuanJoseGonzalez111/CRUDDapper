using CRUDDapper.Datos;

namespace CRUDDapper
{
    public partial class Form1 : Form
    {
        private ICategoriesDatos categoriesDatos;

        public Form1(ICategoriesDatos categoriesDatos)
        {
            InitializeComponent();
            this.categoriesDatos = categoriesDatos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CategoryForm categoryForm = new CategoryForm(categoriesDatos);
            categoryForm.ShowDialog();
        }
    }

}
