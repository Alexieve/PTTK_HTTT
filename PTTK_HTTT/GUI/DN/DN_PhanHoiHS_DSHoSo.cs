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
    public partial class DN_PhanHoiHS_DSHoSo : Form
    {
        private HSUngTuyenBLL hsUngTuyenBll = new();
        private string MAHOPDONG;
        public DN_PhanHoiHS_DSHoSo(string MAHOPDONG)
        {
            InitializeComponent();
            LoadKetQuaCbb();
            this.MAHOPDONG = MAHOPDONG;
            Load_Table("Đang chờ phản hồi");
            Make_Beauty();
        }

        private void LoadKetQuaCbb()
        {
            KetQuaCbb.Items.Add("Đang chờ phản hồi");
            KetQuaCbb.Items.Add("Đã đạt");
            KetQuaCbb.SelectedIndex = 0;
        }

        private void Load_Table(string KETQUA)
        {
            int ketqua;
            if (KETQUA == "Đang chờ phản hồi")
            { ketqua = 4; }
            else
            { ketqua = 6; };

            List<HSUngTuyenDTO> listHS = hsUngTuyenBll.Get_For_PhanHoiHS_By_KetQua(MAHOPDONG, ketqua);
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
        private void KetQuaCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Table(KetQuaCbb.SelectedItem.ToString());
        }
        private void XemCTHoSoBtn_Click(object sender, EventArgs e)
        {
            if (HoSoTb.SelectedCells.Count == 0)
                return;
            int index = HoSoTb.CurrentCell.RowIndex;
            string MAUV = HoSoTb.Rows[index].Cells[0].Value.ToString();
            string KETQUA = HoSoTb.Rows[index].Cells[3].Value.ToString();
            var modal = new DN_PhanHoiHS_ChiTietHS(MAHOPDONG, MAUV, KETQUA);

            if (KetQuaCbb.SelectedIndex > 0)
            {
                modal.XacNhanBtn.Visible = false;
                modal.TuChoiBtn.Visible = false;
            }
            modal.ShowDialog();
            Load_Table(KetQuaCbb.SelectedItem.ToString());
        }
    }
}
