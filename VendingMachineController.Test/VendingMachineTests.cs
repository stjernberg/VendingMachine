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

        //[Fact]
        //public void NotEnoghMoney_Test()
        //{
        //    VendingMachine vending = new VendingMachine();
        //    vending.deposit = 10;

        //    Product product = new Drink(4, "Coke", 15, "Soda");
        //    //vending.productList.Add(new Drink(4, "Coke", 15, "Soda"));
        //    var exception = Assert.Throws<ArgumentException>(() =>vending.Purchase(4));


        //    Assert.Equal("Not enough money", exception.Message);
        //}

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
            vending.Deposit = 2170;
            
            Dictionary<int, int> expectedValues = new Dictionary<int, int>() { { 1000, 1 }, { 500, 1 }, { 100, 4 }, { 50, 3 }, { 20, 0 }, { 10, 0 }, { 5, 4 }, { 1, 0 } };
           
             Assert.Equal( expectedValues, vending.EndTransaction());
        }
    }
}
