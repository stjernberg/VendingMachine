using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController

{
    public class Toy : Product
    {
        public int RecommendedAge { get; set; }

        public Toy(string category, int price, string category, int priceint recommendedAge) : base(category, price)
        {
            RecommendedAge = recommendedAge;
        }

        public override string Info()
        {
            
        }
    }
}
