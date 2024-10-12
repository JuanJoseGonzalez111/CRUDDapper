using System.Data;

namespace CRUDDapper.Datos
{
    public interface IShipperData
    {
        void Create(string companyName, string phone);
        void Delete(int shipperId);
        DataTable LoadCategories();
        void Update(int shipperId, string companyName, string phone);
    }
}