﻿using System;
using System.Collections.Generic;


namespace VendingMachineController
{
    class Program
    {
       

        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();

            //ListOfProducts();

           vendingMachine.ListOfProducts();
            Console.WriteLine(vendingMachine.ShowAll()); 
            Console.WriteLine("What do you want to do? Press 1 for buying..");
            int selection = int.Parse(Console.ReadLine());
            
            switch (selection)
            {
                case '1':
                  vendingMachine.ShowAll(); 
                    break;
            }
        }
       
        
    }

    
}
