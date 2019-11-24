using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xsxt.DAL;
using xsxt.Model;

namespace xsxt.BLL
{
    public static class NoticeManager
    {
        public static Notice GetNoticeById(Notice notice)
        {
            return NoticeSer.GetNoticeById(notice);
        }
        public static int AddNotice(Notice notice)
        {
            return NoticeSer.AddNotice(notice);
        }
    }
}
