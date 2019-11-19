using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xsst.Model
{
    class Kinds
    {
        private string id = "";
        private string name = "";
        private string photoID = "";
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string PhotoID
        {
            get { return photoID; }
            set { photoID = value; }
        }
    }
}
