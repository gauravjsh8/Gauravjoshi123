using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Customer
    {
        [Required]
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Address { get; set; }

        public double PhoneNumber { get; set; } 
        public string Email { get; set; }    
    }
}
