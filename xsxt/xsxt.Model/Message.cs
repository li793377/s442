using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xsxt.Model
{
    public class Message
    {
        private string id = "";
        private string username = "";
        private string oID = "";
        private string msg = "";
        private string date = "";
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
        public string OID
        {
            get { return oID; }
            set { oID = value; }
        }
        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
