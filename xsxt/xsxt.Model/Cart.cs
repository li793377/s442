using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xsxt.Model
{
    public class Cart
    {
        private string pID = "";
        private string username = "";
        private int count = 0;
        public string PID
        {
            get { return pID; }
            set { pID = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
    }
}
