using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDDapper.Datos
{
     class CategoriesDatos : ICategoriesDatos
    {
        /* private readonly IConfiguration _configuration;
         public CategoriesDatos(IConfiguration configuration) 
         { 
             this._configuration = configuration;
         }
        */
        private readonly ISqlConnectionFactory _sqlconnectionFactory;
        public CategoriesDatos(ISqlConnectionFactory sqlConnectionFactory)
        {
            this._sqlconnectionFactory = sqlConnectionFactory;
        }
        public DataTable LoadCategories()
        {
            // var connectionString = Program.Configuration.GetConnectionString("NorthwindConnectionString");
           // var connectionString = _configuration.GetConnectionString("NorthwindConnectionString");

            //using (var connection = new SqlConnection(connectionString))
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                

                var query = "SELECT CategoryID, CategoryName, Description, Picture FROM Categories";
                var adapter = new SqlDataAdapter(query, (SqlConnection)connection);

                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
        public void InsertCategory(string categoryName, string description, byte[] picture)
        {
          //  var connectionString = Program.Configuration.GetConnectionString("NorthwindConnectionString");
          //  var connectionString = _configuration.GetConnectionString("NorthwindConnectionString");

            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = "INSERT INTO Categories (CategoryName, Description, Picture) VALUES (@CategoryName, @Description, @Picture)";
                connection.Execute(query, new { CategoryName = categoryName, Description = description, Picture = picture });
            }
        }
        public void UpdateCategory(int categoryId, string categoryName, string description, byte[] picture)
        {
            //var connectionString = Program.Configuration.GetConnectionString("NorthwindConnectionString");
            //var connectionString = _configuration.GetConnectionString("NorthwindConnectionString");
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = "UPDATE Categories SET CategoryName = @CategoryName, Description = @Description, Picture = @Picture WHERE CategoryID = @CategoryID";
                connection.Execute(query, new { CategoryID = categoryId, CategoryName = categoryName, Description = description, Picture = picture });
            }
        }
        public void DeleteCategory(int categoryId)
        {
          //  var connectionString = Program.Configuration.GetConnectionString("NorthwindConnectionString");
         //  var connectionString = _configuration.GetConnectionString("NorthwindConnectionString");

            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = "DELETE FROM Categories WHERE CategoryID = @CategoryID";
                connection.Execute(query, new { CategoryID = categoryId });
            }
        }




    }
}
