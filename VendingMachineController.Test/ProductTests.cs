using Xunit;
using System.Collections.Generic;

namespace VendingMachineController.Test
{

    public class ProductTests
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

        [Fact]
        public void Use_Test()
        {
            Toy toy = new Toy(VendingMachine.NextProductId(), "Doll", 49, 3);
            Food food = new Food(VendingMachine.NextProductId(), "Popcorn", 32, "Snacks");
            Drink drink = new Drink(VendingMachine.NextProductId(), "Seven up", 19, "Soda");

            Assert.Equal($"Here's your {drink.Name}, enjoy your drink!", drink.Use());
            Assert.Equal($"Here's your {food.Name}, enjoy your meal!", food.Use());
            Assert.Equal($"Here's your {toy.Name}, have fun with it!", toy.Use());
        }

        [Fact]
        public void Examine_Test()
        {
            VendingMachine.Reset();
            Toy toy = new Toy(VendingMachine.NextProductId(), "Car", 49, 3);
            Food food = new Food(VendingMachine.NextProductId(), "Chips", 32, "Snacks");
            Drink drink = new Drink(VendingMachine.NextProductId(), "Fanta", 19, "Soda");

          
            Assert.Equal($"\n--- TOY ---\nId: 1 \nName: Car\nPrice: 49\nRecommended age: 3\n", toy.Examine());
            Assert.Equal($"\n--- FOOD ---\nId: 2 \nName: Chips\nPrice: 32\nType of food: Snacks\n", food.Examine());
            Assert.Equal($"\n--- DRINK ---\nId: 3 \nName: Fanta\nPrice: 19\nType of drink: Soda\n", drink.Examine());                    
        }


    }//class
}//namespace
