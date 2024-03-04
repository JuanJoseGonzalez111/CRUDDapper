using System.Data.Common;

namespace CRUDDapper.Datos
{
    public interface ISqlConnectionFactory
    {
        DbConnection GetDbConnection();
    }
}