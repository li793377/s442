using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xsxt.Model;
using xsxt.DAL;

namespace xsxt.BLL
{
    public static class AdminManager
    {
        public static Admin GetAdminById(Admin admin)
        {
            return AdminSer.GetAdminById(admin);
        }
        public static int AddAddress(Admin admin)
        {
            return AdminSer.AddAddress(admin);
        }
    }
}
