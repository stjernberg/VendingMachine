using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController
{
    class Drink : Product 
    {
        
        public string TypeOfDrink { get; set; }

        public Drink()
        {

        }
        public Drink(int id, string name, int price, string typeOfDrink) : base(id, name, price)
        {
            TypeOfDrink = typeOfDrink;
        }

        public override string Examine()
        {
            return base.Examine() + $"\nType of drink: {TypeOfDrink}\n";
        }
    }
}
