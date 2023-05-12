namespace E_Commerce.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product Product { get; set; }
    }
}
