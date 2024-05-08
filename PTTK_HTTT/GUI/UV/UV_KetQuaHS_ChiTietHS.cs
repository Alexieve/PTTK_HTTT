using BLL;
using DAL;
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
    public partial class UV_KetQuaHS_ChiTietHS : Form
    {
        private string MAUV;
        private string MAHOPDONG;
        private string KETQUA;
        private NVPhanHoiBLL nvPhanHoiBll  = new();
        private UngVienBLL ungVienBLL = new();
        private HSUngTuyenBLL hsUngTuyenBll = new();
        private GiayToBLL giayToBll = new();
        public UV_KetQuaHS_ChiTietHS(string MAUV, string MAHOPDONG, string KETQUA)
        {
            InitializeComponent();
            this.MAUV = MAUV;
            this.MAHOPDONG = MAHOPDONG;
            this.KETQUA = KETQUA;
            Load_PhanHoiNV();
            Load_TT_UngVien();
            Load_TT_HSUngTuyen();
            Load_TT_GiayTo();

            if (KETQUA != "Cần hiệu chỉnh")
            {
                GioiThieuBox.ReadOnly = true;
                HocVanBox.ReadOnly = true;
                KinhNghiemBox.ReadOnly = true;
            }
        }
        private void Load_PhanHoiNV()
        {
            PhanHoiBox.Text = nvPhanHoiBll.Get_New(MAUV, MAHOPDONG);
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
            if (KETQUA != "Cần hiệu chỉnh")
            {
                giayToCpn.DelGiayToBtn.Visible = false;
                giayToCpn.MoTaBox.ReadOnly = true;
            }
            giayToCpn.LoaiGTBox.ReadOnly = true;
            ParentPanel.Controls.Add(giayToCpn);
        }
        private void ThemGiayToBtn_Click(object sender, EventArgs e)
        {
            GiayToCpn giayToCpn = new GiayToCpn(MAHOPDONG);
            giayToCpn.Location = new Point(0, 0);
            giayToCpn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ParentPanel.Controls.Add(giayToCpn);
        }
        private HSUngTuyenDTO Check_HSUngTuyen()
        {
            string GIOITHIEU = GioiThieuBox.Text;
            string HOCVAN = HocVanBox.Text;
            string KINHNGHIEM = KinhNghiemBox.Text;
            HSUngTuyenDTO hsUngTuyenDTO = new HSUngTuyenDTO("", MAHOPDONG, GIOITHIEU, HOCVAN, KINHNGHIEM);
            string error = hsUngTuyenBll.checkValid(hsUngTuyenDTO);
            if (error != "")
            {
                MessageBox.Show(error);
                return null;
            }
            return hsUngTuyenDTO;
        }
        private List<Tuple<GiayToDTO, bool>> Check_GiayToUV()
        {
            List<GiayToDTO> listGiayTo = new List<GiayToDTO>();
            string error = "";
            foreach (Control control in ParentPanel.Controls)
            {
                if (control is GiayToCpn)
                {
                    GiayToDTO giayToDTO = (control as GiayToCpn).Get();
                    error = giayToBll.checkValid(giayToDTO);
                    if (error != "")
                    {
                        MessageBox.Show(error);
                        return null;
                    }
                    listGiayTo.Add(giayToDTO);
                }
            }
            error = giayToBll.checkDuplicate(listGiayTo);
            if (error != "")
            {
                MessageBox.Show(error);
                return null;
            }

            List<Tuple<GiayToDTO, bool>> listGiayToNew = new List<Tuple<GiayToDTO, bool>>();
            foreach (Control control in ParentPanel.Controls)
            {
                if (control is GiayToCpn)
                {
                    GiayToDTO giayToDTO = (control as GiayToCpn).Get();
                    bool isOld = (control as GiayToCpn).isOld;
                    listGiayToNew.Add(new Tuple<GiayToDTO, bool>(giayToDTO, isOld));
                }
            }

            return listGiayToNew;
        }
        private void HieuChinhBtn_Click(object sender, EventArgs e)
        {
            HSUngTuyenDTO hs = Check_HSUngTuyen();
            List<Tuple<GiayToDTO, bool>> listGiayTo = Check_GiayToUV();

            if (hs != null && listGiayTo != null)
            {
                hsUngTuyenBll.Update(hs);
                foreach (Tuple<GiayToDTO, bool> gt in listGiayTo)
                {
                    if (gt.Item2)
                    {
                        giayToBll.Update(gt.Item1);
                    }
                    else
                    {
                        giayToBll.Insert(gt.Item1);
                    }
                }
                MessageBox.Show("Hiệu chỉnh thành công");
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
