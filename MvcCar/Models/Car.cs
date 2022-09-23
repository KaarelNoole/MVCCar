using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCar.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public int Speed { get; set; }
        public decimal Price { get; set; }
    }
}
