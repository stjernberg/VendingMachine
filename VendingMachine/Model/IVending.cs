using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController

{
    interface IVending 
    {
        public string ShowAll();
        public int InsertMoney(int addedMoney);
        public Dictionary<int, int> EndTransaction();
        public string Purchase(int id);


    }
}
