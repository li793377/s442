using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using xsxt.Model;
using xsxt.DBHelper;
namespace xsxt.DAL
{
    public static class AddressSer
    {
        public static Address GetAddressByUsername(Address address)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@username",address.Username),
            };
            string sql = "select * from tb_address where username like @username";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return GetAddressByDateReader(dr);
        }
        public static int AddAddress(Address address)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@id",address.Id),
                new SqlParameter("@username",address.Username),
                new SqlParameter("@adr",address.Adr),
            };
            string sql = "inser into tb_address values=(@id,@username,@adr)";
            return sqlHelp.ExecuteNonQuery(sql, sp);
        }
        private static Address GetAddressByDateReader(SqlDataReader dr)
        {
            Address address=new Address();
            while (dr.Read())
            {
                int id = dr.GetOrdinal("id");
                if (!dr.IsDBNull(id))
                    address.Id = dr.GetString(id);
                int username = dr.GetOrdinal("username");
                if (!dr.IsDBNull(username))
                    address.Username = dr.GetString(username);
                int adr = dr.GetOrdinal("adr");
                if (!dr.IsDBNull(adr))
                    address.Adr = dr.GetString(adr);
            }
            return address;
        }
    }
}
