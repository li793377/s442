using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xsxt.Model;
using xsxt.DAL;
namespace xsxt.BLL
{
    public static class PictureManager
    {
        public static int AddPicture(Picture picture)
        {
            return PictureSer.AddPicture(picture);
        }
    }
}
