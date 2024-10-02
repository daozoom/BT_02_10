using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_02_10
{
    // Lớp trừu tượng Product
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        // Constructor
        public Product(string name, decimal price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        // Phương thức trừu tượng
        public abstract void DisplayProductInfo();
        public abstract void ApplyDiscount(decimal percentage);
    }
}
