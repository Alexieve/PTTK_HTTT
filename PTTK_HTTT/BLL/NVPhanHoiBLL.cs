using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class NVPhanHoiBLL
    {
        private NVPhanHoiDAL nvPhanHoiDal = new();
        public NVPhanHoiBLL() { }

        public string Insert(NVPhanHoiDTO ph)
        {
            if (ph.NOIDUNG == "")
            {
                return "Nội dung không được để trống";
            }
            nvPhanHoiDal.Insert(ph);
            return "";
        }
    }
}
