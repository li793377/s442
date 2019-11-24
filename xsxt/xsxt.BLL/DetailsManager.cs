using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xsxt.Model;
using xsxt.DAL;

namespace xsxt.BLL
{
    public static class DetailsManager
    {
        public static List<Details> GetListOfDetailsByOID(Details details)
        {
            return DetailsSer.GetListOfDetailsByOID(details);
        }
        public static int AddDetails(Details details)
        {
            return DetailsSer.AddDetails(details);
        }
    }
}
