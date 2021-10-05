using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController

{
    public abstract class Product
    {
        public string Category { get; set; }
        public int Price { get; set; }

        public Product(string category, int price)
        {
            Category = category;
            Price = price;
        }

        public abstract string Info();
    }
}
