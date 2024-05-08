using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DNPhanHoiDTO
    {
        private string _MAHOPDONG;
        private DateTime _NGAYPH;
        private string _NOIDUNG;



        public string MAHOPDONG { get => _MAHOPDONG; set => _MAHOPDONG = value; }
        public DateTime NGAYPH { get => _NGAYPH; set => _NGAYPH = value; }
        public string NOIDUNG { get => _NOIDUNG; set => _NOIDUNG = value; }

        public DNPhanHoiDTO()
        {
            this.MAHOPDONG = "";
            this.NGAYPH = DateTime.Now;
            this.NOIDUNG = "";
        }
        public DNPhanHoiDTO(DNPhanHoiDTO hd)
        {
            this.MAHOPDONG = hd.MAHOPDONG;
            this.NGAYPH = hd.NGAYPH;
            this.NOIDUNG = hd.NOIDUNG;
        }


        public DNPhanHoiDTO(string MAHOPDONG, DateTime NGAYPH, string NOIDUNG)
        {
            this.MAHOPDONG = MAHOPDONG;
            this.NGAYPH = NGAYPH;
            this.NOIDUNG = NOIDUNG;
        }
    }
}
