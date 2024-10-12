using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDapper.Datos
{
    internal class ShipperData : IShipperData
    {
        private readonly ISqlConnectionFactory _connectionFactory;
        public ShipperData(ISqlConnectionFactory sqlConnectionFactory)
        {
            _connectionFactory = sqlConnectionFactory;

        }
        public DataTable LoadCategories()
        {


            using (var connection = _connectionFactory.GetDbConnection())
            {


                var query = "Select * from Shippers";
                var adapter = new SqlDataAdapter(query, (SqlConnection)connection);

                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
        public void Create(string companyName, string phone)
        {
            using (var connection = _connectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = @"
                INSERT INTO Shippers (CompanyName, Phone)
                VALUES (@CompanyName, @Phone)";

                connection.Execute(query, new { CompanyName = companyName, Phone = phone });
            }
        }
        //public void Update(int shipperId, string companyName, string phone)
        //{
        //    using (var connection = _connectionFactory.GetDbConnection())
        //    {
        //        connection.Open();

        //        var query = @"
        //        UPDATE Shippers 
        //        SET CompanyName = @CompanyName, Phone = @Phone
        //        WHERE ShipperID = @ShipperID";

        //        connection.Execute(query, new { CompanyName = companyName, Phone = phone, ShipperID = shipperId });
        //    }

        //}
        public void Update(int shipperId, string companyName, string phone)
        {
            using (var connection = _connectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = @"
                    UPDATE Shippers 
                    SET ";

                var columnAssignments = new List<string>();

                if (!string.IsNullOrEmpty(companyName))
                {
                    columnAssignments.Add("CompanyName = @CompanyName");
                }
                if (!string.IsNullOrEmpty(phone))
                {
                    columnAssignments.Add("Phone = @Phone");
                }

                query += string.Join(", ", columnAssignments);

                query += " WHERE ShipperID = @ShipperID";

                connection.Execute(query, new { CompanyName = companyName, Phone = phone, ShipperID = shipperId });
            }
        }

        public void Delete(int shipperId)
        {
            using (var connection = _connectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = "DELETE FROM Shippers WHERE ShipperID = @ShipperID";

                connection.Execute(query, new { ShipperID = shipperId });
            }
        }
    }
}
