using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xsxt.Model
{
    public class Address
    {
        private string id = "";
        private string username = "";
        private string adr = "";
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Adr
        {
            get { return adr; }
            set { adr = value; }
        }
    }
}
