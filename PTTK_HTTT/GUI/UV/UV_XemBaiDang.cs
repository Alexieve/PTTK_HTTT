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
using DTO;

namespace GUI
{
    public partial class UV_XemBaiDang : Form
    {
        private string MaHD;
        private HopDongBLL BaiDangTD;
        private HSUngTuyenBLL HSUngTuyen;
        public UV_XemBaiDang()
        {
            BaiDangTD = new HopDongBLL();
            HSUngTuyen = new HSUngTuyenBLL();
            InitializeComponent();
        }
        public UV_XemBaiDang(string MAHD)
        {
            BaiDangTD = new HopDongBLL();
            HSUngTuyen = new HSUngTuyenBLL();
            InitializeComponent();
            List<HopDongDTO> chiTietTD = BaiDangTD.Get_Detail_BaiDangTuyenDung(MAHD);
            Load(chiTietTD[0]);

        }
        private void Load(HopDongDTO chiTietTD)
        {
            ViTri.Text = chiTietTD.VITRITD;
            NgayDang.Text = chiTietTD.NGAYTD.ToString("dd/MM/yyyy");
            NgayKetThuc.Text = chiTietTD.NGAYTD.AddDays(chiTietTD.THOIGIANTD).ToString("dd/MM/yyyy");
            TenDN.Text = chiTietTD.TENDN;
            SoLuong.Text = chiTietTD.SOLUONGTD.ToString();
            CapBac.Text = chiTietTD.CAPBACTD;
            DiaChi.Text = chiTietTD.DIACHI;
            MoTa.Text = chiTietTD.YEUCAU;
            KyNang.Text = chiTietTD.KYNANG;
            LienHe.Text = chiTietTD.EMAIL;
            MaHD = chiTietTD.MAHOPDONG;
        }
        private void UngTuyenBtn_Click(object sender, EventArgs e)
        {
            if (HSUngTuyen.Check_Applied(MaHD))
            {
                MessageBox.Show("Bạn đã ứng tuyển của bài đăng này rồi!", "Thông báo");
                return;
            }
            else
            {
                ViTriUngTuyenDTO viTriUngTuyenDTO = new ViTriUngTuyenDTO(MaHD, TenDN.Text, CapBac.Text, ViTri.Text);
                UV_UngTuyenModal modal = new UV_UngTuyenModal(viTriUngTuyenDTO);
                modal.ShowDialog();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            UV_Home Parent = (UV_Home)this.Parent.Parent;
            Parent.closeChildForm();
        }

    }
}
