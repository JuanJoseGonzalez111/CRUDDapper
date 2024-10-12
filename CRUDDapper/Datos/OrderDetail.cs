namespace CRUDDapper.Datos
{
    public class OrderDetail
    {
        public int ProductId { get; set; }
     
        public int Quantity { get; set; }
        public decimal unitPrice { get; set; }
        public decimal Discount { get; set; }

        public int OrderID { get; set; }
    }
}