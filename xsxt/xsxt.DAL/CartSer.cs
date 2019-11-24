using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xsxt.DBHelper;
using xsxt.Model;
using System.Data.SqlClient;

namespace xsxt.DAL
{
    public static class CartSer
    {
        public static List<Cart> GetListOfCartByUsername(Cart cart)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@username",cart.Username),
            };
            string sql = "select * from tb_cart where id like @username";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return GetListOfCartByDateReader(dr);
        }
        public static int AddCart(Cart cart)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@pID",cart.PID),
                new SqlParameter("@username",cart.Username),
                new SqlParameter("@count",cart.Count),
            };
            string sql = "inser into tb_cart values=(@pID,@username,@count)";
            return sqlHelp.ExecuteNonQuery(sql, sp);
        }
        private static List<Cart> GetListOfCartByDateReader(SqlDataReader dr)
        {
            List<Cart> listOfCart = new List<Cart>();
            while (dr.Read())
            {
                Cart cart = new Cart();
                int pID = dr.GetOrdinal("pID");
                if (!dr.IsDBNull(pID))
                    cart.PID = dr.GetString(pID);
                int username = dr.GetOrdinal("username");
                if (!dr.IsDBNull(username))
                    cart.Username = dr.GetString(username);
                int count = dr.GetOrdinal("count");
                if (!dr.IsDBNull(count))
                    cart.Count = dr.GetInt32(count);
                listOfCart.Add(cart);
            }
            return listOfCart;
        }
    }
}
