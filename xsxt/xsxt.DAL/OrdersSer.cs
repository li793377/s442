using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xsxt.Model;
using xsxt.DBHelper;
using System.Data.SqlClient;
namespace xsxt.DAL
{
    public static class OrdersSer
    {
        public static Orders GetOrdersByUsername(Orders orders)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@username",orders.Username),
            };
            string sql = "select * from tb_orders where username like @username";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return GetOrdersByDateReader(dr);
        }
        public static int AddOrders(Orders orders)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@id",orders.Id),
                new SqlParameter("@username",orders.Username),
                new SqlParameter("@count",orders.Count),
                new SqlParameter("@sum",orders.Sum),
                new SqlParameter("@date",orders.Date),
                new SqlParameter("@payState",orders.PayState),
                new SqlParameter("@receiver",orders.Receiver),
                new SqlParameter("@aID",orders.AID),
                new SqlParameter("@tel",orders.Tel),
            };
            string sql = "inser into tb_orders values=(@id,@username,@count,@sum,@date,@payState,@receiver,@aID,@tel)";
            return sqlHelp.ExecuteNonQuery(sql, sp);
        }
        private static Orders GetOrdersByDateReader(SqlDataReader dr)
        {
            Orders orders=new Orders();
            while (dr.Read())
            {
                int ID = dr.GetOrdinal("ID");
                if (!dr.IsDBNull(ID))
                    orders.Id = dr.GetString(ID);
                int username = dr.GetOrdinal("username");
                if (!dr.IsDBNull(username))
                    orders.Username = dr.GetString(username);
                int count = dr.GetOrdinal("count");
                if (!dr.IsDBNull(count))
                    orders.Count = dr.GetInt32(count);
                int sum = dr.GetOrdinal("sum");
                if (!dr.IsDBNull(sum))
                    orders.Sum = dr.GetDecimal(sum);
                int date = dr.GetOrdinal("date");
                if (!dr.IsDBNull(date))
                    orders.Date = dr.GetString(date);
                int payState = dr.GetOrdinal("payState ");
                if (!dr.IsDBNull(payState))
                    orders.PayState = dr.GetBoolean(payState);
                int receiver = dr.GetOrdinal("receiver");
                if (!dr.IsDBNull(receiver))
                    orders.Receiver = dr.GetString(receiver);
                int aID = dr.GetOrdinal("aID");
                if (!dr.IsDBNull(aID))
                    orders.AID = dr.GetString(aID);
                int tel = dr.GetOrdinal("tel");
                if (!dr.IsDBNull(tel))
                    orders.Tel = dr.GetString(tel);
            }
            return orders;
        }
    }
}
