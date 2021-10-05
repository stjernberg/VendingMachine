using System;
using System.Collections.Generic;
using System.Text;


namespace VendingMachineController
{
    class VendingMachine //: IVending
    {
        readonly int[] moneyDenominations = { 1, 5, 10, 20, 50, 100, 500, 1000 };
        public List<Product> productList = new List<Product>();



        //public Dictionary<int, int> EndTransaction()
        //{

        //}

        //public void InsertMoney(int addedMoney)
        //{

        //}

        //public Product Purchase()
        //{

        //}


        //public int[] ShowAlll()
        //{
        //    return moneyDenominations;
        //}

    }
}
