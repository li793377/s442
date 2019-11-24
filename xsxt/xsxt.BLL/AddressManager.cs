using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xsxt.DAL;
using xsxt.Model;

namespace xsxt.BLL
{
    public static class AddressManager
    {
        public static Address GetAddressByUsername(Address address)
        {
            return AddressSer.GetAddressByUsername(address);
        }
        public static int AddAddress(Address address)
        {
            return AddressSer.AddAddress(address);
        }
    }
}
