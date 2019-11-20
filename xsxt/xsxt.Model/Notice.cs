using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xsxt.Model
{
    public class Notice
    {
        private string id = "";
        private string title = "";
        private string infor = "";
        private string submitdate = "";
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Infor
        {
            get { return infor; }
            set { infor = value; }
        }
        public string Submitdate
        {
            get { return submitdate; }
            set { submitdate = value; }
        }
    }
}
