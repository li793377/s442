using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xsxt.DBHelper;
using xsxt.Model;
namespace xsxt.DAL
{
    public static class PictureSer
    {
        public static int AddPicture(Picture picture)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@id",picture.Id),
                new SqlParameter("@photo",picture.Photo)
            };
            string sql = "inser into tb_picture values=(@id,@photo)";
            return sqlHelp.ExecuteNonQuery(sql, sp);
        }
        private static Picture GetPictureByDateReader(SqlDataReader dr)
        {
            Picture picture = new Picture();
            while (dr.Read())
            {
                int id = dr.GetOrdinal("id");
                if (!dr.IsDBNull(id))
                    picture.Id = dr.GetString(id);
                int photo = dr.GetOrdinal("photo");
                if (!dr.IsDBNull(photo))
                    picture.Photo = dr.GetString(photo);
            }
            return picture;
        }
    }
}
