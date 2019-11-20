using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xsxt.Model
{
    public class Admin
    {
        private string id = "";
        private string password = "";
        private string tel = "";
        private string photoID = "";
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public string PhotoID
        {
            get { return photoID; }
            set { photoID = value; }
        }

    }
}
