using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController
{
    public class Food : Product
    {
        
        public string TypeOfFood { get; set; }

        public Food(int id, string name, int price, string typeOfFood) : base(id, name, price)
        {
            TypeOfFood = typeOfFood;
        }

        public override string Examine()
        {
            return base.Examine() + $"\nType of food: {TypeOfFood}\n";
        }
    }
}
