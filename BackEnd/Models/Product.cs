using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";

        public int Price { get; set; }

        public string Image { get; set; } = "";

        public string Description { get; set; } = "";

        public double Rating { get; set; }

        public int ReviewCount { get; set; }
    }
}