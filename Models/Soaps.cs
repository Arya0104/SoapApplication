using System.ComponentModel.DataAnnotations;

namespace MvcSoaps.Models
{
    public class Soap
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Ingridients { get; set; }
        public string? Fragrance { get; set; }
        public decimal Price { get; set; }

        public string? SkinType { get; set; }
    }
}