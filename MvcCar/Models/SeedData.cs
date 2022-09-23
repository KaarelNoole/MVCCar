using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcCar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCar.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCarContext(
                    serviceProvider.GetRequiredService<
                    DbContextOptions<MvcCarContext>>()))
            {
                if (context.Car.Any())
                {
                    return;
                }

                context.Car.AddRange(
                    new Car
                    {
                        Name = "F8 tributo",
                        Company = "Ferrari",
                        Speed = 5,
                        Price = 100000
                    },
                    new Car
                    {
                    Name = "Octavia G-TEC CNG",
                    Company = "Skoda",
                    Speed = 10,
                    Price = 250000
                    },
                    new Car
                    {
                        Name = "VESTA SPORT",
                        Company = "Lada",
                        Speed = 12,
                        Price = 27569.74M
                    },
                    new Car
                    {
                        Name = "lamborghini",
                        Company = "AVENTADOR LP 780-4 ULTIMAE",
                        Speed = 3,
                        Price = 498.258M
                    }
                 );
            }
        }
    }
}
