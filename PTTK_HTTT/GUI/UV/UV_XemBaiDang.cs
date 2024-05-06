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
            Load(chiTietTD);

        }
        private void Load(List<HopDongDTO> chiTietTD)
        {
            foreach (var array in chiTietTD)
            {
                ViTri.Text = array.VITRITD;
                NgayDang.Text = array.NGAYTD.ToString();
                NgayKetThuc.Text = array.NGAYTD.AddDays(array.THOIGIANTD).ToString();
                TenDN.Text = array.TENDN;
                SoLuong.Text = array.SOLUONGTD.ToString();
                CapBac.Text = array.CAPBACTD;
                DiaChi.Text = array.DIACHI;
                MoTa.Text = array.YEUCAU;
                KyNang.Text = array.KYNANG;
                LienHe.Text = array.EMAIL;
                MaHD = array.MAHOPDONG;
            }
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
