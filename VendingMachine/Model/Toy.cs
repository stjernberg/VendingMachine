using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController

{
    public class Toy : Product
    {
        public int RecommendedAge { get; set; }

        public Toy(string name, int price, int recommendedAge) : base(name, price)
        {
            RecommendedAge = recommendedAge;
        }

        public override string Info()
        {
            return base.Info() + $"\nRecommended age: {RecommendedAge}";
        }
    }
}
