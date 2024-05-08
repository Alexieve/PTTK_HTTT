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
    public partial class UV_KetQuaHS : Form
    {
        private HSUngTuyenBLL hsUngTuyenBll = new();
        public UV_KetQuaHS()
        {
            InitializeComponent();
            Load();
            Make_Beauty();

            // Hide column 0 and 1
            KetQuaTb.Columns[0].Visible = false;
            KetQuaTb.Columns[1].Visible = false;
        }

        private void Load()
        {
            List<HSUngTuyenDTO> listHS = hsUngTuyenBll.Get_For_Ket_Qua_Ung_Tuyen();
            KetQuaTb.Rows.Clear();
            foreach (HSUngTuyenDTO hs in listHS)
            {
                KetQuaTb.Rows.Add(hs.MAUV, hs.MAHOPDONG, hs.TENDN, hs.VITRI, hs.NGAYNOP.ToString("dd/MM/yyyy"), hs.KETQUA);
            }
        }
        void Make_Beauty()
        {
            KetQuaTb.BorderStyle = BorderStyle.None;
            KetQuaTb.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            KetQuaTb.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            KetQuaTb.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            KetQuaTb.DefaultCellStyle.SelectionForeColor = Color.White;
            KetQuaTb.BackgroundColor = Color.White;

            KetQuaTb.EnableHeadersVisualStyles = false;
            KetQuaTb.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            KetQuaTb.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            KetQuaTb.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void XemCTHoSoBtn_Click(object sender, EventArgs e)
        {
            if (KetQuaTb.SelectedCells.Count == 0)
                return;
            int index = KetQuaTb.CurrentCell.RowIndex;
            string MAUV = KetQuaTb.Rows[index].Cells[0].Value.ToString();
            string MAHOPDONG = KetQuaTb.Rows[index].Cells[1].Value.ToString();
            string KETQUA = KetQuaTb.Rows[index].Cells[5].Value.ToString();
            var modal = new UV_KetQuaHS_ChiTietHS(MAUV, MAHOPDONG, KETQUA);

            if (KETQUA != "Cần hiệu chỉnh")
            {
                modal.HieuChinhBtn.Visible = false;
                modal.ThemGiayToBtn.Visible = false;
            }
            modal.ShowDialog();

            if (modal.DialogResult == DialogResult.OK)
            {
                Load();
            }
        }
    }
}
