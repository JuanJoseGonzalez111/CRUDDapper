using System.Data;

namespace CRUDDapper.Datos
{
    public interface IEmpleadoData
    {
        DataTable LoadEmpleado();
        public DataTable LoadEmpleadoa(int Id);
        public void InsertEmployee(string lastName, string firstName, string title, string titleOfCourtesy, DateTime birthDate, DateTime hireDate, string address, string city, string region, string postalCode, string country, string homePhone, string extension, byte[] photo, string notes);
        public void DeleteEmployee(int employeeId);
   
        public void UpdateEmpleadoTerritorio(int employeeID, string lastName, string firstName, string title, string titleOfCourtesy,
   DateTime birthDate, DateTime hireDate, string address, string city, string region, string postalCode, string country,
   string homePhone, string extension, byte[] photo, string notes, int reportsTo, DataTable territories);
        public void InsertarEmpleadoYTerritorios(string lastName, string firstName, string title, string titleOfCourtesy,
    DateTime birthDate, DateTime hireDate, string address, string city, string region, string postalCode, string country,
    string homePhone, string extension, byte[] photo, string notes, int reportsTo, DataTable territories);
        public void cargarcombo(ComboBox comboBox);
        public void UpdateEmpleadoTerritorio(int employeeID);
        public void cargarcomboTe(ComboBox comboBox);

    }
}