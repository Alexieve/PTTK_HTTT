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
    public class DoanhNghiepBLL
    {
        private DoanhNghiepDAL doanhNghiepDAL = new();
        public DoanhNghiepBLL() { }

        public List<DoanhNghiepDTO> Get_List_DN_For_Xac_Thuc()
        {
            DataTable dt = doanhNghiepDAL.Get_List_DN_For_Xac_Thuc();
            List<DoanhNghiepDTO> listDN = Utility.ToList<DoanhNghiepDTO>(dt);
            return listDN;
        }

        public DoanhNghiepDTO Get_Detail(string MADN)
        {
            DataTable dt = doanhNghiepDAL.Get_Detail(MADN);
            DoanhNghiepDTO dn = Utility.ToObject<DoanhNghiepDTO>(dt.Rows[0]);
            return dn;
        }

        public void Delete(string MADN)
        {
            doanhNghiepDAL.Delete(MADN);
        }

        public string Xac_Thuc(DoanhNghiepDTO dn)
        {
            if (dn.TENDN == "")
            {
                return "Tên doanh nghiệp không được để trống";
            }
            else if (dn.MSTHUE == "")
            {
                return "Mã số thuế không được để trống";
            }
            else if (dn.NGDAIDIEN == "")
            {
                return "Người đại diện không được để trống";
            }
            else if (dn.DIACHI == "")
            {
                return "Địa chỉ không được để trống";
            }
            doanhNghiepDAL.Xac_Thuc(dn);
            return "";
        }
    }
}
