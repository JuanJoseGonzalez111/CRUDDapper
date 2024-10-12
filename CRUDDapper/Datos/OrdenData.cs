using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static CRUDDapper.Datos.Productdata;

namespace CRUDDapper.Datos
{
    internal class OrdenData : IOrdenData
    {
        private readonly ISqlConnectionFactory _sqlconnectionFactory;
        public OrdenData(ISqlConnectionFactory sqlConnectionFactory)
        {
            this._sqlconnectionFactory = sqlConnectionFactory;
        }
        public DataTable LoadOrden()
        {


            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {


                var query = "GetOrderDetails";
                var adapter = new SqlDataAdapter(query, (SqlConnection)connection);

                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
        public IEnumerable<OrderDetail> GetOrderDetailsByOrderID(string orderID)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                var orderDetails = connection.Query<OrderDetail>("GetOrderDetailsByOrderID", new { orderID }, commandType: CommandType.StoredProcedure);

                return orderDetails;


            }
        }
        public void UpdateOrderDetails(IEnumerable<OrderDetail> OrderDetailType1, int orderid)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                // Por cada detalle de orden, ejecutar una consulta de actualización
                foreach (var detail in OrderDetailType1)
                {
                    var query = @"UPDATE OrderDetails 
                          SET ProductId = @ProductId, 
                              Price = @unitPrice, 
                              Quantity = @Quantity, 
                              Discount = @Discount
                          WHERE OrderID = @Orderid";

                    connection.Execute(query, new
                    {
                        OrderID = orderid,
                        detail.ProductId,
                        detail.Quantity,
                        detail.Discount,
                        detail.unitPrice,

                    });
                }
            }
        }


        public class Empleado
        {
            public string FullName { get; set; }
            public int EmployeeID { get; set; }
        }

        public void cargarcomboEmpleado(ComboBox comboBox)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = "SELECT FirstName + ' ' + LastName AS FullName, EmployeeID FROM Employees";
                var empleados = connection.Query<Empleado>(query).ToList();

                comboBox.DisplayMember = "FullName"; // Mostrar el nombre completo del empleado
                comboBox.ValueMember = "EmployeeID"; // El valor subyacente es el EmployeeID
                comboBox.DataSource = empleados;

                connection.Close();
            }
        }
        public class Cliente
        {
            public string CompanyName { get; set; }
            public string CustomerID { get; set; }
        }

        public void cargarcomboCliente(ComboBox comboBox)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = "SELECT CompanyName, CustomerID FROM Customers";
                var clientes = connection.Query<Cliente>(query).ToList();

                comboBox.DisplayMember = "CompanyName"; // Mostrar el nombre de la compañía del cliente
                comboBox.ValueMember = "CustomerID";     // El valor subyacente es el CustomerID
                comboBox.DataSource = clientes;

                connection.Close();
            }
        }
        public class Shipper
        {
            public string CompanyName { get; set; }
            public int ShipperID { get; set; }
        }

        public void cargarcomboShipper(ComboBox comboBox)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = "\tSelect ShipperID,CompanyName from Shippers";
                var clientes = connection.Query<Shipper>(query).ToList();

                comboBox.DisplayMember = "CompanyName"; // Mostrar el nombre de la compañía del cliente
                comboBox.ValueMember = "ShipperID";     // El valor subyacente es el CustomerID
                comboBox.DataSource = clientes;

                connection.Close();
            }
        }
        public class Producto
        {
            public string ProductName { get; set; }
            public string ProductID { get; set; }
        }

        public void cargarcomboProducto(ComboBox comboBox)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = "Select ProductID,ProductName from Products";
                var producto = connection.Query<Producto>(query).ToList();

                comboBox.DisplayMember = "ProductName"; // Mostrar el nombre de la compañía del cliente
                comboBox.ValueMember = "ProductID";     // El valor subyacente es el CustomerID
                comboBox.DataSource = producto;

                connection.Close();
            }
        }


        public void InsertarOrdenCompleta(string CustomerID, int EmpleoyesID, DateTime OrderDate, int ProductID, int Unitprice, int Cantidad)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = @"
            EXEC ProcedimientoC# @CustomerID, @EmployeeID, @OrderDate, @ProductID, @Unitprice, @Cantidad";

                connection.Execute(query, new
                {
                    CustomerID = CustomerID,
                    EmployeeID = EmpleoyesID,
                    OrderDate = OrderDate,
                    ProductID = ProductID,
                    Unitprice = Unitprice,
                    Cantidad = Cantidad
                });

                MessageBox.Show("Orden insertada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void InsertarDetalleCompleto(string customerID, int employeeID, DateTime orderDate, DateTime requiredDate,
            DateTime shippedDate, int shipVia, SqlMoney freight, string shipName, string shipAddress, string shipCity,
            string shipRegion, string shipPostalCode, string shipCountry, DataTable orderDetailsTemp)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Execute("ProcedimientoCompleto#", new
                {
                    CustomerID = customerID,
                    EmployeeID = employeeID,
                    OrderDate = orderDate,
                    RequiredDate = requiredDate, // Corrected parameter name
                    ShippedDate = shippedDate,
                    ShipVia = shipVia,
                    Freigt = (decimal)freight.Value,
                    ShipName = shipName,
                    ShipAddress = shipAddress,
                    ShipCity = shipCity,
                    ShipRegion = shipRegion,
                    ShipPostalCode = shipPostalCode,
                    ShipCountry = shipCountry,
                    OrderDetailsTemp = orderDetailsTemp.AsTableValuedParameter("OrderDetailType1")
                }, commandType: CommandType.StoredProcedure);


            }
        }

        public void InsertarDetalle(string customerID, int employeeID, DateTime orderDate, DataTable orderDetailsTemp)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Execute("ProcedimientoCa#", new
                {
                    CustomerID = customerID,
                    EmployeeID = employeeID,
                    OrderDate = orderDate,
                    OrderDetailsTemp = orderDetailsTemp.AsTableValuedParameter("OrderDetailType")
                }, commandType: CommandType.StoredProcedure);


            }
        }
        public void DeleteOrderAndDetails(int orderID)
        {
            using (IDbConnection db = _sqlconnectionFactory.GetDbConnection())
            {
                // Llamada al procedimiento almacenado utilizando Dapper
                try
                {
                    db.Execute("DeleteOrderAndDetails", new { OrderID = orderID }, commandType: CommandType.StoredProcedure);
                    MessageBox.Show("La orden ha sido eliminada correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar orden: {ex.Message}");
                }


            }
        }

         public void UpdateDetalleCompleto(int OrdersID, string customerID, int employeeID, DateTime orderDate, DateTime requiredDate,
      DateTime shippedDate, int shipVia, SqlMoney freight, string shipName, string shipAddress, string shipCity,
      string shipRegion, string shipPostalCode, string shipCountry, DataTable orderDetailsTemp)
         {
             using (var connection = _sqlconnectionFactory.GetDbConnection())
             {
                 connection.Open();


                 using (var transaction = connection.BeginTransaction())
                 {
                     try
                     {

                         var queryOrders = @"
                     UPDATE Orders 
                     SET ";

                         var columnAssignmentsOrders = new List<string>();

                         if (!string.IsNullOrEmpty(customerID))
                         {
                             columnAssignmentsOrders.Add("CustomerID = @CustomerID");
                         }
                         if (employeeID != 0)
                         {
                             columnAssignmentsOrders.Add("EmployeeID = @EmployeeID");
                         }
                         if (orderDate != DateTime.MinValue)
                         {
                             columnAssignmentsOrders.Add("OrderDate = @OrderDate");
                         }
                         if (requiredDate != DateTime.MinValue)
                         {
                             columnAssignmentsOrders.Add("RequiredDate = @RequiredDate");
                         }
                         if (shippedDate != DateTime.MinValue)
                         {
                             columnAssignmentsOrders.Add("ShippedDate = @ShippedDate");
                         }
                         if (shipVia != 0)
                         {
                             columnAssignmentsOrders.Add("ShipVia = @ShipVia");
                         }
                         if (!freight.IsNull)
                         {
                             columnAssignmentsOrders.Add("Freight = @Freight");
                         }
                         if (!string.IsNullOrEmpty(shipName))
                         {
                             columnAssignmentsOrders.Add("ShipName = @ShipName");
                         }
                         if (!string.IsNullOrEmpty(shipAddress))
                         {
                             columnAssignmentsOrders.Add("ShipAddress = @ShipAddress");
                         }
                         if (!string.IsNullOrEmpty(shipCity))
                         {
                             columnAssignmentsOrders.Add("ShipCity = @ShipCity");
                         }
                         if (!string.IsNullOrEmpty(shipRegion))
                         {
                             columnAssignmentsOrders.Add("ShipRegion = @ShipRegion");
                         }
                         if (!string.IsNullOrEmpty(shipPostalCode))
                         {
                             columnAssignmentsOrders.Add("ShipPostalCode = @ShipPostalCode");
                         }
                         if (!string.IsNullOrEmpty(shipCountry))
                         {
                             columnAssignmentsOrders.Add("ShipCountry = @ShipCountry");
                         }

                         queryOrders += string.Join(", ", columnAssignmentsOrders);
                         queryOrders += " WHERE OrderID = @OrderID";

                         connection.Execute(queryOrders, new
                         {
                             OrderID = OrdersID,
                             CustomerID = customerID,
                             EmployeeID = employeeID,
                             OrderDate = orderDate,
                             RequiredDate = requiredDate,
                             ShippedDate = shippedDate,
                             ShipVia = shipVia,
                             Freight = (!freight.IsNull) ? (decimal)freight.Value : 0.0m,
                             ShipName = shipName,
                             ShipAddress = shipAddress,
                             ShipCity = shipCity,
                             ShipRegion = shipRegion,
                             ShipPostalCode = shipPostalCode,
                             ShipCountry = shipCountry
                         }, transaction: transaction);


                         foreach (DataRow row in orderDetailsTemp.Rows)
                         {
                             var queryOrderDetails = @"
                         UPDATE [Order Details]
                         SET UnitPrice = @UnitPrice, 
                             Quantity = @Quantity, 
                             Discount = @Discount 
                         WHERE OrderID = @OrderID AND ProductID = @ProductID";

                             connection.Execute(queryOrderDetails, new
                             {
                                 OrderID = OrdersID,
                                 ProductID = row["ProductID"],
                                 UnitPrice = row["UnitPrice"],
                                 Quantity = row["Quantity"],
                                 Discount = row["Discount"]
                             }, transaction: transaction);
                         }


                         transaction.Commit();
                     }
                     catch (Exception)
                     {

                         transaction.Rollback();
                         throw; 
                     }
                 }
             }
         }
    }
}