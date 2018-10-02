using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SE.WebServices.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public decimal Amount => Qty * Price;
    }
}
