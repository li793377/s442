using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xsxt.Model;
using xsxt.DAL;
namespace xsxt.BLL
{
    public static class ProductManager
    {
        public static int AddProduct(Product product)
        {
            return ProductSer.AddProduct(product);
        }
        public static Product GetProductByName(Product product)
        {
            return ProductSer.GetProductByName(product);
        }
    }
}
