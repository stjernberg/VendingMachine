using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController

{
    public class Toy : Product
    {
        public int RecommendedAge { get; set; }

        public Toy(int id, string name, int price, int recommendedAge) : base(id, name, price)
        {
            RecommendedAge = recommendedAge;
        }

        public override string Examine()
        {
            return base.Examine() + $"\nRecommended age: {RecommendedAge}\n";
        }
    }
}
