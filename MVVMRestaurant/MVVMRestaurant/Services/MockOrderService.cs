﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMRestaurant.Services
{
    class MockOrderService:IOrderService
    {
        public void PlaceOrder(List<string> dishes)
        {
            System.IO.File.WriteAllLines(@"C:\order.txt", dishes.ToArray());
        }
    }
}
