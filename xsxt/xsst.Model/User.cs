using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xsst.Model
{
    class User
    {
        private string username = "";
        private string password = "";
        private string tname = "";
        private bool sex = false;
        private string email = "";
        private string tel = "";
        private string adr = "";
        private string photoID = "";
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Tname
        {
            get { return tname; }
            set { tname = value; }
        }
        public bool Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public string Adr
        {
            get { return adr; }
            set { adr = value; }
        }
        public string PhotoID
        {
            get { return photoID; }
            set { photoID = value; }
        }
    }
}
