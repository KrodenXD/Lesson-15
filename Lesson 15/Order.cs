using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15
{
    class Order
    {
        public int ShippingTimeEst { get; set; }
        public int TrackingID { get; set; }
        public decimal ShippingCost { get; set; }
        public decimal Discount { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }

        public void MakeOrder(int weight,string from)
        {
            if(from == Convert.ToString(ITransport.RestrictedIn.Azerbaijan) || from == Convert.ToString(ITransport.RestrictedIn.Turkey))
            {
                Console.WriteLine("Ordering from " + from + " is restricted");
            }
            else
            {
                if(weight <= 500)
                {
                    Console.WriteLine("your order can be delivered by a truck");
                    Console.WriteLine("");
                }
                else if(weight > 500 && weight <= 5000)
                {
                    Console.WriteLine("your order can be delivered by a plane");
                }
                else if(weight > 5000)
                {
                    Console.WriteLine("your order can be delivered by a ship");
                }
            }
        }
    }
}
