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
    public partial class NV_TraCuuHD : Form
    {
        private Button currentButton;
        private Form activeForm = null;
        private HopDongBLL hdBLL;
        public NV_TraCuuHD()
        {
            InitializeComponent();
            hdBLL = new HopDongBLL();
            LoadData();
            Make_Beauty();
        }
        private string maHDToShow = "";
        private void LoadData()
        {
            List<HopDongDTO> listHD = hdBLL.Get_All_For_TraCuuHD_NV();
            GrantPrivTable.Rows.Clear();
            foreach (HopDongDTO hopDong in listHD)
            {
                string trangThai = hopDong.TRANGTHAI == 1 ? "Có" : "Không";
                GrantPrivTable.Rows.Add(
            hopDong.MAHOPDONG,
            hopDong.MADN,
            hopDong.TENDN,
            hopDong.TONGTIEN,
            hopDong.TIENCONLAI, trangThai
                );
            }
        }
        private void LoadData(string keyword)
        {
            List<HopDongDTO> listHD = hdBLL.Get_All_For_TraCuuHD_NV_SEARCH(keyword);
            GrantPrivTable.Rows.Clear();
            foreach (HopDongDTO hopDong in listHD)
            {
                GrantPrivTable.Rows.Add(
            hopDong.MAHOPDONG,
            hopDong.MADN,
            hopDong.TENDN,
            hopDong.TONGTIEN,
            hopDong.TIENCONLAI
                );
            }
        }
        void Make_Beauty()
        {
            GrantPrivTable.BorderStyle = BorderStyle.None;
            GrantPrivTable.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            GrantPrivTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GrantPrivTable.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            GrantPrivTable.DefaultCellStyle.SelectionForeColor = Color.White;
            GrantPrivTable.BackgroundColor = Color.White;

            GrantPrivTable.EnableHeadersVisualStyles = false;
            GrantPrivTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            GrantPrivTable.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            GrantPrivTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //GrantPrivTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
            openChildForm(new NV_TraCuuHD_DangBai());
            ActiveButton(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (maHDToShow != "")
            {
                openChildForm(new NV_TraCuuHD_XemBaiDang(maHDToShow));
                ActiveButton(sender);
            }
            else
            {
                // Hiển thị thông báo cho người dùng rằng họ cần chọn một dòng trước khi nhấp nút
                MessageBox.Show("Vui lòng chọn một dòng trước khi xem bài đăng.");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        private void GrantPrivTable_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu có ít nhất một dòng được chọn
            if (GrantPrivTable.SelectedRows.Count == 1)
            {
                // Lấy mã sinh viên từ dòng được chọn và lưu vào biến maSinhVienToShow
                maHDToShow = GrantPrivTable.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text);
        }
    }
}
