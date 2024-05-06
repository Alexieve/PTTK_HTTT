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
    public partial class NV_XacThucHS : Form
    {
        private HSUngTuyenBLL hsUngTuyenBll = new();
        public NV_XacThucHS()
        {
            InitializeComponent();
            Load_Table();
            Make_Beauty();
        }

        private void Load_Table()
        {
            List<HSUngTuyenDTO> listHS = hsUngTuyenBll.Get_For_Xac_Thuc_HS();
            HoSoTb.Rows.Clear();
            foreach (HSUngTuyenDTO hs in listHS)
            {
                HoSoTb.Rows.Add(hs.MAUV, hs.HOTEN, hs.NGAYNOP.ToString("dd/MM/yyyy"), hs.MAHOPDONG);
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
        private void XemCTBtn_Click(object sender, EventArgs e)
        {
            if (HoSoTb.SelectedCells.Count == 0)
                return;
            int index = HoSoTb.CurrentCell.RowIndex;
            string MAUV = HoSoTb.Rows[index].Cells[0].Value.ToString();
            string MAHOPDONG = HoSoTb.Rows[index].Cells[3].Value.ToString();
            NV_XacThucHS_ChiTietHS modal = new NV_XacThucHS_ChiTietHS(MAHOPDONG, MAUV);
            modal.ShowDialog();
            if (modal.DialogResult == DialogResult.OK)
                Load_Table();
        }
    }
}
