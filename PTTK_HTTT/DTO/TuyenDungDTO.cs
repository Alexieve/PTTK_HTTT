using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TuyenDungDTO
    {
        private string _MAHOPDONG;
        private string _MOTA;
        private string _TENDN;
        private string _CAPBAC;
        private string _DIACHI;
        private string _KYNANG;

        public string MAHOPDONG
        {
            get { return _MAHOPDONG; }
            set { _MAHOPDONG = value; }
        }
        public string MOTA
        {
            get { return _MOTA; }
            set { _MOTA = value; }
        }
        public string TENDN
        {
            get { return _TENDN; }
            set { _TENDN = value; }
        }
        public string CAPBAC
        {
            get { return _CAPBAC; }
            set { _CAPBAC = value; }
        }
        public string DIACHI
        {
            get { return _DIACHI; }
            set { _DIACHI = value; }
        }
        public string KYNANG
        {
            get { return _KYNANG; }
            set { _KYNANG = value; }
        }
        public TuyenDungDTO()
        {
            this.MAHOPDONG = "";
            this.MOTA = "";
            this.TENDN = "";
            this.CAPBAC = "";
            this.DIACHI = "";
            this.KYNANG = "";
        }
        public TuyenDungDTO(string MAHD ,string viTri, string tenDoanhNghiep, string capBac, string diaChi, string kyNang)
        {
            this.MAHOPDONG = MAHD;
            this.MOTA = viTri;
            this.TENDN = tenDoanhNghiep;
            this.CAPBAC = capBac;
            this.DIACHI = diaChi;
            this.KYNANG = kyNang;
        }   
    }
}
