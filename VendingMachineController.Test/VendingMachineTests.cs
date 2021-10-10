using System;
using System.Collections.Generic;
using Xunit;

namespace VendingMachineController.Test
{
    public class VendingMachineTests
    {

        [Fact]
        public void Purchase_Test()
        {
            VendingMachine vending = new VendingMachine();

            vending.productList.Add(new Drink(1, "Coke", 15, "Soda"));
            vending.productList.Add(new Food(2, "Tacos", 47, "Dinner"));
            vending.productList.Add(new Toy(3, "puzzle", 62, 4));
            vending.Deposit = 200;

            Assert.Equal(vending.productList[0], vending.Purchase(1));
            Assert.Equal(vending.productList[1], vending.Purchase(2));
            Assert.Equal(vending.productList[2], vending.Purchase(3));
        }

        [Fact]
        public void Purchase_NotEnoghMoney_Test()
        {
            VendingMachine vending = new VendingMachine();

            vending.productList.Add(new Drink(1, "Coke", 15, "Soda"));
            vending.productList.Add(new Food(2, "Tacos", 47, "Dinner"));
            vending.productList.Add(new Toy(3, "puzzle", 62, 4));
            vending.Deposit = 10;

            Assert.NotEqual(vending.productList[0], vending.Purchase(1));
            Assert.NotEqual(vending.productList[1], vending.Purchase(2));
            Assert.NotEqual(vending.productList[2], vending.Purchase(3));
        }

        [Fact]
        public void Purchase_ProductDoesntExist_Test()
        {
            VendingMachine vending = new VendingMachine();

            vending.productList.Add(new Drink(1, "Coke", 15, "Soda"));
            vending.productList.Add(new Food(2, "Tacos", 47, "Dinner"));
            vending.productList.Add(new Toy(3, "puzzle", 62, 4));
            vending.Deposit = 99;
            
            vending.productList.RemoveAt(2);
            Assert.NotEqual(vending.productList[1], vending.Purchase(3));
            Assert.Equal(vending.productList[1], vending.Purchase(2));
            Assert.Equal(vending.productList[0], vending.Purchase(1));          
        }

        [Fact]
        public void InsertMoney_Test()
        {
            VendingMachine vending = new VendingMachine();
            vending.InsertMoney(10);
            vending.InsertMoney(15);
            vending.InsertMoney(15);
            vending.InsertMoney(50);
            vending.InsertMoney(110);
            Assert.Equal(60, vending.Deposit);
        }


        [Fact]
        public void NextProductId_Test()
        {
            int expectedId1 = 1;
            int expectedId2 = 2;
            int id1;
            int id2;

            id1 = VendingMachine.NextProductId();
            id2 = VendingMachine.NextProductId();

            Assert.Equal(expectedId1, id1);
            Assert.Equal(expectedId2, id2);
        }

        [Fact]
        public void ResetProductId_Test()
        {
            int expected = 0;
            VendingMachine.Id = 4;

            VendingMachine.Reset();

            Assert.Equal(expected, VendingMachine.Id);
        }

        [Fact]
        public void EndTransaction_Test()
        {            
            VendingMachine vending = new VendingMachine();
            
            int expectedAmount = 210;
            int actualAmount = 0;
            vending.Deposit = 210;

            Dictionary<int, int> actualValues;
          
            actualValues = vending.EndTransaction();

            foreach (KeyValuePair<int, int> pair in actualValues)
            {
                actualAmount += pair.Key * pair.Value;
            }
                       
            Assert.Equal(expectedAmount, actualAmount);

            
        }
    }
}
