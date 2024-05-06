using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NVPhanHoiDTO
    {
        private string _MAUV;
        private string _MAHOPDONG;
        private DateTime _NGAYPH;
        private string _NOIDUNG;

        public string MAUV { get => _MAUV; set => _MAUV = value; }
        public string MAHOPDONG { get => _MAHOPDONG; set => _MAHOPDONG = value; }
        public DateTime NGAYPH { get => _NGAYPH; set => _NGAYPH = value; }
        public string NOIDUNG { get => _NOIDUNG; set => _NOIDUNG = value; }
        public NVPhanHoiDTO() { }

        public NVPhanHoiDTO(string MAUV, string MAHOPDONG, DateTime NGAYPH, string NOIDUNG)
        {
            this.MAUV = MAUV;
            this.MAHOPDONG = MAHOPDONG;
            this.NGAYPH = NGAYPH;
            this.NOIDUNG = NOIDUNG;
        }

        public NVPhanHoiDTO(string mauv, string mahopdong, string noidung)
        {
            this.MAUV = mauv;
            this.MAHOPDONG = mahopdong;
            this.NGAYPH = DateTime.Now;
            this.NOIDUNG = noidung;
        }
    }
}
