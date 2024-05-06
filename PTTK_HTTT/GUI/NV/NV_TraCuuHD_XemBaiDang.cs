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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GUI
{
    public partial class NV_TraCuuHD_XemBaiDang : Form
    {
        private NV_HieuChinhBaiDang NV_HieuChinhBaiDang;
        private XemPhanHoiBaiDang XemPhanHoiBaiDang;
        private Button currentButton;
        private Form activeForm = null;
        private HopDongBLL hdBLL = new HopDongBLL();
        private string mahd = "";
        private DateTime ngaybd;
        private DateTime ngaykt;
        public NV_TraCuuHD_XemBaiDang(string tmp)
        {
            InitializeComponent();
            LoadData(tmp);
            mahd = tmp;
            LoadCheck(tmp);
        }
        private void LoadCheck(string keyword)
        {
            string check_phanhoi = hdBLL.Check_Tontai_PhanHoi(keyword);
            if (check_phanhoi == "0")
            {
                button3.Visible = false;
            }

        }
        private void LoadData(string keyword)
        {
            HopDongDTO hdDTO = hdBLL.Get_BAIDANG_For_TraCuuHD_DN(keyword);
            DateTime ngayTD = hdDTO.NGAYTD;
            ngaybd = ngayTD;
            int thoiGianTD = hdDTO.THOIGIANTD;
            DateTime ngayTDPlusThoiGianTD = ngayTD.AddDays(thoiGianTD);
            ngaykt = ngayTDPlusThoiGianTD;
            textBox1.Text = hdDTO.VITRITD;
            textBox6.Text = ngayTD.ToString("dd/MM/yyyy");
            textBox7.Text = ngayTDPlusThoiGianTD.ToString("dd/MM/yyyy");
            textBox5.Text = hdDTO.TENDN;
            textBox4.Text = hdDTO.SOLUONGTD.ToString();
            textBox2.Text = hdDTO.CAPBACTD;
            textBox3.Text = hdDTO.DIACHI;
            textBox8.Text = hdDTO.YEUCAU;
            textBox9.Text = hdDTO.EMAIL;
            textBox10.Text = hdDTO.KYNANG;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new NV_TraCuuHD());
            ActiveButton(sender);
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.childFormPanel.Controls.Add(childForm);
            this.childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void ActiveButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                if (currentButton != (Button)senderBtn)
                {
                    DisableButton();
                    currentButton = (Button)senderBtn;
                    currentButton.BackColor = Color.FromArgb(128, 128, 128);
                }
            }
        }
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (NV_HieuChinhBaiDang == null || NV_HieuChinhBaiDang.IsDisposed)
            //{
            //    NV_HieuChinhBaiDang = new NV_HieuChinhBaiDang();
            //    NV_HieuChinhBaiDang.StartPosition = FormStartPosition.CenterParent;
            //}

            //NV_HieuChinhBaiDang.ShowDialog();
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
            textBox8.ReadOnly = false;
            button4.Location = new Point(780, 648);
            button5.Location = new Point(200, 648);
            label3.Text = "Hiệu chỉnh bài đăng";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (XemPhanHoiBaiDang == null || XemPhanHoiBaiDang.IsDisposed)
            {
                XemPhanHoiBaiDang = new XemPhanHoiBaiDang(mahd);
                XemPhanHoiBaiDang.StartPosition = FormStartPosition.CenterParent;
            }
            XemPhanHoiBaiDang.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int chec = hdBLL.UpdateBaiDang(mahd, textBox8.Text);
            if (chec == 1)
            {
                MessageBox.Show("Cập nhật bài đăng thành công.");
                openChildForm(new NV_TraCuuHD());
                ActiveButton(sender);
                //this.DialogResult = DialogResult.OK;
                //this.Close();
            }
            if (chec == 0) MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button1.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
            textBox8.ReadOnly = true;
            //button4.Location = new Point(780, 648);
            //button5.Location = new Point(200, 648);
            label3.Text = "Chi tiết bài đăng";
        }
    }
}
