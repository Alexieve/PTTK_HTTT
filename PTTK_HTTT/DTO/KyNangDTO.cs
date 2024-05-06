using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KyNangDTO
    {
        private string _MAKN;
        private string _MOTA;
        private float _CHIPHITD;
        public string MAKN { get => _MAKN; set => _MAKN = value; }
        public string MOTA { get => _MOTA; set => _MOTA = value; }
        public float CHIPHITD { get => _CHIPHITD; set => _CHIPHITD = value; }


        public KyNangDTO(string MAKN, string MOTA, float CHIPHITD)
        {
            this.MAKN = MAKN;
            this.MOTA = MOTA;
            this.CHIPHITD = CHIPHITD;
        }
        public KyNangDTO()
        {
            this.MAKN = "";
            this.MOTA = "";
            this.CHIPHITD = -1;
        }
    }
}
