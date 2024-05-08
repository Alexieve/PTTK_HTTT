using System;
using System.Collections.Generic;
using System.Data;
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

        public string Get_New(string MAUV, string MAHOPDONG)
        {
            DataTable dt = nvPhanHoiDal.Get_New(MAUV, MAHOPDONG);
            if (dt.Rows.Count == 0)
            {
                return "";
            }
            return dt.Rows[0]["NOIDUNG"].ToString();
        }
    }
}
