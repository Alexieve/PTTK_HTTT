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
    public partial class DN_PhanHoiHS_DSHopDong : Form
    {
        private DN_PhanHoiHS phanHoiHsTab;
        private HopDongBLL hopDongBLL = new();
        public DN_PhanHoiHS_DSHopDong(DN_PhanHoiHS phanHoiHsTab)
        {
            InitializeComponent();
            this.phanHoiHsTab = phanHoiHsTab;
            Load();
            Make_Beauty();
        }
        void Load()
        {
            List<HopDongDTO> listHD = hopDongBLL.Get_All_For_PhanHoiHS();
            HopDongTb.Rows.Clear();
            foreach (HopDongDTO hd in listHD)
            {
                string ViTriTD = hd.CAPBACTD + " - " + hd.VITRITD;
                DateTime HanChotDuyet = hd.NGAYTD.AddDays(hd.THOIGIANTD + 10);
                HopDongTb.Rows.Add(hd.MAHOPDONG,
                    ViTriTD,
                    hd.SOLUONGHS,
                    HanChotDuyet.ToString("dd/MM/yyyy"));
            }
        }

        void Make_Beauty()
        {
            HopDongTb.BorderStyle = BorderStyle.None;
            HopDongTb.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            HopDongTb.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            HopDongTb.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            HopDongTb.DefaultCellStyle.SelectionForeColor = Color.White;
            HopDongTb.BackgroundColor = Color.White;

            HopDongTb.EnableHeadersVisualStyles = false;
            HopDongTb.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            HopDongTb.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            HopDongTb.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            HopDongTb.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void XemDSHoSoBtn_Click(object sender, EventArgs e)
        {
            if (HopDongTb.SelectedCells.Count == 0)
                return;
            int index = HopDongTb.CurrentCell.RowIndex;
            string MAHOPDONG = HopDongTb.Rows[index].Cells[0].Value.ToString();
            this.phanHoiHsTab.openChildForm(new DN_PhanHoiHS_DSHoSo(MAHOPDONG));
        }
    }
}
