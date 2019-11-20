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
        public static User getUserByName(User user)
        {
            return UserSer.getUserByName(user);
        }
        public static int addUser(User user)
        {
            return UserSer.addUser(user);
        }
    }
}
