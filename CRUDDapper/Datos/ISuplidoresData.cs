using System.Data;

namespace CRUDDapper.Datos
{
    public  interface ISuplidoresData
    {
        DataTable LoadSuplidores();
        public void EliminarProveedor(int supplierId);
        public void InsertarProveedorCompleto(string nombreEmpresa, string contacto, string tituloContacto, string direccion, string ciudad, string region, string codigoPostal, string pais, string telefono, string fax, string paginaWeb);
        public void ModificarProveedorCompleto(int supplierId, string nombreEmpresa, string contacto, string tituloContacto, string direccion, string ciudad, string region, string codigoPostal, string pais, string telefono, string fax, string paginaWeb);




    }
}