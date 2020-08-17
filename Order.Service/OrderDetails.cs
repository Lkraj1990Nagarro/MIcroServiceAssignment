using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Service
{
    public class OrderDetails
    {
        public IList<Order> GetOrders(int userId)
        {
            return new List<Order>()
            {
                new Order{OrderId=1,Amount=250,OrderDate=Convert.ToDateTime("02-05-2020") },
                new Order{OrderId=2,Amount=150,OrderDate=Convert.ToDateTime("03-04-2020") },
                new Order{OrderId=3,Amount=350,OrderDate=Convert.ToDateTime("04-03-2020") },
                new Order{OrderId=4,Amount=200,OrderDate=Convert.ToDateTime("05-02-2020") }
            };
        }
    }
}
