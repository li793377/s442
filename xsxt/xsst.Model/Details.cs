using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xsst.Model
{
    class Details
    {
        private string oID = "";
        private string pID = "";
        private int number = 0;
        public string OID
        {
            get { return oID; }
            set { oID = value; }
        }
        public string PID
        {
            get { return pID; }
            set { pID = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}
