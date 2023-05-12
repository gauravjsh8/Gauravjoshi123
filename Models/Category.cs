namespace E_Commerce.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        //one to many//
        public List<Product> ProductId { get; set; }
    }
}
