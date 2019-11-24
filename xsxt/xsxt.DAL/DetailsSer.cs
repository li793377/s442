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
    public static class DetailsSer
    {
        public static List<Details> GetListOfDetailsByOID(Details details)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@oID",details.OID),
            };
            string sql = "select * from tb_details where id like @oID";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return GetListOfDetailsByDateReader(dr);
        }
        public static int AddDetails(Details details)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@oID",details.OID),
                new SqlParameter("@pID",details.PID),
                new SqlParameter("@number",details.Number),
            };
            string sql = "inser into tb_details values=(@oID,@pID,@number)";
            return sqlHelp.ExecuteNonQuery(sql, sp);
        }
        private static List<Details> GetListOfDetailsByDateReader(SqlDataReader dr)
        {
            List<Details> listOfDetails = new List<Details>();
            while (dr.Read())
            {
                Details details = new Details();
                int oID = dr.GetOrdinal("oID");
                if (!dr.IsDBNull(oID))
                    details.OID = dr.GetString(oID);
                int pID = dr.GetOrdinal("pID");
                if (!dr.IsDBNull(pID))
                    details.PID = dr.GetString(pID);
                int number = dr.GetOrdinal("number");
                if (!dr.IsDBNull(number))
                    details.Number = dr.GetInt32(number);
                listOfDetails.Add(details);
            }
            return listOfDetails;
        }
    }
}
