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
    public static class NoticeSer
    {
        public static Notice GetNoticeById(Notice notice)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@id",notice.Id),
            };
            string sql = "select * from tb_notice where id like @id";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return GetNoticeByDateReader(dr);
        }
        public static int AddNotice(Notice notice)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@id",notice.Id),
                new SqlParameter("@title",notice.Title),
                new SqlParameter("@info",notice.Infor),
                new SqlParameter("@submitdate",notice.Submitdate),
            };
            string sql = "inser into tb_notice values=(@id,@title,@info,@submitdate)";
            return sqlHelp.ExecuteNonQuery(sql, sp);
        }
        private static Notice GetNoticeByDateReader(SqlDataReader dr)
        {
            Notice notice = new Notice();
            while (dr.Read())
            {
                int id = dr.GetOrdinal("id");
                if (!dr.IsDBNull(id))
                    notice.Id = dr.GetString(id);
                int title = dr.GetOrdinal("title");
                if (!dr.IsDBNull(title))
                    notice.Title = dr.GetString(title);
                int info = dr.GetOrdinal("info");
                if (!dr.IsDBNull(info))
                    notice.Infor = dr.GetString(info);
                int submitdate = dr.GetOrdinal("submitdate");
                if (!dr.IsDBNull(submitdate))
                    notice.Submitdate = dr.GetString(submitdate);
            }
            return notice;
        }
    }
}
