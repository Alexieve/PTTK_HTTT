using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ViTriDTO
    {
        private string _MAVT;
        private string _MOTA;
        private float _CHIPHITD;
        public string MAVT { get => _MAVT; set => _MAVT = value; }
        public string MOTA { get => _MOTA; set => _MOTA = value; }
        public float CHIPHITD { get => _CHIPHITD; set => _CHIPHITD = value; }


        public ViTriDTO(string MAVT, string MOTA, float CHIPHITD)
        {
            this.MAVT = MAVT;
            this.MOTA = MOTA;
            this.CHIPHITD = CHIPHITD;
        }
        public ViTriDTO()
        {
            this.MAVT = "";
            this.MOTA = "";
            this.CHIPHITD = -1;
        }
    }
}
