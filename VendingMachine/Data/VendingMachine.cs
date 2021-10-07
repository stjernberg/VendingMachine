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
        public int Deposit { get; set; }

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
                            return product;
                        }

                        else
                        {
                            throw new Exception("Sorry, you dont have enogh money to buy this product.");
        
                        }
                    }              
                }
                else
                {
                    throw new Exception("Product not found"); 
                }               

            }
            return null;

        }

        public Dictionary<int, int> EndTransaction()
        {



            int remainingMoney = Deposit;
            Deposit = 0;

            Dictionary<int, int> moneyDictionary = new Dictionary<int, int>();
            foreach (int moneyType in moneyDenominations)
            {
                moneyDictionary.Add(moneyType, remainingMoney / moneyType);
                remainingMoney %= moneyType;
            }
            return moneyDictionary;

            //Dictionary<int, int> changeDictionary = new Dictionary<int, int>();

            //foreach (int moneyType in moneyDenominations)
            //{
            //    changeDictionary.Add(moneyType, deposit / moneyType);
            //    deposit %= moneyType;
            //}

            //return changeDictionary;

        }

            public int InsertMoney(int addedMoney)
            {
                if (MoneyDenominations.Contains(addedMoney))
                {
                    Deposit += addedMoney;
                }

                return Deposit;
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
