﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineController

{
    interface IVending 
    {
        public int[] ShowAll();
        public void InsertMoney(int addedMoney);
        public Dictionary<int, int> EndTransaction();
        public List<Product> Purchase();

       
    }
}