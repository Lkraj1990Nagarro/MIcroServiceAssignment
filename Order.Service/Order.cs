using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Service
{
    public class Order
    {
        public int OrderId { get; set; }
        public double Amount { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
