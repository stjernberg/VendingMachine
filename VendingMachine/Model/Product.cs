using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController

{
    public abstract class Product
    {
        private readonly int id;
        public string Name { get; set; }
        public int Price { get; set; }
        
        public Product()
        {

        }
        public int Id
        {
            get
            {
                return id;
            }
        }
        public Product(int id, string name, int price)
        {
            this.id = id;
            Name = name;
            Price = price;
           
        }

        public virtual string Examine()
        {
            return $"\n---{GetType().Name.ToUpper()} ---\nId: {Id} \nName: {Name}\nPrice: {Price}";
        }
    }
}
