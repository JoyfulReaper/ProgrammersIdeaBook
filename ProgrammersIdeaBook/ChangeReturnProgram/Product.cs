using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeReturnProgram
{
    public class Product
    {
        public decimal Price { get; set; }
        public string Name { get; set; }

        public Product(string name, decimal price)
        {
           Name = name;
           Price = price;
        }
    }
}
