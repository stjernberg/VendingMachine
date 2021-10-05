using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController
{
    class Food : Product
    {
        
        public string TypeOfFood { get; set; }

        public Food(string name, int price, string typeOfFood) : base(name, price)
        {
            TypeOfFood = typeOfFood;
        }

        public override string Examine()
        {
            return base.Examine() + $"\nType of food: {TypeOfFood}";
        }
    }
}
