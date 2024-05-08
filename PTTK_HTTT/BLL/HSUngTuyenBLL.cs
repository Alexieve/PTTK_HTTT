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
    public class HSUngTuyenBLL
    {
        private HSUngTuyenDAL hsUngTuyenDAL = new DAL.HSUngTuyenDAL();
        public HSUngTuyenBLL() { }

        public bool Check_Applied(string MAHOPDONG)
        {
            return hsUngTuyenDAL.Check_Applied(MAHOPDONG).Rows.Count > 0;
        }

        public string checkValid(HSUngTuyenDTO hs)
        {
            if (hs.GIOITHIEU == "")
            {
                return "Giới thiệu không được để trống";
            }

            if (hs.HOCVAN == "")
            {
                return "Học vấn không được để trống";
            }

            if (hs.KINHNGHIEM == "")
            {
                return "Kinh nghiệm không được để trống";
            }
            return "";
        }

        public void Insert(HSUngTuyenDTO hs)
        {
            hsUngTuyenDAL.Insert(hs);
        }

        public List<HSUngTuyenDTO> Get_For_DuyetHS_By_KetQua(string MAHOPDONG, int KETQUA)
        {
            DataTable dt = hsUngTuyenDAL.Get_For_DuyetHS_By_KetQua(MAHOPDONG, KETQUA);
            List<HSUngTuyenDTO> listHS = Utility.ToList<HSUngTuyenDTO>(dt);
            return listHS;
        }

        public List<HSUngTuyenDTO> Get_For_PhanHoiHS_By_KetQua(string MAHOPDONG, int KETQUA)
        {
            DataTable dt = hsUngTuyenDAL.Get_For_PhanHoiHS_By_KetQua(MAHOPDONG, KETQUA);
            List<HSUngTuyenDTO> listHS = Utility.ToList<HSUngTuyenDTO>(dt);
            return listHS;
        }

        public HSUngTuyenDTO Get_ChiTiet_HSUngTuyen(string MAUV, string MAHOPDONG)
        {
            DataTable dt = hsUngTuyenDAL.Get_ChiTiet_HSUngTuyen(MAUV, MAHOPDONG);
            HSUngTuyenDTO hs = Utility.ToObject<HSUngTuyenDTO>(dt.Rows[0]);
            return hs;
        }

        public void Update_KetQua(string MAUV, string MAHOPDONG, int KETQUA)
        {
            hsUngTuyenDAL.Update_KetQua(MAUV, MAHOPDONG, KETQUA);
        }

        public void Update_DoUuTien(string MAUV, string MAHOPDONG, int DOUUTIEN)
        {
            hsUngTuyenDAL.Update_DoUuTien(MAUV, MAHOPDONG, DOUUTIEN);
        }

        public List<HSUngTuyenDTO> Get_For_Xac_Thuc_HS()
        {
            DataTable dt = hsUngTuyenDAL.Get_For_Xac_Thuc_HS();
            List<HSUngTuyenDTO> listHS = Utility.ToList<HSUngTuyenDTO>(dt);
            return listHS;
        }

        public List<HSUngTuyenDTO> Get_For_Ket_Qua_Ung_Tuyen()
        {
            DataTable dt = hsUngTuyenDAL.Get_For_Ket_Qua_Ung_Tuyen();
            List<HSUngTuyenDTO> listHS = Utility.ToList<HSUngTuyenDTO>(dt);
            return listHS;
        }

        public void Update(HSUngTuyenDTO hs)
        {
            hsUngTuyenDAL.Update(hs);
        }
    }
}
