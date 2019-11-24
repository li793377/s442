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
    public static class MessageSer
    {
        public static Message GetMessageById(Message message)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@id",message.Id),
            };
            string sql = "select * from tb_messsage where id like @id";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return GetMessageByDateReader(dr);
        }
        public static int AddMessage(Message message)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@id",message.Id),
                new SqlParameter("@usename",message.Username),
                new SqlParameter("@oID",message.OID),
                new SqlParameter("@msg",message.Msg),
                new SqlParameter("@date",message.Date),
            };
            string sql = "inser into tb_message values=(@id,@usename,@oID,@msg,@date)";
            return sqlHelp.ExecuteNonQuery(sql, sp);
        }
        private static Message GetMessageByDateReader(SqlDataReader dr)
        {
            Message message = new Message();
            while (dr.Read())
            {
                int id = dr.GetOrdinal("id");
                if (!dr.IsDBNull(id))
                    message.Id = dr.GetString(id);
                int usename = dr.GetOrdinal("usename");
                if (!dr.IsDBNull(usename))
                    message.Username = dr.GetString(usename);
                int oID = dr.GetOrdinal("oID");
                if (!dr.IsDBNull(oID))
                    message.OID = dr.GetString(oID);
                int msg = dr.GetOrdinal("msg");
                if (!dr.IsDBNull(msg))
                    message.Msg = dr.GetString(msg);
                int date = dr.GetOrdinal("date");
                if (!dr.IsDBNull(date))
                    message.Date = dr.GetString(date);

            }
            return message;
        }
    }
}
