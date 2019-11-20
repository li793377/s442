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
    public static class UserSer
    {
        public static User getUserByName(User user)
        {
            SqlParameter[] sp=
            {
                new SqlParameter("@username",user.Username),
            };
            string sql = "select * from tb_user where username like @username";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return getUserByDateReader(dr);
        }
        public static int addUser(User user)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@username",user.Username),
                new SqlParameter("@password",user.Password),
                new SqlParameter("@tname",user.Tname),
                new SqlParameter("@sex",user.Sex),
                new SqlParameter("@email",user.Email),
                new SqlParameter("@tel",user.Tel),
                new SqlParameter("@adr",user.Adr),
                new SqlParameter("@photoID",user.PhotoID),
            };
            string sql = "inser into tb_user values=(@username,@password,@tname,@sex,@email,@tel,@adr,@photoID)";
            return sqlHelp.ExecuteNonQuery(sql,sp);
        }
        private static User getUserByDateReader(SqlDataReader dr)
        {
            User user = new User();
            while(dr.Read())
            {
                int username = dr.GetOrdinal("username");
                if(!dr.IsDBNull(username))
                    user.Username = dr.GetString(username);
                int password = dr.GetOrdinal("password");
                if (!dr.IsDBNull(password))
                    user.Password = dr.GetString(password);
                int tname = dr.GetOrdinal("tname");
                if (!dr.IsDBNull(tname))
                    user.Tname = dr.GetString(tname);
                int sex = dr.GetOrdinal("sex");
                if (!dr.IsDBNull(password))
                    user.Sex = dr.GetBoolean(sex);
                int email = dr.GetOrdinal("email");
                if (!dr.IsDBNull(email))
                    user.Email = dr.GetString(email);
                int tel = dr.GetOrdinal("tel");
                if (!dr.IsDBNull(tel))
                    user.Tel = dr.GetString(tel);
                int adr = dr.GetOrdinal("adr");
                if (!dr.IsDBNull(adr))
                    user.Adr = dr.GetString(adr);
                int photoID = dr.GetOrdinal("photoID");
                if (!dr.IsDBNull(photoID))
                    user.PhotoID = dr.GetString(photoID);
            }
            return user;
        }

    }
}
