namespace E_Commerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public string Detail { get; set; }
        //many to one
        public string CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
