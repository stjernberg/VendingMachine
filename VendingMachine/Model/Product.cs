using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController

{
    public abstract class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product()
        {

        }
        
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public virtual string Info()
        {
            return $"--- {GetType().Name} Info ---\nName: {Name}\nPrice: {Price}";
        }
    }
}
