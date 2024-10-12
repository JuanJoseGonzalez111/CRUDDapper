using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace CRUDDapper.Datos
{
    class EmpleadoData : IEmpleadoData
    {
        private readonly ISqlConnectionFactory _sqlconnectionFactory;
        public EmpleadoData(ISqlConnectionFactory sqlConnectionFactory)
        {
            this._sqlconnectionFactory = sqlConnectionFactory;


        }
        public DataTable LoadEmpleado()
        {


            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {


                var query = "SELECT a.LastName, a.EmployeeID, a.FirstName,a.TitleOfCourtesy,a.BirthDate,a.HireDate,a.Address,a.City,a.Region" +
                    ",a.PostalCode,a.Country,a.HomePhone\r\n,a.Extension,a.Photo,a.Notes, CONCAT(e.FirstName, ' ', e.LastName) " +
                    "AS ReportsToFullName\r\nFROM Employees a\r\nINNER JOIN Employees e ON a.ReportsTo = e.EmployeeID;";
                var adapter = new SqlDataAdapter(query, (SqlConnection)connection);

                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }

        }
      public DataTable LoadEmpleadoa(int Id)
{
    using (var connection = _sqlconnectionFactory.GetDbConnection())
    {
        var query = @"SELECT a.TerritoryID
                      FROM EmployeeTerritories a
                      JOIN Territories b ON a.TerritoryID = b.TerritoryID
                      WHERE a.EmployeeID = @EmployeeID";
        using (var command = new SqlCommand(query, (SqlConnection)connection))
        {
            command.Parameters.AddWithValue("@EmployeeID", Id);

            var adapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
    }
}

        public void InsertEmployee(string lastName, string firstName, string title, string titleOfCourtesy, DateTime birthDate, DateTime hireDate, string address, string city, string region, string postalCode, string country, string homePhone, string extension, byte[] photo, string notes)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = @"
            INSERT INTO Employees (LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Notes)
            VALUES (@LastName, @FirstName, @Title, @TitleOfCourtesy, @BirthDate, @HireDate, @Address, @City, @Region, @PostalCode, @Country, @HomePhone, @Extension, @Photo, @Notes)";

                connection.Execute(query, new
                {
                    LastName = lastName,
                    FirstName = firstName,
                    Title = title,
                    TitleOfCourtesy = titleOfCourtesy,
                    BirthDate = birthDate,
                    HireDate = hireDate,
                    Address = address,
                    City = city,
                    Region = region,
                    PostalCode = postalCode,
                    Country = country,
                    HomePhone = homePhone,
                    Extension = extension,
                    Photo = photo,
                    Notes = notes,
                });
            }
        }


        public void DeleteEmployee(int employeeId)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";
                connection.Execute(query, new { EmployeeID = employeeId });
            }
        }
       
        public void InsertarEmpleadoYTerritorios(string lastName, string firstName, string title, string titleOfCourtesy,
                DateTime birthDate, DateTime hireDate, string address, string city, string region, string postalCode, string country,
                string homePhone, string extension, byte[] photo, string notes, int reportsTo, DataTable territories)
                    {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Execute("Empleadoyteritorio", new
                {
                    LastName = lastName,
                    FirstName = firstName,
                    Title = title,
                    TitleOfCourtesy = titleOfCourtesy,
                    BirthDate = birthDate,
                    HireDate = hireDate,
                    Address = address,
                    City = city,
                    Region = region,
                    PostalCode = postalCode,
                    Country = country,
                    HomePhone = homePhone,
                    Extension = extension,
                    Photo = photo,
                    Notes = notes,
                    ReportsTo = reportsTo,
                    Territories = territories.AsTableValuedParameter("TerritoryList")
                }, commandType: CommandType.StoredProcedure);
            }
        }
        public class Empleado
        {
            internal int EmployeeID;

            public string FullName { get; set; }
            public int EmpleoyeeID { get; set; }
        }

        public void cargarcombo(ComboBox comboBox)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = "SELECT  a.EmployeeID,  e.LastName + ' '+ e.FirstName As FullName FROM Employees a INNER JOIN Employees e ON a.ReportsTo = e.EmployeeID";
                var empleados = connection.Query<Empleado>(query).ToList();

                comboBox.DisplayMember = "FullName"; 
                comboBox.ValueMember = "EmployeeID";     
                comboBox.DataSource = empleados;

                connection.Close();
            }
        }

        public class Territorio
        {
            public string TerritoryID { get; set; }
            public string TerritoryDescription { get; set; }
        }

        public void cargarcomboTe(ComboBox comboBox)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = "Select  TerritoryID,TerritoryDescription from Territories";
                var territorios= connection.Query<Territorio>(query).ToList();

                comboBox.DisplayMember = "TerritoryDescription";
                comboBox.ValueMember = "TerritoryID"; 
                comboBox.DataSource = territorios;

                connection.Close();
            }
        }



        
        public void UpdateEmpleadoTerritorio(int employeeID, string lastName, string firstName, string title, string titleOfCourtesy,
    DateTime birthDate, DateTime hireDate, string address, string city, string region, string postalCode, string country,
    string homePhone, string extension, byte[] photo, string notes, int reportsTo, DataTable territories)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var queryEmpleado = @"
                    UPDATE Employees
                    SET ";

                        var columnAssignmentsEmpleado = new List<string>();

                        if (!string.IsNullOrEmpty(lastName))
                        {
                            columnAssignmentsEmpleado.Add("LastName = @LastName");
                        }
                        if (!string.IsNullOrEmpty(firstName))
                        {
                            columnAssignmentsEmpleado.Add("FirstName = @FirstName");
                        }
                        if (!string.IsNullOrEmpty(title))
                        {
                            columnAssignmentsEmpleado.Add("Title = @Title");
                        }
                        if (!string.IsNullOrEmpty(titleOfCourtesy))
                        {
                            columnAssignmentsEmpleado.Add("TitleOfCourtesy = @TitleOfCourtesy");
                        }
                        if (birthDate != DateTime.MinValue)
                        {
                            columnAssignmentsEmpleado.Add("BirthDate = @BirthDate");
                        }
                        if (hireDate != DateTime.MinValue)
                        {
                            columnAssignmentsEmpleado.Add("HireDate = @HireDate");
                        }
                        if (!string.IsNullOrEmpty(address))
                        {
                            columnAssignmentsEmpleado.Add("Address = @Address");
                        }
                        if (!string.IsNullOrEmpty(city))
                        {
                            columnAssignmentsEmpleado.Add("City = @City");
                        }
                        if (!string.IsNullOrEmpty(region))
                        {
                            columnAssignmentsEmpleado.Add("Region = @Region");
                        }
                        if (!string.IsNullOrEmpty(postalCode))
                        {
                            columnAssignmentsEmpleado.Add("PostalCode = @PostalCode");
                        }
                        if (!string.IsNullOrEmpty(country))
                        {
                            columnAssignmentsEmpleado.Add("Country = @Country");
                        }
                        if (!string.IsNullOrEmpty(homePhone))
                        {
                            columnAssignmentsEmpleado.Add("HomePhone = @HomePhone");
                        }
                        if (!string.IsNullOrEmpty(extension))
                        {
                            columnAssignmentsEmpleado.Add("Extension = @Extension");
                        }
                        if (photo != null && photo.Length > 0)
                        {
                            columnAssignmentsEmpleado.Add("Photo = @Photo");
                        }
                        if (!string.IsNullOrEmpty(notes))
                        {
                            columnAssignmentsEmpleado.Add("Notes = @Notes");
                        }
                        if (reportsTo != 0)
                        {
                            columnAssignmentsEmpleado.Add("ReportsTo = @ReportsTo");
                        }
                      
                        queryEmpleado += string.Join(", ", columnAssignmentsEmpleado);
                        queryEmpleado += " WHERE EmployeeID = @EmployeeID";

                        connection.Execute(queryEmpleado, new
                        {
                            EmployeeID = employeeID,
                            LastName = lastName,
                            FirstName = firstName,
                            TitleOfCourtesy = titleOfCourtesy,
                            BirthDate = birthDate,
                            HireDate = hireDate,
                            Address = address,
                            City = city,
                            Region = region,
                            PostalCode = postalCode,
                            Country = country,
                            HomePhone = homePhone,
                            Extension = extension,
                            Photo = photo,
                            Notes = notes,
                            ReportsTo = reportsTo
                             
                        }, transaction: transaction);

                        var queryDeleteTerritories = @"
                                DELETE FROM EmployeeTerritories
                                WHERE EmployeeID = @EmployeeID";

                                                    MessageBox.Show("Empleado ID: " + employeeID);

                        connection.Execute(queryDeleteTerritories, new { EmployeeID = employeeID }, transaction: transaction);

                        foreach (DataRow row in territories.Rows)
                        {
                            var territoryID = row["TerritoryID"].ToString(); 

                            MessageBox.Show("Empleado ID: " + territoryID);

                                                var queryInsertTerritory = @"
                            INSERT INTO EmployeeTerritories (EmployeeID, TerritoryID)
                            VALUES (@EmployeeID, @TerritoryID)";

                            connection.Execute(queryInsertTerritory, new
                            {
                                EmployeeID = employeeID,
                                TerritoryID = territoryID,
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
        public void UpdateEmpleadoTerritorio(int employeeID)
        {
            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Eliminar las asignaciones de territorios asociadas al empleado
                        var queryDeleteEmployeeTerritories = @"
                DELETE FROM EmployeeTerritories
                WHERE EmployeeID = @EmployeeID";

                        connection.Execute(queryDeleteEmployeeTerritories, new { EmployeeID = employeeID }, transaction: transaction);

                        // Eliminar los detalles de la orden asociados a la orden especificada
                        var queryDeleteOrderDetails = @"
                DELETE FROM [Order Details]
                WHERE OrderID IN (
                    SELECT OrderID FROM Orders WHERE EmployeeID = @EmployeeID
                )";

                        connection.Execute(queryDeleteOrderDetails, new { EmployeeID = employeeID }, transaction: transaction);

                        // Eliminar la orden asociada al empleado
                        var queryDeleteOrders = @"
                DELETE FROM Orders
                WHERE EmployeeID = @EmployeeID";

                        connection.Execute(queryDeleteOrders, new { EmployeeID = employeeID }, transaction: transaction);

                        // Finalmente, eliminar al empleado
                        var queryDeleteEmployee = @"
                DELETE FROM Employees
                WHERE EmployeeID = @EmployeeID";

                        connection.Execute(queryDeleteEmployee, new { EmployeeID = employeeID }, transaction: transaction);

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

