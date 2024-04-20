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
    public partial class NV_DuyetHoSo_DSBaiDang : Form
    {
        private NV_DuyetHoSo duyetHoSoTab;
        private HopDongBLL hopDongBLL = new();
        public NV_DuyetHoSo_DSBaiDang(NV_DuyetHoSo duyetHoSoTab)
        {
            InitializeComponent();
            this.duyetHoSoTab = duyetHoSoTab;
            Load();
            Make_Beauty();
        }

        void Load()
        {
            List<HopDongDTO> listHD = hopDongBLL.Get_All_For_DuyetHS();
            BaiDangTb.Rows.Clear();
            foreach (HopDongDTO hd in listHD)
            {
                string ViTriTD = hd.CAPBACTD + " - " + hd.VITRITD;
                DateTime HanChotDuyet = hd.NGAYTD.AddDays(hd.THOIGIANTD + 10);
                BaiDangTb.Rows.Add(hd.MAHOPDONG,
                    ViTriTD, 
                    hd.SOLUONGHS,
                    HanChotDuyet.ToString("dd/MM/yyyy"));
            }
        }

        void Make_Beauty()
        {
            BaiDangTb.BorderStyle = BorderStyle.None;
            BaiDangTb.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            BaiDangTb.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BaiDangTb.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            BaiDangTb.DefaultCellStyle.SelectionForeColor = Color.White;
            BaiDangTb.BackgroundColor = Color.White;

            BaiDangTb.EnableHeadersVisualStyles = false;
            BaiDangTb.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            BaiDangTb.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            BaiDangTb.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            BaiDangTb.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void XemDSHoSoBtn_Click(object sender, EventArgs e)
        {
            if (BaiDangTb.SelectedCells.Count == 0)
                return;
            int index = BaiDangTb.CurrentCell.RowIndex;
            string MAHOPDONG = BaiDangTb.Rows[index].Cells[0].Value.ToString();
            duyetHoSoTab.openChildForm(new NV_DuyetHoSo_DSHoSo(MAHOPDONG));
        }
    }
}
