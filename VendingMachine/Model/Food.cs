using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController
{
    class Food : Product
    {
        
        public string TypeOfFood { get; set; }

        public Food(string category, int price, string typeOfFood) : base(category, price)
        {
            TypeOfFood = typeOfFood;
        }

        public override string Info()
        {
            
        }
    }
}
