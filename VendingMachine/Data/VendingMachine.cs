using System;
using System.Collections.Generic;
using System.Text;


namespace VendingMachineController
{
    public class VendingMachine : IVending
    {
        readonly int[] moneyDenominations = { 1, 5, 10, 20, 50, 100, 500, 1000 };
        public List<Product> productList = new List<Product>();
        private static int id;


        public static int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }


        public static int NextProductId()
        {
            ++id;
            return id;
        }

        public Dictionary<int, int> EndTransaction()
        {
            throw new NotImplementedException();
        }

        public void InsertMoney(int addedMoney)
        {
            throw new NotImplementedException();
        }

        public string ListOfProducts()
        {
            //VendingMachine vendingMachine = new VendingMachine();

            productList.Add(new Drink(NextProductId(), "Coke", 15, "Soda"));
            productList.Add(new Drink(NextProductId(), "Fanta", 15, "Soda"));
            productList.Add(new Drink(NextProductId(), "Heineken", 15, "Beer"));
            productList.Add(new Food(NextProductId(), "Tacos", 47, "Dinner"));
            productList.Add(new Food(NextProductId(), "Pizza", 47, "Dinner"));
            productList.Add(new Food(NextProductId(), "Chipss", 47, "Snacks"));
            productList.Add(new Toy(NextProductId(), "Lego", 119, 6));
            productList.Add(new Toy(NextProductId(), "Ball", 39, 4));
            productList.Add(new Toy(NextProductId(), "puzzle", 62, 3));

            foreach (Product product in productList)
            {
                return product.Name;
                //return product.Examine();

            }
            return null;

        }

        

        public List<Product> Purchase()
        {
            throw new NotImplementedException();
        }

        //public Dictionary<int, int> EndTransaction()
        //{

        //}

        //public void InsertMoney(int addedMoney)
        //{

        //}




        public string ShowAll()
        {
            string productInfo = "";
            productInfo += "*** Products in the vending machine ***\n";
            foreach (Product product in productList)
            {
                productInfo += product.Examine();

            }

            return productInfo;



        }
    }
}
