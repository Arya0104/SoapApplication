using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcSoaps.Models
{
    public class Soap
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Ingridients { get; set; }
        public string? Fragrance { get; set; }

        [Column(TypeName = "decimal(18, 2)")]

        public decimal Price { get; set; }

        public string? SkinType { get; set; }
    }
}