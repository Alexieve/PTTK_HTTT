using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;

namespace GUI
{
    public partial class NV_DuyetHoSo_ChiTietHS : Form
    {
        private string MAHOPDONG;
        private string MAUV;
        private HopDongBLL hopDongBll = new();
        private UngVienBLL ungVienBLL = new();
        private HSUngTuyenBLL hsUngTuyenBll = new();
        private GiayToBLL giayToBll = new();
        public NV_DuyetHoSo_ChiTietHS(string MAHOPDONG, string MAUV, string KETQUA)
        {
            InitializeComponent();
            this.MAHOPDONG = MAHOPDONG;
            this.MAUV = MAUV;
            if (KETQUA != "Đang chờ duyệt")
            {
                XacNhanBtn.Visible = false;
                TuChoiBtn.Visible = false;
            }
            TitleLabel.Text = "Hồ sơ ứng viên " + MAUV + " của hợp đồng " + MAHOPDONG;
            Load_YeuCauDN();
            Load_TT_UngVien();
            Load_TT_HSUngTuyen();
            Load_TT_GiayTo();
        }

        private void Load_YeuCauDN()
        {
            TieuChiDNBox.Text = hopDongBll.Get_YeuCauDN(MAHOPDONG);
        }

        private void Load_TT_UngVien()
        {
            UngVienDTO uv = ungVienBLL.Get_TT_UngTuyen_BY_MAUV(MAUV);
            NameBox.Text = uv.HOTEN;
            EmailBox.Text = uv.EMAIL;
            SDTBox.Text = uv.SDT;
        }
        private void Load_TT_HSUngTuyen()
        {
            HSUngTuyenDTO hs = hsUngTuyenBll.Get_ChiTiet_HSUngTuyen(MAUV, MAHOPDONG);
            GioiThieuBox.Text = hs.GIOITHIEU;
            HocVanBox.Text = hs.HOCVAN;
            KinhNghiemBox.Text = hs.KINHNGHIEM;
        }

        private void Load_TT_GiayTo()
        {
            List<GiayToDTO> listGT = giayToBll.Get_GiayTo_By_MAUV_MAHOPDONG(MAUV, MAHOPDONG);
            foreach (GiayToDTO gt in listGT)
            {
                AddGiayTo(gt.LOAI, gt.NOIDUNG);
            }
        }
        private void AddGiayTo(string LOAI, string NOIDUNG)
        {
            GiayToCpn giayToCpn = new GiayToCpn(MAHOPDONG, LOAI, NOIDUNG);
            giayToCpn.Location = new Point(0, 0);
            giayToCpn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            giayToCpn.DelGiayToBtn.Visible = false;
            giayToCpn.LoaiGTBox.ReadOnly = true;
            giayToCpn.MoTaBox.ReadOnly = true;
            ParentPanel.Controls.Add(giayToCpn);
        }

        private void XacNhanBtn_Click(object sender, EventArgs e)
        {
            hsUngTuyenBll.Update_KetQua(MAUV, MAHOPDONG, 4);
            MessageBox.Show("Duyệt thành công");
            this.Close();

        }

        private void TuChoiBtn_Click(object sender, EventArgs e)
        {
            hsUngTuyenBll.Update_KetQua(MAUV, MAHOPDONG, 3);
            MessageBox.Show("Duyệt thành công");
            this.Close();
        }
    }
}
