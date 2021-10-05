using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController
{
    class Drink : Product 
    {
        
        public string TypeOfdrink { get; set; }

        public Drink(string category, int price, string typeOfDrink) : base(category, price)
        {
            TypeOfdrink = typeOfDrink;
        }

        public override string Info()
        {
            
        }
    }
}
