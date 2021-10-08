using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController
{
    public class Drink : Product 
    {
        private object p;
        private string v1;
        private int v2;
        private string v3;

        public string TypeOfDrink { get; set; }

        public Drink()
        {

        }
        public Drink(int id, string name, int price, string typeOfDrink) : base(id, name, price)
        {
            TypeOfDrink = typeOfDrink;
        }

        public Drink(object p, string v1, int v2, string v3)
        {
            this.p = p;
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public override string Examine()
        {
            return base.Examine() + $"\nType of drink: {TypeOfDrink}\n";
        }

        public override string Use()
        {
            return ($"Here's your {Name}, enjoy your drink!");
        }
    }
}
