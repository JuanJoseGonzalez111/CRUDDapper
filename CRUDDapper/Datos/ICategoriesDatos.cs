using System.Data;

namespace CRUDDapper.Datos
{
    public interface ICategoriesDatos
    {
        void DeleteCategory(int categoryId);
        void InsertCategory(string categoryName, string description, byte[] picture);
        DataTable LoadCategories();
        void UpdateCategory(int categoryId, string categoryName, string description, byte[] picture);
    }
}