using System.Data;

namespace CRUDDapper.Datos
{
    public  interface ITerritorio
    {
        void Delete(string territorioId);
        DataTable LoadTerritories();
        void Update(string territorioId, string TerritorioDescripcion, int RegionId);

        public void cargarcomboProducto(ComboBox comboBox);
        public void Insert(string territorioId, string TerritorioDescripcion, int RegionId);
    }
}