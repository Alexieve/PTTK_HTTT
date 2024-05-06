using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HinhThucDTO
    {
        private string _MAHT;
        private string _MOTA;
        private float _CHIPHITD;
        public string MAHT { get => _MAHT; set => _MAHT = value; }
        public string MOTA { get => _MOTA; set => _MOTA = value; }
        public float CHIPHITD { get => _CHIPHITD; set => _CHIPHITD = value; }


        public HinhThucDTO(string MAHT, string MOTA, float CHIPHITD)
        {
            this.MAHT = MAHT;
            this.MOTA = MOTA;
            this.CHIPHITD = CHIPHITD;
        }
        public HinhThucDTO()
        {
            this.MAHT = "";
            this.MOTA = "";
            this.CHIPHITD = -1;
        }
    }
}
