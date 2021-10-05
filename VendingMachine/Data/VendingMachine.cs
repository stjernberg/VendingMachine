using System;
using System.Collections.Generic;
using System.Text;


namespace VendingMachineController
{
    public class VendingMachine : IVending
    {
        readonly int[] moneyDenominations = { 1, 5, 10, 20, 50, 100, 500, 1000 };
        public List<Product> productList = new List<Product>();

        public void ListOfProducts()
        {
            VendingMachine vendingMachine = new VendingMachine();

            vendingMachine.productList.Add(new Drink("Coke", 15, "Soda"));
            vendingMachine.productList.Add(new Drink("Fanta", 15, "Soda"));
            vendingMachine.productList.Add(new Drink("Heineken", 15,  "Beer"));
            vendingMachine.productList.Add(new Food("Tacos", 47, "Dinner"));
            vendingMachine.productList.Add(new Food("Pizza", 47, "Dinner"));
            vendingMachine.productList.Add(new Food("Chipss", 47, "Snacks"));
            vendingMachine.productList.Add(new Toy("Lego", 119, 6));
            vendingMachine.productList.Add(new Toy("Ball", 39, 4));
            vendingMachine.productList.Add(new Toy("puzzle", 62, 3));

            foreach (Product product in vendingMachine.productList)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Examine());
            }



           
        }

        //public Dictionary<int, int> EndTransaction()
        //{

        //}

        //public void InsertMoney(int addedMoney)
        //{

        //}

        //Public Product Purchase()
        //{
        //   

        //}


        public string ShowAll()
        {
            string message = "";

            foreach (Product product in productList)
            {
               message += product.Examine(); 
                Console.WriteLine("hej!");
            }
            return message;

        }
    }
}
