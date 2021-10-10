using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController

{
    interface IVending 
    {
        public string ShowAll();
        public void InsertMoney(int addedMoney);
        public Dictionary<int, int> EndTransaction();
        public Product Purchase(int id);

    }
}
