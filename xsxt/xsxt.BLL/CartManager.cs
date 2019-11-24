using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xsxt.Model;
using xsxt.DAL;

namespace xsxt.BLL
{
    public static class CartManager
    {
        public static List<Cart> GetListOfCartByUsername(Cart cart)
        {
            return CartSer.GetListOfCartByUsername(cart);
        }
        public static int AddCart(Cart cart)
        {
            return CartSer.AddCart(cart);
        }
    }
}
