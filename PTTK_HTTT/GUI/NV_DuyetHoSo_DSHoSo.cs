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

namespace GUI
{
    public partial class NV_DuyetHoSo_DSHoSo : Form
    {
        private NV_DuyetHoSo duyetHoSoTab;
        public NV_DuyetHoSo_DSHoSo(NV_DuyetHoSo duyetHoSoTab)
        {
            InitializeComponent();
            KetQuaCbb.Items.Add("Chưa duyệt");
            KetQuaCbb.Items.Add("Đủ điều kiện");
            KetQuaCbb.Items.Add("Không đủ điều kiện");
            KetQuaCbb.SelectedIndex = 0;
            this.duyetHoSoTab = duyetHoSoTab;
            addSampleData();
            DownBtn.Text = char.ConvertFromUtf32(0x2193);
            UpBtn.Text = char.ConvertFromUtf32(0x2191);



        }

        private void addSampleData()
        {
            HoSoTb.Rows.Add("HS001", "Nguyễn Văn A", "01/01/2021", "Chưa duyệt");
            HoSoTb.Rows.Add("HS002", "Nguyễn Văn B", "02/01/2021", "Chưa duyệt");
            HoSoTb.Rows.Add("HS003", "Nguyễn Văn C", "03/01/2021", "Chưa duyệt");
            HoSoTb.Rows.Add("HS004", "Nguyễn Văn D", "04/01/2021", "Chưa duyệt");
            HoSoTb.Rows.Add("HS005", "Nguyễn Văn E", "05/01/2021", "Chưa duyệt");

        }

        private void MoveRow(int moveStep)
        {
            if (HoSoTb.SelectedRows.Count == 1)
            {
                int currentIndex = HoSoTb.SelectedRows[0].Index;
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


        private void SortMode()
        {
            if (KetQuaCbb.SelectedIndex == 1)
            {
                SortLabel.Visible = true;
                UpBtn.Visible = true;
                DownBtn.Visible = true;
                SaveBtn.Visible = true;
                XemCTHoSoBtn.Visible = false;
            }
            else
            {
                SortLabel.Visible = false;
                UpBtn.Visible = false;
                DownBtn.Visible = false;
                SaveBtn.Visible = false;
                XemCTHoSoBtn.Visible = KetQuaCbb.SelectedIndex == 0;
            }
        }
        private void KetQuaCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortMode();
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
            if (KetQuaCbb.SelectedIndex == 0)
            {
                NV_DuyetHoSo_ChiTietHS modal = new NV_DuyetHoSo_ChiTietHS();
                modal.ShowDialog();
            }
        }
    }
}
