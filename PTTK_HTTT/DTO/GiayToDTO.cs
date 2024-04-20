using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiayToDTO
    {
        private string _MAHOPDONG;
        private string _LOAI;
        private string _NOIDUNG;

        public string MAHOPDONG { get => _MAHOPDONG; set => _MAHOPDONG = value; }
        public string LOAI { get => _LOAI; set => _LOAI = value; }
        public string NOIDUNG { get => _NOIDUNG; set => _NOIDUNG = value; }

        public GiayToDTO(string MAHOPDONG, string LOAI, string NOIDUNG)
        {
            this.MAHOPDONG = MAHOPDONG;
            this.LOAI = LOAI;
            this.NOIDUNG = NOIDUNG;
        }

        public GiayToDTO()
        {
            
        }
    }
}
