using BLL;
using DTO;
using System;
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
    public partial class NV_XacThucHS_ChiTietHS : Form
    {
        private string MAHOPDONG;
        private string MAUV;
        private UngVienBLL ungVienBLL = new();
        private HSUngTuyenBLL hsUngTuyenBll = new();
        private GiayToBLL giayToBll = new();
        public NV_XacThucHS_ChiTietHS(string MAHOPDONG, string MAUV)
        {
            InitializeComponent();
            this.MAHOPDONG = MAHOPDONG;
            this.MAUV = MAUV;
            TitleLabel.Text = "Hồ sơ ứng viên " + MAUV + " của hợp đồng " + MAHOPDONG;
            Load_TT_UngVien();
            Load_TT_HSUngTuyen();
            Load_TT_GiayTo();
        }

        private void Load_TT_UngVien()
        {
            UngVienDTO uv = ungVienBLL.Get_TT_UngTuyen_By_MAUV(MAUV);
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
            hsUngTuyenBll.Update_KetQua(MAUV, MAHOPDONG, 2);
            MessageBox.Show("Xác thực thành công");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TuChoiBtn_Click(object sender, EventArgs e)
        {
            NV_PhanHoiHS modal = new NV_PhanHoiHS(MAUV, MAHOPDONG);
            modal.ShowDialog();
            if (modal.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Yêu cầu hiệu chỉnh thành công");
                this.Close();
            }
        }
    }
}
