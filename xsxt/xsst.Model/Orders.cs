using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xsst.Model
{
    class Orders
    {
        private string id = "";
        private string username = "";
        private int count = 0;
        private decimal sum = 0m;
        private string date = "";
        private bool payState = false;
        private string receiver = "";
        private string aID = "";
        private string tel = "";
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
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public decimal Sum
        {
            get { return sum; }
            set { sum = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public bool PayState
        {
            get { return payState; }
            set { payState = value; }
        }
        public string Receiver
        {
            get { return receiver; }
            set { receiver = value; }
        }
        public string AID
        {
            get { return aID; }
            set { aID = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
    }
}
