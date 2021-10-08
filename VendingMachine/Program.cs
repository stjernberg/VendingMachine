using System;



namespace VendingMachineController
{
    class Program
    {


        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();

            vendingMachine.ListOfProducts();
            Console.WriteLine(vendingMachine.ShowAll());
        }         
        
    }

   }
