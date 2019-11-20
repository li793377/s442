using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xsxt.Model
{
    public class Picture
    {
        private string id = "";
        private string photo = "";
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }
    }
}
