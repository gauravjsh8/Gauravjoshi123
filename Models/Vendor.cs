namespace E_Commerce.Models
{
    public class Vendor
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public string name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
