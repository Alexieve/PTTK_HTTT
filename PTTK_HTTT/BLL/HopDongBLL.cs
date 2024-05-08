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
    public class HopDongBLL
    {
        private HopDongDAL hopDongDAL = new();
        public HopDongBLL() { }

        public List<HopDongDTO> Get_All_For_DuyetHS()
        {
            DataTable dt = hopDongDAL.Get_All_For_DuyetHS();
            List<HopDongDTO> listHD = Utility.ToList<HopDongDTO>(dt);
            return listHD;
        }

        public List<HopDongDTO> Get_All_For_PhanHoiHS()
        {
            DataTable dt = hopDongDAL.Get_All_For_PhanHoiHS();
            List<HopDongDTO> listHD = Utility.ToList<HopDongDTO>(dt);
            return listHD;
        }

        public string Get_YeuCauDN(string MAHOPDONG)
        {
            DataTable dt = hopDongDAL.Get_YeuCauDN(MAHOPDONG);
            return dt.Rows[0]["YEUCAU"].ToString();
        }

        public string Them_HopDong(HopDongDTO _HopDongDTO)
        {
            return hopDongDAL.Them_HopDong(_HopDongDTO);
        }

        public HopDongDTO Find_BY_MAHOPDONG(string MAHOPDONG)
        {
            return hopDongDAL.Find_BY_MAHOPDONG(MAHOPDONG);
        }
        public List<HopDongDTO> Get_All_BaiDangTuyenDung()
        {
            DataTable dt = hopDongDAL.Get_All_BaiDangTuyenDung();
            List<HopDongDTO> listHD = Utility.ToList<HopDongDTO>(dt);
            return listHD;
        }
        public List<HopDongDTO> Search_BaiDangTuyenDung(string SearchString)
        {
            DataTable dt = hopDongDAL.Search_BaiDangTuyenDung(SearchString);
            List<HopDongDTO> listHD = Utility.ToList<HopDongDTO>(dt);
            return listHD;
        }
        public HopDongDTO Get_Detail_BaiDangTuyenDung(string MAHD)
        {
            DataTable dt = hopDongDAL.Get_Detail_BaiDangTuyenDung(MAHD);
            DataRow dataRow = dt.Rows[0];
            HopDongDTO listHD = Utility.ToObject<HopDongDTO>(dataRow);
            return listHD;
        }
                public List<HopDongDTO> Get_All_For_TraCuuHD_DN()
        {
            DataTable dt = hopDongDAL.Get_All_For_TraCuuHD_DN();
            List<HopDongDTO> listHD = Utility.ToList<HopDongDTO>(dt);
            return listHD;
        }
        public List<HopDongDTO> Get_All_For_TraCuuHD_DN_SEARCH(string keyword)
        {
            DataTable dt = hopDongDAL.Get_All_For_TraCuuHD_DN_SEARCH(keyword.ToUpper());
            List<HopDongDTO> listHD = Utility.ToList<HopDongDTO>(dt);
            return listHD;
        }
        public HopDongDTO Get_BAIDANG_For_TraCuuHD_DN(string keyword)
        {
            DataTable dt = hopDongDAL.Get_BAIDANG_For_TraCuuHD_DN(keyword.ToUpper());
            DataRow dr = dt.Rows[0];
            HopDongDTO svDTO = new HopDongDTO(
                dr["MAHOPDONG"].ToString(),
                dr["MADN"].ToString(),
                dr["CAPBACTD"].ToString(),
                dr["VITRITD"].ToString(),
                int.Parse(dr["SOLUONGTD"].ToString()),
                dr["YEUCAU"].ToString(),
                int.Parse(dr["THOIGIANTD"].ToString()),
                DateTime.Parse(dr["NGAYTD"].ToString()),
                dr["TENDN"].ToString(),
                dr["DIACHI"].ToString(),
                dr["KYNANG"].ToString(),
                dr["EMAIL"].ToString());
            return svDTO;
        }
        //public int ThemDNPhanHoi(string mahd, string noidung)
        //{

        //    if (string.IsNullOrEmpty(noidung))
        //    {
        //        MessageBox.Show("Nội dung không được để trống");
        //        return 3;
        //    }
        //    string resValue = hopDongDAL.ThemDNPhanHoi(mahd, noidung);
        //    if (resValue == "1")
        //        return 0;
        //    if (resValue == "5")
        //        return 5;
        //    return 1;
        //    //return hopDongDAL.ThemDNPhanHoi(mahd, noidung);
        //}
        //public HopDongDTO Get_PHANHOI_For_TraCuuHD_DN(string keyword)
        //{
        //    DataTable dt = hopDongDAL.Get_PHANHOI_For_TraCuuHD_DN(keyword.ToUpper());
        //    DataRow dr = dt.Rows[0];
        //    HopDongDTO svDTO = new HopDongDTO(
        //        dr["MAHOPDONG"].ToString(),
        //        DateTime.Parse(dr["NGAYPH"].ToString()),
        //        dr["NOIDUNG"].ToString());
        //    return svDTO;
        //}
        public HopDongDTO Get_NgayThanhToan_For_TraCuuHD_DN(string keyword)
        {
            DataTable dt = hopDongDAL.Get_NgayThanhToan_For_TraCuuHD_DN(keyword.ToUpper());
            DataRow dr = dt.Rows[0];
            HopDongDTO svDTO = new HopDongDTO(
                dr["MAHOPDONG"].ToString(),
                DateTime.Parse(dr["NGAYTT"].ToString()));
            return svDTO;
        }
        public HopDongDTO Get_TRANGTHAI_For_TraCuuHD(string keyword)
        {
            DataTable dt = hopDongDAL.Get_TRANGTHAI_For_TraCuuHD(keyword.ToUpper());
            DataRow dr = dt.Rows[0];
            HopDongDTO svDTO = new HopDongDTO(
                dr["MAHOPDONG"].ToString(),
                int.Parse(dr["TRANGTHAI"].ToString()));
            return svDTO;
        }
        //public string Check_Tontai_PhanHoi(string tmp)
        //{
        //    return hopDongDAL.Check_Tontai_PhanHoi(tmp);
        //}
        public List<HopDongDTO> Get_All_For_TraCuuHD_NV()
        {
            DataTable dt = hopDongDAL.Get_All_For_TraCuuHD_NV();
            List<HopDongDTO> listHD = Utility.ToList<HopDongDTO>(dt);
            return listHD;
        }
        public List<HopDongDTO> Get_All_For_TraCuuHD_NV_SEARCH(string keyword)
        {
            DataTable dt = hopDongDAL.Get_All_For_TraCuuHD_NV_SEARCH(keyword.ToUpper());
            List<HopDongDTO> listHD = Utility.ToList<HopDongDTO>(dt);
            return listHD;
        }
        public int UpdateBaiDang(string mahd, string noidung)
        {

            if (string.IsNullOrEmpty(noidung))
            {
                MessageBox.Show("Mô tả không được để trống");
                return 3;
            }
            string resValue = hopDongDAL.UpdateBaiDang(mahd, noidung);
            if (resValue == "1")
                return 0;
            return 1;
            //return hopDongDAL.ThemDNPhanHoi(mahd, noidung);
        }
    }
}
