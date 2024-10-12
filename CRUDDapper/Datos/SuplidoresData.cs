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
    internal class SuplidoresData : ISuplidoresData
    {
        private readonly ISqlConnectionFactory _sqlconnectionFactory;
        public SuplidoresData(ISqlConnectionFactory sqlConnectionFactory)
        {
            this._sqlconnectionFactory = sqlConnectionFactory;
        }
        public DataTable LoadSuplidores()
        {


            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {


                var query = "Select *  from Suppliers";
                var adapter = new SqlDataAdapter(query, (SqlConnection)connection);

                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
        public void InsertarProveedorCompleto(string nombreEmpresa, string contacto, string tituloContacto, string direccion, string ciudad, string region, string codigoPostal, string pais, string telefono, string fax, string paginaWeb)
        {


            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();


                var query = @"
                   INSERT INTO Suppliers (CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage)
                    VALUES (@NombreEmpresa, @Contacto, @TituloContacto, @Direccion, @Ciudad, @Region, @CodigoPostal, @Pais, @Telefono, @Fax, @PaginaWeb)";

                connection.Execute(query, new
                {
                    NombreEmpresa = nombreEmpresa,
                    Contacto = contacto,
                    TituloContacto = tituloContacto,
                    Direccion = direccion,
                    Ciudad = ciudad,
                    Region = region,
                    CodigoPostal = codigoPostal,
                    Pais = pais,
                    Telefono = telefono,
                    Fax = fax,
                    PaginaWeb = paginaWeb
                });
                MessageBox.Show("Registro de proveedor insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void EliminarProveedor(int supplierId)
        {
            ;

            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = "DELETE FROM Suppliers WHERE SupplierID = @SupplierID";

                int rowsAffected = connection.Execute(query, new { SupplierID = supplierId });

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Proveedor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró el proveedor con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void ModificarProveedorCompleto(int supplierId, string nombreEmpresa, string contacto, string tituloContacto, string direccion, string ciudad, string region, string codigoPostal, string pais, string telefono, string fax, string paginaWeb)
        {

            using (var connection = _sqlconnectionFactory.GetDbConnection())
            {
                connection.Open();

                var query = @"
            UPDATE Suppliers 
            SET CompanyName = @NombreEmpresa, 
                ContactName = @Contacto, 
                ContactTitle = @TituloContacto, 
                Address = @Direccion, 
                City = @Ciudad, 
                Region = @Region, 
                PostalCode = @CodigoPostal, 
                Country = @Pais, 
                Phone = @Telefono, 
                Fax = @Fax, 
                HomePage = @PaginaWeb 
            WHERE SupplierID = @SupplierID";

                var parameters = new
                {
                    SupplierID = supplierId,
                    NombreEmpresa = nombreEmpresa,
                    Contacto = contacto,
                    TituloContacto = tituloContacto,
                    Direccion = direccion,
                    Ciudad = ciudad,
                    Region = region,
                    CodigoPostal = codigoPostal,
                    Pais = pais,
                    Telefono = telefono,
                    Fax = fax,
                    PaginaWeb = paginaWeb
                };

                int rowsAffected = connection.Execute(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Proveedor modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró el proveedor con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
