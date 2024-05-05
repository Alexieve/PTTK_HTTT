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
    public partial class UV_UngTuyenModal : Form
    {
        private string MAHOPDONG;
        private UngVienBLL ungVienBLL = new();
        private HSUngTuyenBLL hsUngTuyenBLL = new();
        private GiayToBLL giayToBLL = new();
        public UV_UngTuyenModal(ViTriUngTuyenDTO ViTriUT)
        {
            InitializeComponent();
            Load(ViTriUT);
        }
        private void Load(ViTriUngTuyenDTO ViTriUT)
        {
            MAHOPDONG = ViTriUT.MAHOPDONG;
            string Title = "Ứng tuyển cho vị trí " + ViTriUT.CAPBACTD + " - " + ViTriUT.VITRITD + " tại " + ViTriUT.TENDN;
            TitleLabel.Text = Title;
            UngVienDTO uv = ungVienBLL.Get_TT_UngTuyen_BY_MAUV("");
            NameBox.Text = uv.HOTEN;
            EmailBox.Text = uv.EMAIL;
            SDTBox.Text = uv.SDT;
        }
        private void UngTuyenBtn_Click(object sender, EventArgs e)
        {
            HSUngTuyenDTO hs = Check_HSUngTuyen();
            List<GiayToDTO> listGiayTo = Check_GiayToUV();
            
            if (hs != null && listGiayTo != null)
            {
                hsUngTuyenBLL.Insert(hs);
                giayToBLL.Insert(listGiayTo);
                MessageBox.Show("Ứng tuyển thành công");
                this.Close();
            }
        }

        private HSUngTuyenDTO Check_HSUngTuyen()
        {
            string GIOITHIEU = GioiThieuBox.Text;
            string HOCVAN = HocVanBox.Text;
            string KINHNGHIEM = KinhNghiemBox.Text;
            HSUngTuyenDTO hsUngTuyenDTO = new HSUngTuyenDTO("", MAHOPDONG, GIOITHIEU, HOCVAN, KINHNGHIEM);
            string error = hsUngTuyenBLL.checkValid(hsUngTuyenDTO);
            if (error != "")
            {
                MessageBox.Show(error);
                return null;
            }
            return hsUngTuyenDTO;
        }
        private List<GiayToDTO> Check_GiayToUV()
        {
            List<GiayToDTO> listGiayTo = new List<GiayToDTO>();
            string error = "";
            foreach (Control control in ParentPanel.Controls)
            {
                if (control is GiayToCpn)
                {
                    GiayToDTO giayToDTO = (control as GiayToCpn).Get();
                    error = giayToBLL.checkValid(giayToDTO);
                    if (error != "")
                    {
                        MessageBox.Show(error);
                        return null;
                    }
                    listGiayTo.Add(giayToDTO);
                }
            }
            error = giayToBLL.checkDuplicate(listGiayTo);
            if (error != "")
            {
                MessageBox.Show(error);
                return null;
            }

            return listGiayTo;
        }

        private void ThemGiayToBtn_Click(object sender, EventArgs e)
        {
            GiayToCpn giayToCpn = new GiayToCpn(MAHOPDONG);
            giayToCpn.Location = new Point(0, 0);
            giayToCpn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ParentPanel.Controls.Add(giayToCpn);

        }
    }
}
