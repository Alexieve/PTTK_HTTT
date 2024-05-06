using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CapBacDTO
    {
        private string _MACB;
        private string _MOTA;
        private float _CHIPHITD;
        public string MACB { get => _MACB; set => _MACB = value; }
        public string MOTA { get => _MOTA; set => _MOTA = value; }
        public float CHIPHITD { get => _CHIPHITD; set => _CHIPHITD = value; }


        public CapBacDTO(string MACB, string MOTA, float CHIPHITD)
        {
            this.MACB = MACB;
            this.MOTA = MOTA;
            this.CHIPHITD = CHIPHITD;
        }
        public CapBacDTO()
        {
            this.MACB = "";
            this.MOTA = "";
            this.CHIPHITD = -1;
        }
    }
}
