using System.Data;

namespace CRUDDapper.Datos
{
    public interface IProductdata
    {
        DataTable LoadProductos();
        public void InsertarProductoCompleto(string nombreProducto, int categoriaID, int proveedorID, string cantidadPorUnidad, decimal precioUnitario, short unidadesEnStock, short unidadesEnPedido, short nivelNuevoPedido, bool suspendido);
        public void ModificarProductoCompleto(int productID, string nombreProducto, int categoriaID, int proveedorID, string cantidadPorUnidad, decimal precioUnitario, short unidadesEnStock, short unidadesEnPedido, short nivelNuevoPedido, bool suspendido);
        public void DeleteProductos(int categoryId);
        public void cargarcomboCate(ComboBox comboBox);
        public void cargarcomboSuplidor(ComboBox comboBox);
        
    }
}