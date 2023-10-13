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
                    return;   //database seeded
                }

                context.Soap.AddRange(
                    new MvcSoaps.Models.Soap
                    {
                        Name = "Dove",
                        Ingridients = "Seasme",
                        Fragrance = "Musk",
                        SkinType = "Dry",
                        Price = 45,
                        Rating = 3
                    },

                    new Soap
                    {
                        Name = "Doves",
                        Ingridients = "Seasme",
                        Fragrance = "Musk",
                        SkinType = "Dry",
                        Price = 45,
                        Rating = 4
                    },

                    new Soap
                    {
                        Name = "Dove",
                        Ingridients = "Seasme",
                        Fragrance = "Musk",
                        SkinType = "Dry",
                        Price = 45,
                        Rating = 2
                    },

                    new Soap
                    {
                        Name = "Dove",
                        Ingridients = "Seasme",
                        Fragrance = "Musk",
                        SkinType = "Dry",
                        Price = 45,
                        Rating = 1

                    }
                );
                context.SaveChanges();
            }
        }
    }
}