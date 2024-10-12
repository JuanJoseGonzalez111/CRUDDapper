using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CRUDDapper.ProductosForn;

namespace CRUDDapper.Datos
{
    class Productdata : IProductdata
    {

        private readonly ISqlConnectionFactory _sqlconnectionFactory;
        public Productdata(ISqlConnectionFactory sqlConnectionFactory)
        {
            this._sqlconnectionFactory = sqlConnectionFactory;
        }
        public DataTable LoadProductos()
        {


            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {


                var query = "Exec listadeProducto";
                var adapter = new SqlDataAdapter(query, (SqlConnection)connection);

                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
        public class Category
        {
            public int CategoryID { get; set; }
            public string CategoryName { get; set; }
        }
        public class Suplier
        {
            public int SupplierID { get; set; }
            public string CompanyName { get; set; }
        }
        public void cargarcomboCate(ComboBox comboBox)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var categories = connection.Query<Category>("SELECT CategoryID, CategoryName FROM Categories").ToList();

                comboBox.DisplayMember = "CategoryName"; 
                comboBox.ValueMember = "CategoryID";      
                comboBox.DataSource = categories;

                connection.Close();
            }
        }
        public void cargarcomboSuplidor(ComboBox comboBox)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var supliers = connection.Query<Suplier>("Select SupplierID, CompanyName  from Suppliers").ToList();

                comboBox.DisplayMember = "CompanyName"; 
                comboBox.ValueMember = "SupplierID";      
                comboBox.DataSource = supliers;

                connection.Close();
            }
        }

        public void InsertarProductoCompleto(string nombreProducto, int categoriaID, int proveedorID, string cantidadPorUnidad, decimal precioUnitario, short unidadesEnStock, short unidadesEnPedido, short nivelNuevoPedido, bool suspendido)
        {

            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = @"
            INSERT INTO Products (ProductName, CategoryID, SupplierID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued)
            VALUES (@NombreProducto, @CategoriaID, @ProveedorID, @CantidadPorUnidad, @PrecioUnitario, @UnidadesEnStock, @UnidadesEnPedido, @NivelNuevoPedido, @Suspendido)";

                connection.Execute(query, new
                {
                    NombreProducto = nombreProducto,
                    CategoriaID = categoriaID,
                    ProveedorID = proveedorID,
                    CantidadPorUnidad = cantidadPorUnidad,
                    PrecioUnitario = precioUnitario,
                    UnidadesEnStock = unidadesEnStock,
                    UnidadesEnPedido = unidadesEnPedido,
                    NivelNuevoPedido = nivelNuevoPedido,
                    Suspendido = suspendido
                });

                MessageBox.Show("Producto insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ModificarProductoCompleto(int productID, string nombreProducto, int categoriaID, int proveedorID, string cantidadPorUnidad, decimal precioUnitario, short unidadesEnStock, short unidadesEnPedido, short nivelNuevoPedido, bool suspendido)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = "UPDATE Products SET ";

                var columnAssignments = new List<string>();

                if (!string.IsNullOrEmpty(nombreProducto))
                {
                    columnAssignments.Add("ProductName = @NombreProducto");
                }
                if (categoriaID != 0)
                {
                    columnAssignments.Add("CategoryID = @CategoriaID");
                }
                if (proveedorID != 0)
                {
                    columnAssignments.Add("SupplierID = @ProveedorID");
                }
                if (!string.IsNullOrEmpty(cantidadPorUnidad))
                {
                    columnAssignments.Add("QuantityPerUnit = @CantidadPorUnidad");
                }
                if (precioUnitario != 0)
                {
                    columnAssignments.Add("UnitPrice = @PrecioUnitario");
                }
                if (unidadesEnStock != 0)
                {
                    columnAssignments.Add("UnitsInStock = @UnidadesEnStock");
                }
                if (unidadesEnPedido != 0)
                {
                    columnAssignments.Add("UnitsOnOrder = @UnidadesEnPedido");
                }
                if (nivelNuevoPedido != 0)
                {
                    columnAssignments.Add("ReorderLevel = @NivelNuevoPedido");
                }
                columnAssignments.Add("Discontinued = @Suspendido");

                query += string.Join(", ", columnAssignments);

                query += " WHERE ProductID = @ProductID";

                connection.Execute(query, new
                {
                    ProductID = productID,
                    NombreProducto = nombreProducto,
                    CategoriaID = categoriaID,
                    ProveedorID = proveedorID,
                    CantidadPorUnidad = cantidadPorUnidad,
                    PrecioUnitario = precioUnitario,
                    UnidadesEnStock = unidadesEnStock,
                    UnidadesEnPedido = unidadesEnPedido,
                    NivelNuevoPedido = nivelNuevoPedido,
                    Suspendido = suspendido
                });

                MessageBox.Show("Producto modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void DeleteProductos(int productoId)
        {


            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
             

                var query = "Delete  from Products where ProductID = @ProductoId";
                connection.Execute(query, new { ProductoId = productoId });
            }
            MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





    }
}
