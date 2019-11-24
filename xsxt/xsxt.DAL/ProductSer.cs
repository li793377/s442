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
    public static class ProductSer
    {
        public static Product GetProductByName(Product product)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@name",product.Name),
            };
            string sql = "select * from tb_product where name like @name";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return GetProductByDateReader(dr);
        }
        public static int AddProduct(Product product)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@id",product.Id),
                new SqlParameter("@name",product.Name),
                new SqlParameter("@number",product.Number),
                new SqlParameter("@price",product.Price),
                new SqlParameter("@kID",product.KID),
                new SqlParameter("@guige",product.Guige),
                new SqlParameter("@photoID",product.PhotoID),
                new SqlParameter("@introduce",product.Introduce),
            };
            string sql = "inser into tb_product values=(@id,@name,@number,@price,@kID,@guige,@photoID,@introduce)";
            return sqlHelp.ExecuteNonQuery(sql, sp);
        }
        private static Product GetProductByDateReader(SqlDataReader dr)
        {
            Product product = new Product();
            while (dr.Read())
            {
                int id = dr.GetOrdinal("id");
                if (!dr.IsDBNull(id))
                    product.Id = dr.GetString(id);
                int name = dr.GetOrdinal("name");
                if (!dr.IsDBNull(name))
                    product.Name = dr.GetString(name);
                int number = dr.GetOrdinal("number");
                if (!dr.IsDBNull(number))
                    product.Number = dr.GetString(number);
                int price = dr.GetOrdinal("price");
                if (!dr.IsDBNull(price))
                    product.Price = dr.GetDecimal(price);
                int kID = dr.GetOrdinal("kID");
                if (!dr.IsDBNull(kID))
                    product.KID = dr.GetString(kID);
                int guige = dr.GetOrdinal("guige");
                if (!dr.IsDBNull(guige))
                    product.Guige = dr.GetString(guige);
                int photoID = dr.GetOrdinal("photoID");
                if (!dr.IsDBNull(photoID))
                    product.PhotoID = dr.GetString(photoID);
                int introduce = dr.GetOrdinal("introduce");
                if (!dr.IsDBNull(introduce))
                    product.Introduce = dr.GetString(introduce);
            }
            return product;
        }
    }
}
