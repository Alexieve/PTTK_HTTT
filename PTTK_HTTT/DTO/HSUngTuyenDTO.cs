using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HSUngTuyenDTO
    {
        private string _MAUV;
        private string _MAHOPDONG;
        private string _TENDN;
        private string _HOTEN;
        private string _VITRI;
        private DateTime _NGAYNOP;
        private string _GIOITHIEU;
        private string _HOCVAN;
        private string _KINHNGHIEM;
        private string _KETQUA;
        public string MAUV { get => _MAUV; set => _MAUV = value; }
        public string MAHOPDONG { get => _MAHOPDONG; set => _MAHOPDONG = value; }
        public string TENDN { get => _TENDN; set => _TENDN = value; }
        public string HOTEN { get => _HOTEN; set => _HOTEN = value; }
        public string VITRI { get => _VITRI; set => _VITRI = value; }
        public DateTime NGAYNOP { get => _NGAYNOP; set => _NGAYNOP = value; }
        public string GIOITHIEU { get => _GIOITHIEU; set => _GIOITHIEU = value; }
        public string HOCVAN { get => _HOCVAN; set => _HOCVAN = value; }
        public string KINHNGHIEM { get => _KINHNGHIEM; set => _KINHNGHIEM = value; }
        public string KETQUA { get => _KETQUA; set => _KETQUA = value; }

        public HSUngTuyenDTO(string MAUV, string MAHOPDONG, string GIOITHIEU, string HOCVAN, string KINHNGHIEM)
        {
            this.MAUV = MAUV;
            this.MAHOPDONG = MAHOPDONG;
            this.GIOITHIEU = GIOITHIEU;
            this.HOCVAN = HOCVAN;
            this.KINHNGHIEM = KINHNGHIEM;
        }
        
        public HSUngTuyenDTO(string MAUV, string HOTEN, DateTime NGAYNOP, string KETQUA)
        {
            this.MAUV = MAUV;
            this.HOTEN = HOTEN;
            this.NGAYNOP = NGAYNOP;
            this.KETQUA = KETQUA;
        }

        public HSUngTuyenDTO()
        {
        }

        public HSUngTuyenDTO(string MAUV, string MAHOPDONG, string TENDN, string VITRI, DateTime NGAYNOP, string KETQUA)
        {
            this.MAUV = MAUV;
            this.MAHOPDONG = MAHOPDONG;
            this.TENDN = TENDN;
            this.VITRI = VITRI;
            this.NGAYNOP = NGAYNOP;
            this.KETQUA = KETQUA;
        }
    }

}
