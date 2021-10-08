using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VendingMachineController.Test
{

    public class ProductTest
    {
        [Fact]
        public void CreateProduct_Test()
        {
          
            Toy toy = new Toy(VendingMachine.NextProductId(), "Doll", 49, 3);
            Food food = new Food(VendingMachine.NextProductId(), "Popcorn", 32, "Snacks");
            Drink drink = new Drink(VendingMachine.NextProductId(), "Seven up", 19, "Soda");

            Assert.Equal(1, toy.Id);
            Assert.Equal("Doll", toy.Name);
            Assert.Equal(49, toy.Price);
            Assert.Equal(3, toy.RecommendedAge);

            Assert.Equal(2, food.Id);
            Assert.Equal("Popcorn", food.Name);
            Assert.Equal(32, food.Price);
            Assert.Equal("Snacks", food.TypeOfFood);

            Assert.Equal(3, drink.Id);
            Assert.Equal("Seven up", drink.Name);
            Assert.Equal(19, drink.Price);
            Assert.Equal("Soda", drink.TypeOfDrink);
        }

    }//class
}//namespace
