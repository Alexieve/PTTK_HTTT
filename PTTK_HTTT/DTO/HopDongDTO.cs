﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HopDongDTO
    {
        private string _MAHOPDONG;
        private string _MADN;
        private string _CAPBACTD;
        private string _VITRITD;
        private int _SOLUONGTD;
        private string _YEUCAU;
        private int _THOIGIANTD;
        private DateTime _NGAYTD;
        private DateTime _NGAYLAP;
        private int _TRANGTHAI;
        private float _TONGTIEN;
        private float _TIENCONLAI;
        private int _SOLUONGHS;

        public string MAHOPDONG { get => _MAHOPDONG; set => _MAHOPDONG = value; }
        public string MADN { get => _MADN; set => _MADN = value; }
        public string CAPBACTD { get => _CAPBACTD; set => _CAPBACTD = value; }
        public string VITRITD { get => _VITRITD; set => _VITRITD = value; }
        public int SOLUONGTD { get => _SOLUONGTD; set => _SOLUONGTD = value; }
        public string YEUCAU { get => _YEUCAU; set => _YEUCAU = value; }
        public int THOIGIANTD { get => _THOIGIANTD; set => _THOIGIANTD = value; }
        public DateTime NGAYTD { get => _NGAYTD; set => _NGAYTD = value; }
        public DateTime NGAYLAP { get => _NGAYLAP; set => _NGAYLAP = value; }
        public int TRANGTHAI { get => _TRANGTHAI; set => _TRANGTHAI = value; }
        public float TONGTIEN { get => _TONGTIEN; set => _TONGTIEN = value; }
        public float TIENCONLAI { get => _TIENCONLAI; set => _TIENCONLAI = value; }
        public int SOLUONGHS { get => _SOLUONGHS; set => _SOLUONGHS = value; }

        public HopDongDTO()
        {
            this.MAHOPDONG = "";
            this.MADN = "";
            this.CAPBACTD = "";
            this.VITRITD = "";
            this.SOLUONGTD = 0;
            this.YEUCAU = "";
            this.THOIGIANTD = 0;
            this.NGAYTD = DateTime.Now;
            this.NGAYLAP = DateTime.Now;
            this.TRANGTHAI = 0;
            this.TONGTIEN = 0;
            this.TIENCONLAI = 0;
            this.SOLUONGHS = 0;
        }

        public HopDongDTO(string MAHOPDONG, string MADN, string CAPBACTD, string VITRITD, int SOLUONGTD, string YEUCAU,
            int THOIGIANTD, DateTime NGAYTD, DateTime NGAYLAP, int TRANGTHAI, float TONGTIEN, float TIENCONLAI,
            int SOLUONGHS)
        {
            this.MAHOPDONG = MAHOPDONG;
            this.MADN = MADN;
            this.CAPBACTD = CAPBACTD;
            this.VITRITD = VITRITD;
            this.SOLUONGTD = SOLUONGTD;
            this.YEUCAU = YEUCAU;
            this.THOIGIANTD = THOIGIANTD;
            this.NGAYTD = NGAYTD;
            this.NGAYLAP = NGAYLAP;
            this.TRANGTHAI = TRANGTHAI;
            this.TONGTIEN = TONGTIEN;
            this.TIENCONLAI = TIENCONLAI;
            this.SOLUONGHS = SOLUONGHS;
        }

        public HopDongDTO(HopDongDTO hd)
        {
            this.MAHOPDONG = hd.MAHOPDONG;
            this.MADN = hd.MADN;
            this.CAPBACTD = hd.CAPBACTD;
            this.VITRITD = hd.VITRITD;
            this.SOLUONGTD = hd.SOLUONGTD;
            this.YEUCAU = hd.YEUCAU;
            this.THOIGIANTD = hd.THOIGIANTD;
            this.NGAYTD = hd.NGAYTD;
            this.NGAYLAP = hd.NGAYLAP;
            this.TRANGTHAI = hd.TRANGTHAI;
            this.TONGTIEN = hd.TONGTIEN;
            this.TIENCONLAI = hd.TIENCONLAI;
            this.SOLUONGHS = hd.SOLUONGHS;
        }
    }
}
