using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Check : Buy
    {
        public Check()
        {
        }

        public void CheckOut(Buy buy)
        {
            if (buy == null) { Console.WriteLine("Object is null."); }

            Console.WriteLine($"Product: {buy.Product}, count: {buy.Count}, sum: {buy.BuySum()}");
        }
    }
}
