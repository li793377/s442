using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xsxt.Model;
using xsxt.DAL;

namespace xsxt.BLL
{
    public static class OrdersManager
    {
        public static Orders GetOrdersByUsername(Orders orders)
        {
            return OrdersSer.GetOrdersByUsername(orders);
        }
        public static int AddOrders(Orders orders)
        {
            return OrdersSer.AddOrders(orders);
        }
    }
}
