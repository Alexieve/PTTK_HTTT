using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoanhNghiepDTO
    {
        private string _MADN;
        private string _TENDN;
        private string _MSTHUE;
        private string _NGDAIDIEN;
        private string _DIACHI;
        private string _SDT;
        private string _EMAIL;
        private int _TRANGTHAI;

        public string MADN { get => _MADN; set => _MADN = value; }
        public string TENDN { get => _TENDN; set => _TENDN = value; }
        public string MSTHUE { get => _MSTHUE; set => _MSTHUE = value; }
        public string NGDAIDIEN { get => _NGDAIDIEN; set => _NGDAIDIEN = value; }
        public string DIACHI { get => _DIACHI; set => _DIACHI = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string EMAIL { get => _EMAIL; set => _EMAIL = value; }
        public int TRANGTHAI { get => _TRANGTHAI; set => _TRANGTHAI = value; }

        public DoanhNghiepDTO()
        {
            this.MADN = "";
            this.TENDN = "";
            this.MSTHUE = "";
            this.NGDAIDIEN = "";
            this.DIACHI = "";
            this.SDT = "";
            this.EMAIL = "";
            this.TRANGTHAI = -1;
        }

        public DoanhNghiepDTO(string MADN, string TENDN, string MSTHUE, string NGDAIDIEN, string DIACHI, string SDT,
            string EMAIL, int TRANGTHAI)
        {
            this.MADN = MADN;
            this.TENDN = TENDN;
            this.MSTHUE = MSTHUE;
            this.NGDAIDIEN = NGDAIDIEN;
            this.DIACHI = DIACHI;
            this.SDT = SDT;
            this.EMAIL = EMAIL;
            this.TRANGTHAI = TRANGTHAI;
        }

        public DoanhNghiepDTO(DoanhNghiepDTO dn)
        {
            this.MADN = dn.MADN;
            this.TENDN = dn.TENDN;
            this.MSTHUE = dn.MSTHUE;
            this.NGDAIDIEN = dn.NGDAIDIEN;
            this.DIACHI = dn.DIACHI;
            this.SDT = dn.SDT;
            this.EMAIL = dn.EMAIL;
            this.TRANGTHAI = dn.TRANGTHAI;
        }

        public DoanhNghiepDTO(string tendn, string msthue, string ngdaidien, string diachi, string sdt, string email)
        {
            TENDN = tendn;
            MSTHUE = msthue;
            NGDAIDIEN = ngdaidien;
            DIACHI = diachi;
            SDT = sdt;
            EMAIL = email;
        }

        public DoanhNghiepDTO(string MADN, string TENDN, string MSTHUE, string NGDAIDIEN, string DIACHI)
        {
            this.MADN = MADN;
            this.TENDN = TENDN;
            this.MSTHUE = MSTHUE;
            this.NGDAIDIEN = NGDAIDIEN;
            this.DIACHI = DIACHI;
        }
    }
}
