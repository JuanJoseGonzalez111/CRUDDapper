using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDapper.Datos
{
    public class Region : IRegion
    {
        private readonly ISqlConnectionFactory _connectionFactory;
        public Region(ISqlConnectionFactory sqlConnectionFactory)
        {
            this._connectionFactory = sqlConnectionFactory;
        }
        public DataTable loadReion()
        {


            using (var connection = _connectionFactory.GetDbConnection())
            {


                var query = "Select a.RegionID , a.RegionDescription, b.TerritoryID,b.TerritoryDescription from Region a\r\ninner join Territories b on a.RegionID = b.RegionID";
                var adapter = new SqlDataAdapter(query, (SqlConnection)connection);

                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
        public class Producto
        {
            public string TerritoryDescription { get; set; }
            public string TerritoryID { get; set; }
        }

        public void cargarcomboTerit(ComboBox comboBox)
        {
            using (var connection = _connectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = "Select TerritoryID, TerritoryDescription  from Territories";
                var producto = connection.Query<Producto>(query).ToList();

                comboBox.DisplayMember = "TerritoryDescription";
                comboBox.ValueMember = "TerritoryID";
                comboBox.DataSource = producto;

                connection.Close();
            }
        }
        public void InsertarDetalleCompleto(string RerionDecription, DataTable TerritoryDetails)
        {
            using (var connection = _connectionFactory.GetDbConnection())
            {
                connection.Execute("insertRegionTerritory", new
                {
                    RegionDescription = RerionDecription,
                    TerritoryDetails = TerritoryDetails.AsTableValuedParameter("TerritoryDetailsType ")
                }, commandType: CommandType.StoredProcedure);


            }
        }
        public DataTable loaterritory(int id)
        {


            using (var connection = _connectionFactory.GetDbConnection())
            {


                var query = "Select  TerritoryID ,TerritoryDescription from Territories where RegionID = @Redion";

                using (var command = new SqlCommand(query, (SqlConnection)connection))
                {
                    command.Parameters.AddWithValue("@Redion", id);

                    var adapter = new SqlDataAdapter(command);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }

            }
        }
        public class region
        {
            public string RegionID { get; set; }
            public string RegionDescription { get; set; }
        }

        public void cargarcomboProducto(ComboBox comboBox)
        {
            using (var connection = _connectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = "Select RegionID, RegionDescription from Region";
                var producto = connection.Query<region>(query).ToList();

                comboBox.DisplayMember = "RegionDescription"; // Mostrar el nombre de la compañía del cliente
                comboBox.ValueMember = "RegionID";     // El valor subyacente es el CustomerID
                comboBox.DataSource = producto;

                connection.Close();
            }
        }

        public void UpdateDetalleCompleto(string Description, int ID, DataTable orderDetailsTemp)
{
    using (var connection = _connectionFactory.GetDbConnection())
    {
        connection.Open();

        using (var transaction = connection.BeginTransaction())
        {
            try
            {
                var queryOrders = @"
                    UPDATE Orders 
                    SET RegionDescription = @RegionDescription
                    WHERE RegionID = @RegionID";

                connection.Execute(queryOrders, new
                {
                    RegionDescription = Description,
                    RegionID = ID
                }, transaction: transaction);

                foreach (DataRow row in orderDetailsTemp.Rows)
                {
                    var queryOrderDetails = @"
                        UPDATE [Order Details]
                        SET TerritoryDescription = @TerritoryDescription
                        WHERE RegionID = @RegionID AND TerritoryID = @TerritoryID";

                    connection.Execute(queryOrderDetails, new
                    {
                        RegionID = ID,
                        TerritoryID = row["TerritoryID"],
                        TerritoryDescription = row["TerritoryDescription"]
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