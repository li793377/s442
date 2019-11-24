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
    public static class AdminSer
    {
        public static Admin GetAdminById(Admin admin)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@id",admin.ID),
            };
            string sql = "select * from tb_admin where id like @id";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return GetAdminByDateReader(dr);
        }
        public static int AddAddress(Admin admin)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@id",admin.ID),
                new SqlParameter("@password",admin.Password),
                new SqlParameter("@tel",admin.Tel),
                new SqlParameter("@photoID",admin.PhotoID),
            };
            string sql = "inser into tb_address values=(@id,@password,@tel,@photoID)";
            return sqlHelp.ExecuteNonQuery(sql, sp);
        }
        private static Admin GetAdminByDateReader(SqlDataReader dr)
        {
            Admin admin = new Admin();
            while (dr.Read())
            {
                int id = dr.GetOrdinal("id");
                if (!dr.IsDBNull(id))
                    admin.ID = dr.GetString(id);
                int password = dr.GetOrdinal("password");
                if (!dr.IsDBNull(password))
                    admin.Password = dr.GetString(password);
                int tel = dr.GetOrdinal("tel");
                if (!dr.IsDBNull(tel))
                    admin.Tel = dr.GetString(tel);
                int photoID = dr.GetOrdinal("photoID");
                if (!dr.IsDBNull(photoID))
                    admin.PhotoID = dr.GetString(photoID);
            }
            return admin;
        }
    }
}
