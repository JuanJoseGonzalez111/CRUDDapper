using System.Data;

namespace CRUDDapper.Datos
{
    public interface IRegion
    {
        DataTable loadReion();
        public void cargarcomboTerit(ComboBox comboBox);
        public void InsertarDetalleCompleto(string RerionDecription, DataTable TerritoryDetails);
        public DataTable loaterritory(int id);
        public void UpdateDetalleCompleto(string Description, int ID, DataTable orderDetailsTemp);

    }   
}