using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xsxt.DAL;
using xsxt.Model;
namespace xsxt.BLL
{
    public static class UserManager
    {
        public static User GetUserByName(User user)
        {
            return UserSer.GetUserByName(user);
        }
        public static int AddUser(User user)
        {
            return UserSer.AddUser(user);
        }
    }
}
