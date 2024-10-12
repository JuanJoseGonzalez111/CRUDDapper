using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDapper.Datos
{
     class ClientesData : IClientesData
    {

        private readonly ISqlConnectionFactory _sqlconnectionFactory;
        public ClientesData(ISqlConnectionFactory sqlConnectionFactory)
        {
            this._sqlconnectionFactory = sqlConnectionFactory;
        }
        public DataTable LoadCategories()
        {


            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {


                var query = "select *  from Customers";
                var adapter = new SqlDataAdapter(query, (SqlConnection)connection);

                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
        public void SaveCustomer(string customerId, string companyName, string contactName, string contactTitle, string address, string city, string region, string postalCode, string country, string phone, string fax)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = @"INSERT INTO Customers (CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax) 
                      VALUES (@CustomerId, @CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax)";

                connection.Execute(query, new { CustomerId = customerId, CompanyName = companyName, ContactName = contactName, ContactTitle = contactTitle, Address = address, City = city, Region = region, PostalCode = postalCode, Country = country, Phone = phone, Fax = fax });
            }
        }
        public void UpdateCustomer(string customerId, string companyName, string contactName, string contactTitle, string address, string city, string region, string postalCode, string country, string phone, string fax)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = @"UPDATE Customers 
                      SET ";

                var columnAssignments = new List<string>();

                if (!string.IsNullOrEmpty(companyName))
                {
                    columnAssignments.Add("CompanyName = @CompanyName");
                }
                if (!string.IsNullOrEmpty(contactName))
                {
                    columnAssignments.Add("ContactName = @ContactName");
                }
                if (!string.IsNullOrEmpty(contactTitle))
                {
                    columnAssignments.Add("ContactTitle = @ContactTitle");
                }
                if (!string.IsNullOrEmpty(address))
                {
                    columnAssignments.Add("Address = @Address");
                }
                if (!string.IsNullOrEmpty(city))
                {
                    columnAssignments.Add("City = @City");
                }
                if (!string.IsNullOrEmpty(region))
                {
                    columnAssignments.Add("Region = @Region");
                }
                if (!string.IsNullOrEmpty(postalCode))
                {
                    columnAssignments.Add("PostalCode = @PostalCode");
                }
                if (!string.IsNullOrEmpty(country))
                {
                    columnAssignments.Add("Country = @Country");
                }
                if (!string.IsNullOrEmpty(phone))
                {
                    columnAssignments.Add("Phone = @Phone");
                }
                if (!string.IsNullOrEmpty(fax))
                {
                    columnAssignments.Add("Fax = @Fax");
                }

                query += string.Join(", ", columnAssignments);
                query += " WHERE CustomerID = @CustomerId";

                connection.Execute(query, new
                {
                    CustomerId = customerId,
                    CompanyName = companyName,
                    ContactName = contactName,
                    ContactTitle = contactTitle,
                    Address = address,
                    City = city,
                    Region = region,
                    PostalCode = postalCode,
                    Country = country,
                    Phone = phone,
                    Fax = fax
                });
            }
        }
        public void Deletecustomer(string  customerId)
        {

            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
                connection.Execute(query, new { CustomerID = customerId });
            }

        }






    }
}
