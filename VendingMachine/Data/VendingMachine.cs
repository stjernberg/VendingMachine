using System;
using System.Collections.Generic;
using System.Linq;



namespace VendingMachineController
{
    public class VendingMachine : IVending
    {
        private readonly int[] moneyDenominations = new int[] { 1000, 500, 100, 50, 20, 10, 5, 1 };
        public List<Product> productList = new List<Product>();
        private static int id;
        public int Deposit { get; set; }

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

        public int[] MoneyDenominations
        {
            get
            {
                return moneyDenominations;
            }
        }

        public static int NextProductId()
        {
            return ++id;
        }

        public static void Reset()
        {
            id = 0;
        }


        public List<Product> ListOfProducts()
        {
            productList.Add(new Drink(NextProductId(), "Coke", 15, "Soda"));
            productList.Add(new Drink(NextProductId(), "Fanta", 17, "Soda"));
            productList.Add(new Drink(NextProductId(), "Heineken", 24, "Beer"));
            productList.Add(new Food(NextProductId(), "Tacos", 47, "Dinner"));
            productList.Add(new Food(NextProductId(), "Pizza", 49, "Dinner"));
            productList.Add(new Food(NextProductId(), "Chips", 52, "Snacks"));
            productList.Add(new Toy(NextProductId(), "Lego", 119, 6));
            productList.Add(new Toy(NextProductId(), "Ball", 39, 4));
            productList.Add(new Toy(NextProductId(), "puzzle", 62, 3));

            return productList;

        }

        public void Clear()
        {
            productList.Clear();
        }

        public void InsertMoney(int addedMoney)
        {
            if (moneyDenominations.Contains(addedMoney))
            {
                Deposit += addedMoney;
            }
            else
            {
                Console.WriteLine("Invalid type of money, try again.");
            }
        }


        public Product Purchase(int id)
        {
            foreach (Product product in productList)
            {
                if (product != null)
                {
                    if (product.Id == id)
                    {
                        if (Deposit >= product.Price)
                        {
                            Deposit -= product.Price;
                            Console.WriteLine(product.Use());
                            return product;
                        }

                        else
                        {
                            Console.WriteLine("Sorry, you dont have enogh money to buy this product.");

                        }
                    }
                }
                else
                {
                    Console.WriteLine("Product not found");
                }

            }
            return null;
        }

        public Dictionary<int, int> EndTransaction()
        {
            Dictionary<int, int> moneyDictionary = new Dictionary<int, int>();
            foreach (int moneyType in moneyDenominations)
            {
                moneyDictionary.Add(moneyType, Deposit / moneyType);
                Deposit %= moneyType;
            }
            return moneyDictionary;
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
