using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace GUI
{
    public partial class CPN_CardTuyenDung : UserControl
    {
        public CPN_CardTuyenDung()
        {
            InitializeComponent();
        }
        public CPN_CardTuyenDung(HopDongDTO data)
        {
            InitializeComponent();
            MAHOPDONG = data.MAHOPDONG;
            ViTri = data.VITRITD;
            TenDoanhNghiep = data.TENDN;
            CapBacUngtuyen = data.CAPBACTD;
            DiaChiDN = data.DIACHI;
            KyNangUngTuyen = data.KYNANG;
        }
        #region Properties
        private string _MAHOPDONG;
        private string _ViTri;
        private string _KyNangUngTuyen;
        private string _DiaChiDN;
        private string _CapBacUngTuyen;
        private string _TenDoanhNghiep;
        //private string _MaDN;
        private Image _Avatar;

        [Category("Custom Props")]
        public string MAHOPDONG
        {
            get { return _MAHOPDONG; }
            set { _MAHOPDONG = value; MAHD.Text = value; }
        }
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
        //public string MaDN
        //{
        //    get { return _MaDN; }
        //    set { _MaDN = value; }
        //}

        #endregion

        private void Ava_Click(object sender, EventArgs e)
        {
            UV_Home uvHome = FindForm() as UV_Home;
            uvHome.openChildForm(new UV_XemBaiDang(MAHOPDONG));
        }
    }
}
