using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Template.Models
{
    class salaManager
    {
        public static List<Order> liveOrders = new List<Order>();
        public static Order popSelectedOrder (string tarabyza)
        {
            foreach(var order in liveOrders)
            {
                if (order.tarabyza == tarabyza)
                {

                    liveOrders.Remove(order);
                    return order;
                }
                    
            }
            return new Order();
        }
    }
}
