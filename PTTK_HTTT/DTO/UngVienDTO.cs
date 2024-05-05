using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UngVienDTO
    {
        private string _MAUV;
        private string _HOTEN;
        private string _PHAI;
        private DateTime _NGAYSINH;
        private string _DIACHI;
        private string _SDT;
        private string _EMAIL;

        public string MAUV { get => _MAUV; set => _MAUV = value; }
        public string HOTEN { get => _HOTEN; set => _HOTEN = value; }
        public string PHAI { get => _PHAI; set => _PHAI = value; }
        public DateTime NGAYSINH { get => _NGAYSINH; set => _NGAYSINH = value; }
        public string DIACHI { get => _DIACHI; set => _DIACHI = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string EMAIL { get => _EMAIL; set => _EMAIL = value; }

        // init constuctor
        public UngVienDTO()
        {
            this.MAUV = "";
            this.HOTEN = "";
            this.PHAI = "";
            this.NGAYSINH = DateTime.Now;
            this.DIACHI = "";
            this.SDT = "";
            this.EMAIL = "";
        }

        public UngVienDTO(string MAUV, string HOTEN, string PHAI, DateTime NGAYSINH, string DIACHI, string SDT, string EMAIL)
        {
            this.MAUV = MAUV;
            this.HOTEN = HOTEN;
            this.PHAI = PHAI;
            this.NGAYSINH = NGAYSINH;
            this.DIACHI = DIACHI;
            this.SDT = SDT;
            this.EMAIL = EMAIL;
        }
        public UngVienDTO(UngVienDTO uv)
        {
            this.MAUV = uv.MAUV;
            this.HOTEN = uv.HOTEN;
            this.PHAI = uv.PHAI;
            this.NGAYSINH = uv.NGAYSINH;
            this.DIACHI = uv.DIACHI;
            this.SDT = uv.SDT;
            this.EMAIL = uv.EMAIL;
        }

        public UngVienDTO(string HOTEN, string PHAI, DateTime NGAYSINH, string DIACHI, string SDT, string EMAIL)
        {
            this.MAUV = "";
            this.HOTEN = HOTEN;
            this.PHAI = PHAI;
            this.NGAYSINH = NGAYSINH;
            this.DIACHI = DIACHI;
            this.SDT = SDT;
            this.EMAIL = EMAIL;
        }
    }
}
