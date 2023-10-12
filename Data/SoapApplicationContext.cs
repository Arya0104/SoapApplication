using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcSoaps.Models;

namespace SoapApplication.Data
{
    public class SoapApplicationContext : DbContext
    {
        public SoapApplicationContext (DbContextOptions<SoapApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<MvcSoaps.Models.Soap> Soap { get; set; } 
    }
}
