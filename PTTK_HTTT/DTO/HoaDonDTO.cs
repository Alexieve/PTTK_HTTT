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
        int _SOTIEN ;
        string _HINHTHUCTT ;
        string _NVTHANHTOAN ;
        string _MAHOPDONG ;
 

        public string MAHOADON { get => _MAHOADON; set => _MAHOADON = value; }
        public DateTime NGAYTT { get => _NGAYTT; set => _NGAYTT = value; }
        public int SOTIEN { get => _SOTIEN ; set => _SOTIEN  = value;}
        public string HINHTHUCTT { get => _HINHTHUCTT ; set => _HINHTHUCTT  = value;}
        public string NVTHANHTOAN { get => _NVTHANHTOAN ; set => _NVTHANHTOAN  = value;}
        public string MAHOPDONG { get => _MAHOPDONG ; set => _MAHOPDONG  = value;}

        public HoaDonDTO(string _MAHOADON, DateTime NGAYTT, int _SOTIEN, string _HINHTHUCTT, string _NVTHANHTOAN, string _MAHOPDONG)
        {
            this._MAHOADON = MAHOADON;
            this._NGAYTT = NGAYTT;
            this._SOTIEN = SOTIEN ;
            this._HINHTHUCTT = HINHTHUCTT ;
            this._NVTHANHTOAN = NVTHANHTOAN ;
            this._MAHOPDONG = MAHOPDONG;
        }
        public HoaDonDTO()
        {
            this._MAHOADON = "";
            this._SOTIEN = -1;
            this._HINHTHUCTT = "";
            this._NVTHANHTOAN = "";
            this._MAHOPDONG = "";
        }
    }
}
