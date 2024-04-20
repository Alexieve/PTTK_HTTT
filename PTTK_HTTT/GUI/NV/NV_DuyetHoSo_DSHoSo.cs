using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class NV_DuyetHoSo_DSHoSo : Form
    {
        private HSUngTuyenBLL hsUngTuyenBll = new();
        private string MAHOPDONG;
        public NV_DuyetHoSo_DSHoSo(string MAHOPDONG)
        {
            InitializeComponent();
            LoadKetQuaCbb();
            this.MAHOPDONG = MAHOPDONG;
            Load_Table("Đang chờ duyệt");
            Make_Beauty();
            DownBtn.Text = char.ConvertFromUtf32(0x2193);
            UpBtn.Text = char.ConvertFromUtf32(0x2191);
        }

        private void LoadKetQuaCbb()
        {
            KetQuaCbb.Items.Add("Đang chờ duyệt");
            KetQuaCbb.Items.Add("Cần sắp xếp độ ưu tiên");
            KetQuaCbb.Items.Add("Không đủ điều kiện");
            KetQuaCbb.SelectedIndex = 0;
        }

        private void Load_Table(string KETQUA)
        {
            int ketqua;
            if (KETQUA == "Đang chờ duyệt")
            { ketqua = 2; }
            else if (KETQUA == "Cần sắp xếp độ ưu tiên")
            { ketqua = 4; }
            else
            { ketqua = 3; }
            List<HSUngTuyenDTO> listHS = hsUngTuyenBll.Get_For_DuyetHS_By_KetQua(MAHOPDONG, ketqua);
            HoSoTb.Rows.Clear();
            foreach (HSUngTuyenDTO hs in listHS)
            {
                HoSoTb.Rows.Add(hs.MAUV, hs.HOTEN, hs.NGAYNOP.ToString("dd/MM/yyyy"), hs.KETQUA);
            }
        }

        void Make_Beauty()
        {
            HoSoTb.BorderStyle = BorderStyle.None;
            HoSoTb.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            HoSoTb.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            HoSoTb.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            HoSoTb.DefaultCellStyle.SelectionForeColor = Color.White;
            HoSoTb.BackgroundColor = Color.White;

            HoSoTb.EnableHeadersVisualStyles = false;
            HoSoTb.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            HoSoTb.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            HoSoTb.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void MoveRow(int moveStep)
        {
            if (HoSoTb.SelectedCells.Count != 0)
            {
                int currentIndex = HoSoTb.SelectedCells[0].OwningRow.Index;
                int targetIndex = currentIndex + moveStep;

                if (targetIndex >= 0 && targetIndex < HoSoTb.Rows.Count)
                {
                    DataGridViewRow row = HoSoTb.Rows[currentIndex];
                    HoSoTb.Rows.RemoveAt(currentIndex);
                    HoSoTb.Rows.Insert(targetIndex, row);
                    HoSoTb.ClearSelection();
                    HoSoTb.Rows[targetIndex].Selected = true;
                }
            }
        }


        private void ChangeMode()
        {
            if (KetQuaCbb.SelectedIndex == 1)
            {
                SortLabel.Visible = true;
                UpBtn.Visible = true;
                DownBtn.Visible = true;
                SaveBtn.Visible = true;
                XemCTHoSoBtn.Location = new Point(960, 8);
                XemCTHoSoBtn.Size = new Size(81, 37);

            }
            else
            {
                SortLabel.Visible = false;
                UpBtn.Visible = false;
                DownBtn.Visible = false;
                SaveBtn.Visible = false;
                XemCTHoSoBtn.Location = new Point(793, 8);
                XemCTHoSoBtn.Size = new Size(248, 37);

            }
        }
        private void KetQuaCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeMode();
            Load_Table(KetQuaCbb.SelectedItem.ToString());
        }
        private void DownBtn_Click(object sender, EventArgs e)
        {
            MoveRow(1);
        }
        private void UpBtn_Click(object sender, EventArgs e)
        {
            MoveRow(-1);
        }

        private void XemCTHoSoBtn_Click(object sender, EventArgs e)
        {
            if (HoSoTb.SelectedCells.Count == 0)
                return;
            int index = HoSoTb.CurrentCell.RowIndex;
            string MAUV = HoSoTb.Rows[index].Cells[0].Value.ToString();
            string KETQUA = HoSoTb.Rows[index].Cells[3].Value.ToString();
            var modal = new NV_DuyetHoSo_ChiTietHS(MAHOPDONG, MAUV, KETQUA);

            if (KetQuaCbb.SelectedIndex > 0)
            {
                modal.XacNhanBtn.Visible = false;
                modal.TuChoiBtn.Visible = false;
            }
            modal.ShowDialog();
            Load_Table(KetQuaCbb.SelectedItem.ToString());
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (HoSoTb.Rows.Count == 0)
            {
                MessageBox.Show("Không có hồ sơ nào để lưu");
                return;
            }
            for (int i = 0; i < HoSoTb.Rows.Count; i++)
            {
                string MAUV = HoSoTb.Rows[i].Cells[0].Value.ToString();
                hsUngTuyenBll.Update_DoUuTien(MAUV, MAHOPDONG, i + 1);
            }
            MessageBox.Show("Đã lưu thứ tự ưu tiên");
        }
    }
}
