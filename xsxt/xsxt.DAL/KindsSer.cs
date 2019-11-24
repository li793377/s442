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
    public static class KindsSer
    {
        public static Kinds GetKindseById(Kinds kinds)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@id",kinds.Id),
            };
            string sql = "select * from tb_kinds where id like @id";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return GetKindsByDateReader(dr);
        }
        public static int AddKinds(Kinds kinds)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@id",kinds.Id),
                new SqlParameter("@name",kinds.Name),
                new SqlParameter("@photoID",kinds.PhotoID)
            };
            string sql = "inser into tb_kinds values=(@id,@name,@photoID)";
            return sqlHelp.ExecuteNonQuery(sql, sp);
        }
        private static Kinds GetKindsByDateReader(SqlDataReader dr)
        {
            Kinds kinds = new Kinds();
            while (dr.Read())
            {
                int id = dr.GetOrdinal("id");
                if (!dr.IsDBNull(id))
                    kinds.Id = dr.GetString(id);
                int name = dr.GetOrdinal("name");
                if (!dr.IsDBNull(name))
                    kinds.Name = dr.GetString(name);
                int photoID = dr.GetOrdinal("photoID");
                if (!dr.IsDBNull(photoID))
                    kinds.PhotoID = dr.GetString(photoID);

            }
            return kinds;
        }
    }
}
