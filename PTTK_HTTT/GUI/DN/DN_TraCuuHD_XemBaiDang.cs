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

    public partial class DN_TraCuuHD_XemBaiDang : Form
    {
        private DN_PhanHoiBaiDang phanHoiBaiDang;
        private XemPhanHoiBaiDang XemPhanHoiBaiDang;
        private Button currentButton;
        private Form activeForm = null;
        private HopDongBLL hdBLL = new HopDongBLL();
        private string mahd = "";
        private DateTime ngaybd;
        private DateTime ngaykt;
        public DN_TraCuuHD_XemBaiDang(string tmp)
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
            else
            {
                button1.Visible = false;
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
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;

            // Check if the current date is within the range of NGAYTD and NGAYTD plus THOIGIANTD
            if (currentDate >= ngaybd && currentDate <= ngaykt)
            {
                // Open the form if the current date is within the range
                if (phanHoiBaiDang == null || phanHoiBaiDang.IsDisposed)
                {
                    phanHoiBaiDang = new DN_PhanHoiBaiDang(mahd);
                    phanHoiBaiDang.StartPosition = FormStartPosition.CenterParent;
                }

                phanHoiBaiDang.ShowDialog();
            }
            else
            {
                // Show a message or take any other action if the current date is not within the range
                MessageBox.Show("Quá hạn phản hồi");
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new DN_TraCuuHD());
            ActiveButton(sender);
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
    }
}
