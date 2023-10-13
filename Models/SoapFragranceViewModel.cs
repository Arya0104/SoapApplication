using Microsoft.AspNetCore.Mvc.Rendering;
using MvcSoaps.Models;
using System.Collections.Generic;

namespace SoapApplication.Models
{
    public class SoapFragranceViewModel
    {
        public List<Soap>? Soaps { get; set; }
        public SelectList? Fragrances { get; set; }
        public string? SoapFragrance { get; set; }
        public string? SearchString { get; set; }
    }
}
