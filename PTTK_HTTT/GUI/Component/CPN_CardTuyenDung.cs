﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CPN_CardTuyenDung : UserControl
    {
        public CPN_CardTuyenDung()
        {
            InitializeComponent();
        }
        #region Properties

        private string _ViTri;
        private string _KyNangUngTuyen;
        private string _DiaChiDN;
        private string _CapBacUngTuyen;
        private string _TenDoanhNghiep;
        private string _MaDN;
        private Image _Avatar;

        [Category("Custom Props")]
        public string ViTri
        {
            get { return _ViTri; }
            set { _ViTri = value; Title.Text = value; }
        }

        [Category("Custom Props")]
        public string TenDoanhNghiep
        {
            get { return _TenDoanhNghiep; }
            set { _TenDoanhNghiep = value; TenDN.Text = value; }
        }

        [Category("Custom Props")]
        public string CapBacUngtuyen
        {
            get { return _CapBacUngTuyen; }
            set { _CapBacUngTuyen = value; CapBac.Text = value; }
        }

        [Category("Custom Props")]
        public string DiaChiDN
        {
            get { return _DiaChiDN; }
            set { _DiaChiDN = value; DiaChi.Text = value; }
        }

        [Category("Custom Props")]
        public string KyNangUngTuyen
        {
            get { return _KyNangUngTuyen; }
            set { _KyNangUngTuyen = value; KyNang.Text = value; }
        }

        [Category("Custom Props")]
        public Image Avatar
        {
            get { return _Avatar; }
            set { _Avatar = value; Ava.Image = value; }
        }

        [Category("Custom Props")]
        public string MaDN
        {
            get { return _MaDN; }
            set { _MaDN = value; }
        }

        #endregion

        private void TenDN_Click(object sender, EventArgs e)
        {

        }

        private void DiaChi_Click(object sender, EventArgs e)
        {

        }

        private void CPN_CardTuyenDung_Load(object sender, EventArgs e)
        {

        }

        private void Ava_Click(object sender, EventArgs e)
        {

        }
    }
}
