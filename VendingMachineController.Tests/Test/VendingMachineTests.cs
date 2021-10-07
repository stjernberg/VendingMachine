using System;

using System.Text;
using Xunit;


namespace VendingMachineController.Tests
{
    
    public class VendingMachineTests
    {
        [Theory]
        [InlineData(20, 25)]
        public void TestMethod1(int price, int deposit)
        {
            VendingMachine vending = new VendingMachine();

        }
    }
}
