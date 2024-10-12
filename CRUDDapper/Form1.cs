using CRUDDapper.Datos;

namespace CRUDDapper
{
    public partial class Form1 : Form
    {
        private ICategoriesDatos categoriesDatos;
        private IProductdata productdata;
        private ISuplidoresData suplidoresData;
        private IOrdenData ordenData;
        private ISqlConnectionFactory sqlConnectionFactory;
        private IClientesData _clientesData;
        private IEmpleadoData _empleadoData;
        private IRegion _region;
        private ITerritorio _itorio;
        private IShipperData _shipperData;

        public Form1(ICategoriesDatos categoriesDatos, IProductdata productdata, ISuplidoresData suplidoresData, IOrdenData ordenData,
            ISqlConnectionFactory sqlConnectionFactory, IClientesData clientesData, IEmpleadoData empleadoData, IRegion region, ITerritorio territorio,IShipperData shipperData)
        {
            InitializeComponent();
            this.categoriesDatos = categoriesDatos;
            this.productdata = productdata;
            this.suplidoresData = suplidoresData;
            this.ordenData = ordenData;
            this.sqlConnectionFactory = sqlConnectionFactory;
            this._clientesData = clientesData;
            this._region = region;
            DateTime horaActual = DateTime.Now;
            _empleadoData = empleadoData;
            _itorio = territorio;
            _shipperData = shipperData;


            // Actualizar el contenido del Label con la hora actual formateada

        }


        private void button1_Click(object sender, EventArgs e)
        {

            CategoryForm categoryForm = new CategoryForm(categoriesDatos);
            categoryForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductosForn productosForn = new ProductosForn(productdata, sqlConnectionFactory);
            productosForn.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DateTime horaActual = DateTime.Now;

            // Actualizar el contenido del Label con la hora actual formateada

        }

        private void Btsuplidores_Click(object sender, EventArgs e)
        {
            Suplierform suplierform = new Suplierform(suplidoresData);
            suplierform.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Orders orders = new Orders(ordenData);
            orders.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar salida",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // Si el usuario elige "Sí", cerrar la aplicación
                Application.Exit();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientesForm clientesForm = new ClientesForm(_clientesData);
            clientesForm.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmpleadoinicioForms empleadoinicioForms = new EmpleadoinicioForms(_empleadoData);
            empleadoinicioForms.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegionForms region = new RegionForms(_region);
            region.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TerritorioForms territorioForms = new TerritorioForms(_itorio);
            territorioForms.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShipperForms shipperForms = new ShipperForms(_shipperData);
                shipperForms.ShowDialog();
        }
    }

}
