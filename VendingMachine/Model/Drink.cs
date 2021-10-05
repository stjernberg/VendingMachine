﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController
{
    class Drink : Product 
    {
        
        public string TypeOfDrink { get; set; }

        public Drink(string name, int price, string typeOfDrink) : base(name, price)
        {
            TypeOfDrink = typeOfDrink;
        }

        public override string Info()
        {
            return base.Info() + $"\nType of drink: {TypeOfDrink}";
        }
    }
}
