using System.Data;
using System.Data.SqlTypes;
using static CRUDDapper.Datos.OrdenData;

namespace CRUDDapper.Datos
{
    public interface IOrdenData
    {
        DataTable LoadOrden();
        public void InsertarOrdenCompleta(string CustomerID, int EmpleoyesID, DateTime OrderDate, int ProductID, int Unitprice, int Cantidad);

        public void InsertarDetalle(string customerID, int employeeID, DateTime orderDate, DataTable orderDetailsTemp);
        public void cargarcomboEmpleado(ComboBox comboBox);
        public void cargarcomboCliente(ComboBox comboBox);
        public void cargarcomboProducto(ComboBox comboBox);
        public void DeleteOrderAndDetails(int orderID);
        public void InsertarDetalleCompleto(string customerID, int employeeID, DateTime orderDate, DateTime requiredDate,
          DateTime shippedDate, int shipVia, SqlMoney freight, string shipName, string shipAddress, string shipCity,
          string shipRegion, string shipPostalCode, string shipCountry, DataTable orderDetailsTemp);
        public void UpdateDetalleCompleto(int OrdersID, string customerID, int employeeID, DateTime orderDate, DateTime requiredDate,
         DateTime shippedDate, int shipVia, SqlMoney freight, string shipName, string shipAddress, string shipCity,
         string shipRegion, string shipPostalCode, string shipCountry, DataTable orderDetailsTemp);
        public void cargarcomboShipper(ComboBox comboBox);
        public void UpdateOrderDetails(IEnumerable<OrderDetail> orderDetails,int orderid);


        public IEnumerable<OrderDetail> GetOrderDetailsByOrderID(string orderID);

    }
}