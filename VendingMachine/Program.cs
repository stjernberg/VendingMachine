using System;
using System.Collections.Generic;

namespace VendingMachineController
{
    class Program
    {
       

        static void Main(string[] args)
        {

            VendingMachine vendingMachine = new VendingMachine();
           
           vendingMachine.productList.Add(new Drink("Coke", 15, "Soda"));
           vendingMachine.productList.Add(new Food("Tacos", 47, "Dinner"));
           vendingMachine.productList.Add(new Toy(" Lego", 119, 6));

            foreach (Product product in vendingMachine.productList)
            {
                Console.WriteLine(product.Name);
            }

            foreach (Product product in vendingMachine.productList)
            {
                Console.WriteLine(product.Info());
            }
        }
    }
}
