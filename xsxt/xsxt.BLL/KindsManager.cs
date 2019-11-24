using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xsxt.DAL;
using xsxt.Model;

namespace xsxt.BLL
{
    public static class KindsManager
    {
        public static Kinds GetKindseById(Kinds kinds)
        {
            return KindsSer.GetKindseById(kinds);
        }
        public static int AddKinds(Kinds kinds)
        {
            return KindsSer.AddKinds(kinds);
        }
    }
}
