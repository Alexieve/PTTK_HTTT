using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DTO
{
    public class HoaDonDTO
    {
        string _MAHOADON;
        DateTime _NGAYTT;
        float _SOTIEN ;
        string _HINHTHUCTT ;
        string _NVTHANHTOAN ;
        string _MAHOPDONG ;
 

        public string MAHOADON { get => _MAHOADON; set => _MAHOADON = value; }
        public DateTime NGAYTT { get => _NGAYTT; set => _NGAYTT = value; }
        public float SOTIEN { get => _SOTIEN ; set => _SOTIEN  = value;}
        public string HINHTHUCTT { get => _HINHTHUCTT ; set => _HINHTHUCTT  = value;}
        public string NVTHANHTOAN { get => _NVTHANHTOAN ; set => _NVTHANHTOAN  = value;}
        public string MAHOPDONG { get => _MAHOPDONG ; set => _MAHOPDONG  = value;}

        public HoaDonDTO(string _MAHOADON, DateTime NGAYTT, float _SOTIEN, string _HINHTHUCTT, string _NVTHANHTOAN, string _MAHOPDONG)
        {
            this.MAHOADON = MAHOADON;
            this.NGAYTT = NGAYTT;
            this.SOTIEN = SOTIEN ;
            this.HINHTHUCTT = HINHTHUCTT ;
            this.NVTHANHTOAN = NVTHANHTOAN ;
            this.MAHOPDONG = MAHOPDONG;
        }

        public HoaDonDTO(float SOTIEN, string HINHTHUCTT, string MAHOPDONG)
        {
            this.MAHOADON = "";
            this.SOTIEN = SOTIEN;
            this.HINHTHUCTT = HINHTHUCTT;
            this.NVTHANHTOAN = "";
            this.MAHOPDONG = MAHOPDONG;
        }
        public HoaDonDTO()
        {
            this.MAHOADON = "";
            this.SOTIEN = -1;
            this.HINHTHUCTT = "";
            this.NVTHANHTOAN = "";
            this.MAHOPDONG = "";
        }
    }
}
