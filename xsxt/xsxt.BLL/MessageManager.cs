using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xsxt.DAL;
using xsxt.Model;

namespace xsxt.BLL
{
    public static class MessageManager
    {
        public static Message GetMessageById(Message message)
        {
            return MessageSer.GetMessageById(message);
        }
        public static int AddMessage(Message message)
        {
            return MessageSer.AddMessage(message);
        }
    }
}
