using System;
using System.Collections.Generic;
using System.Linq;


namespace VendingMachineController
{
    public class VendingMachine : IVending
    {
        private readonly int[] moneyDenominations = { 1, 5, 10, 20, 50, 100, 500, 1000 };
        public List<Product> productList = new List<Product>();
        private static int id;
        public int deposit;

        public int[] MoneyDenominations { get; }
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
            
            return ++id;
        }

        public Dictionary<int, int> EndTransaction()
        {
            throw new NotImplementedException();
        }

       
        public List<Product> ListOfProducts()
        {
           
            productList.Add(new Drink(NextProductId(), "Coke", 15, "Soda"));
            productList.Add(new Drink(NextProductId(), "Fanta", 15, "Soda"));
            productList.Add(new Drink(NextProductId(), "Heineken", 15, "Beer"));
            productList.Add(new Food(NextProductId(), "Tacos", 47, "Dinner"));
            productList.Add(new Food(NextProductId(), "Pizza", 47, "Dinner"));
            productList.Add(new Food(NextProductId(), "Chipss", 47, "Snacks"));
            productList.Add(new Toy(NextProductId(), "Lego", 119, 6));
            productList.Add(new Toy(NextProductId(), "Ball", 39, 4));
            productList.Add(new Toy(NextProductId(), "puzzle", 62, 3));

            return productList;

        }

        

        public string Purchase(int id)
        {
            string purchaseMessage = "";
            foreach (Product product in productList)
            {
                if (product.Id == id)
                {
                    if (deposit >= product.Price)
                    {
                        deposit -= product.Price;
                        purchaseMessage += $"Here's your {product.Name}!";
                    }

                    else
                    {
                        purchaseMessage += "Sorry, you dont have enogh money to buy this product.";
                    }
                }
            }
            return purchaseMessage;

        }

        //public Dictionary<int, int> EndTransaction()
        //{
        //    Dictionary<int, int> changeDictionary = new Dictionary<int, int>();

        //    foreach (int  moneyType in moneyDenominations)
        //    {
        //        changeDictionary.Add(moneyType, )
        //    }
        //}

        public int InsertMoney(int addedMoney)
        {            
            if (MoneyDenominations.Contains(addedMoney))
            {
                deposit += addedMoney;
            }

            return deposit;
        }



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

    }//class
}//namespace
