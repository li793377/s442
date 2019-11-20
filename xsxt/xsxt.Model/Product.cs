using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xsxt.Model
{
    public class Product
    {
        private string id = "";
        private string name = "";
        private string number = "";
        private decimal price = 0m;
        private string kID = "";
        private string guige = "";
        private string photoID = "";
        private string introduce = "";
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
        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public string KID
        {
            get { return kID; }
            set { kID = value; }
        }
        public string Guige
        {
            get { return guige; }
            set { guige = value; }
        }
        public string PhotoID
        {
            get { return photoID; }
            set { photoID = value; }
        }
        public string Introduce
        {
            get { return introduce; }
            set { introduce = value; }
        }

    }
}
