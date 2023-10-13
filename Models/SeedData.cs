using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcSoaps.Models;
using SoapApplication.Data;
using System;
using System.Linq;

namespace MvcSoap.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SoapApplicationContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SoapApplicationContext>>()))
            {
                if (context.Soap.Any())
                {
                    return;   // DB has been seeded
                }

                context.Soap.AddRange(
                    new MvcSoaps.Models.Soap
                    {
                        Name = "Dove",
                        Ingridients = "Seasme",
                        Fragrance = "Musk",
                        SkinType = "Dry",
                        Price = 45
                    },

                    new Soap
                    {
                        Name = "Doves",
                        Ingridients = "Seasme",
                        Fragrance = "Musk",
                        SkinType = "Dry",
                        Price = 45
                    },

                    new Soap
                    {
                        Name = "Dove",
                        Ingridients = "Seasme",
                        Fragrance = "Musk",
                        SkinType = "Dry",
                        Price = 45
                    },

                    new Soap
                    {
                        Name = "Dove",
                        Ingridients = "Seasme",
                        Fragrance = "Musk",
                        SkinType = "Dry",
                        Price = 45
                    }
                );
                context.SaveChanges();
            }
        }
    }
}