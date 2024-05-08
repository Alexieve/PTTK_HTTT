using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAL;
using DTO;
using Microsoft.VisualBasic.Devices;

namespace BLL
{
    public class DNPhanHoiBLL
    {
        private DNPhanHoiDAL hopDongDAL = new();
        public DNPhanHoiBLL() { }

        
        public int ThemDNPhanHoi(string mahd, string noidung)
        {

            if (string.IsNullOrEmpty(noidung))
            {
                MessageBox.Show("Nội dung không được để trống");
                return 3;
            }
            string resValue = hopDongDAL.ThemDNPhanHoi(mahd, noidung);
            if (resValue == "1")
                return 0;
            if (resValue == "5")
                return 5;
            return 1;
            //return hopDongDAL.ThemDNPhanHoi(mahd, noidung);
        }
        public DNPhanHoiDTO Get_PHANHOI_For_TraCuuHD_DN(string keyword)
        {
            DataTable dt = hopDongDAL.Get_PHANHOI_For_TraCuuHD_DN(keyword.ToUpper());
            DataRow dr = dt.Rows[0];
            DNPhanHoiDTO svDTO = new DNPhanHoiDTO(
                dr["MAHOPDONG"].ToString(),
                DateTime.Parse(dr["NGAYPH"].ToString()),
                dr["NOIDUNG"].ToString());
            return svDTO;
        }
        
        public string Check_Tontai_PhanHoi(string tmp)
        {
            return hopDongDAL.Check_Tontai_PhanHoi(tmp);
        }
        
    }
}
