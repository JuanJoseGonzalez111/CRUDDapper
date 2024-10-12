using System.Data;

namespace CRUDDapper.Datos
{
    public  interface IClientesData
    {
        DataTable LoadCategories();
        public void SaveCustomer(string customerId, string companyName, string contactName, string contactTitle, string address, string city, string region, string postalCode, string country, string phone, string fax);

        void UpdateCustomer(string customerId, string companyName, string contactName, string contactTitle, string address, string city, string region, string postalCode, string country, string phone, string fax);
        public void Deletecustomer(string customerId);


    }
}