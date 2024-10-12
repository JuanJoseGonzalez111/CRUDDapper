using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CRUDDapper.Datos.EmpleadoData;

namespace CRUDDapper.Datos
{
    class Territorio : ITerritorio
    {
        private readonly ISqlConnectionFactory _sqlconnectionFactory;
        public Territorio(ISqlConnectionFactory sqlConnectionFactory)
        {
            _sqlconnectionFactory = sqlConnectionFactory;
        }
        public void Update(string territorioId, string TerritorioDescripcion, int RegionId)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = "UPDATE Territories SET ";

                var columnAssignments = new List<string>();

                if (!string.IsNullOrEmpty(territorioId))
                {
                    columnAssignments.Add("TerritoryID = @territory");
                }
                if (!string.IsNullOrEmpty(TerritorioDescripcion))
                {
                    columnAssignments.Add("TerritoryDescription = @territorioDescripcion");
                }
                if (RegionId != 0)
                {
                    columnAssignments.Add("RegionID = @region");
                }

                query += string.Join(", ", columnAssignments);

                query += " WHERE TerritoryID =@territory ";

                connection.Execute(query, new { territory = territorioId, territorioDescripcion = TerritorioDescripcion, region = RegionId });
            }
        }
        public void Insert(string territorioId, string TerritorioDescripcion, int RegionId)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = @"
            INSERT INTO Territories (TerritoryID, TerritoryDescription, RegionID)
            VALUES (@territoryId, @territorioDescripcion, @regionId)";

                connection.Execute(query, new { territoryId =territorioId, territorioDescripcion = TerritorioDescripcion, regionId = RegionId });
            }
        }

     
        public class region
        {
            public string RegionID { get; set; }
            public string RegionDescription { get; set; }
        }

        public void cargarcomboProducto(ComboBox comboBox)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
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
        public DataTable LoadTerritories()
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = "SELECT * FROM Territories";

                var adapter = new SqlDataAdapter(query, (SqlConnection)connection);

                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public void Delete(string territorioId)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var deleteEmployeeTerritoriesQuery = @"
                    DELETE FROM EmployeeTerritories
                    WHERE TerritoryID = @territorioId";

                        connection.Execute(deleteEmployeeTerritoriesQuery, new { territorioId }, transaction);

                        
                        var deleteTerritoryQuery = @"
                    DELETE FROM Territories
                    WHERE TerritoryID = @territorioId";

                        connection.Execute(deleteTerritoryQuery, new { territorioId }, transaction);

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
