using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15
{
    interface ITransport
    {
        public int ShippingTime { get; set; }
        public int MaxWeight { get; set; }
        public int MinWeight { get; set; }
        public enum RestrictedIn
        {
            Azerbaijan,
            Turkey,
        }
    } 
}
