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
    public partial class BLD_DeXuatUuDai : Form
    {
        public BLD_DeXuatUuDai()
        {
            InitializeComponent();
            AddSampleData();

        }

        private void AddSampleData()
        {
            DanhSachDNTN.Columns["ChienLuocUuDai"].DefaultCellStyle.BackColor = Color.LightGray;
            DanhSachDNTN.Rows.Add(false,1,"XX", 5, 5, "27/02/2024");
            DanhSachDNTN.Rows.Add(false,1,"XX", 5, 5, "27/02/2024");
            DanhSachDNTN.Rows.Add(false,1,"XX", 5, 5, "27/02/2024");
            DanhSachDNTN.Rows.Add(false, 1, "XX", 5, 5, "27/02/2024");
            DanhSachDNTN.Rows.Add(false, 1, "XX", 5, 5, "27/02/2024");
            DanhSachDNTN.Rows.Add(false, 1, "XX", 5, 5, "27/02/2024");
            DanhSachDNTN.Rows.Add(false, 1, "XX", 5, 5, "27/02/2024");
            DanhSachDNTN.Rows.Add(false, 1, "XX", 5, 5, "27/02/2024");
            DanhSachDNTN.Rows.Add(false, 1, "XX", 5, 5, "27/02/2024");
            DanhSachDNTN.Rows.Add(false, 1, "XX", 5, 5, "27/02/2024");

        }

        private void DanhSachDNTN_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == CheckBox.Index && e.RowIndex != -1)
            {
                // handle checkbox state change here
                int rowindex = e.RowIndex; // get the row index of the clicked checkbox
                if ((bool)DanhSachDNTN.Rows[rowindex].Cells["CheckBox"].Value == true)
                {
                    DanhSachDNTN.Rows[rowindex].Cells["ChienLuocUuDai"].Style.BackColor = Color.White;
                    DanhSachDNTN.Rows[rowindex].Cells["ChienLuocUuDai"].ReadOnly = false;
                }
                else
                {
                    DanhSachDNTN.Rows[rowindex].Cells["ChienLuocUuDai"].Style.BackColor = Color.LightGray;
                    DanhSachDNTN.Rows[rowindex].Cells["ChienLuocUuDai"].ReadOnly = true;
                }
            }
        }

        private void DanhSachDNTN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int rowIndex = e.RowIndex; // Get the row index of the clicked checkbox
            //if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            //    this.dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);

            ////Check the value of cell
            //if ((bool)this.dataGridView1.CurrentCell.Value == true)
            //{
            //    dataGridView1.Rows[rowIndex].Cells["ChienLuocUuDai"].Style.BackColor = Color.White;
            //}
            //else
            //{
            //    dataGridView1.Rows[rowIndex].Cells["ChienLuocUuDai"].Style.BackColor = Color.LightGray;

            //}
        }

        private void DanhSachDNTN_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == CheckBox.Index && e.RowIndex != -1)
            {
                DanhSachDNTN.EndEdit();
            }
        }

        private void DanhSachDNTN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == CheckBox.Index && e.RowIndex != -1)
            {
                DanhSachDNTN.EndEdit();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
