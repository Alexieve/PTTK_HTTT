using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GUI.DN
{
    public partial class MultiSelect : Form
    {
        private List<HinhThucDTO> listHinhThuc = null;
        private List<KyNangDTO> listKyNang = null;
        private string chosen = "";
        public MultiSelect(List<HinhThucDTO> list, string title, string alreadyChosen)
        {
            InitializeComponent();
            listHinhThuc = list;
            lbTitle.Text = title;
            chosen = alreadyChosen == "" ? alreadyChosen : alreadyChosen + ", ";
            Load("MAHT", "Mã hình thức");
            foreach (HinhThucDTO item in list)
                if(!alreadyChosen.Contains(item.MAHT))
                    dtgviewLuaChon.Rows.Add(item.MAHT, item.MOTA, item.CHIPHITD);
                else
                    dtgviewDaChon.Rows.Add(item.MAHT, item.MOTA, item.CHIPHITD);
        }
        public MultiSelect(List<KyNangDTO> list, string title, string alreadyChosen)
        {
            InitializeComponent();
            listKyNang = list;
            lbTitle.Text = title;
            chosen = alreadyChosen == "" ? alreadyChosen : alreadyChosen + ", ";
            Load("MAKN", "Mã kỹ năng");
            foreach (KyNangDTO item in list)
                if (!alreadyChosen.Contains(item.MAKN))
                    dtgviewLuaChon.Rows.Add(item.MAKN, item.MOTA, item.CHIPHITD);
                else
                    dtgviewDaChon.Rows.Add(item.MAKN, item.MOTA, item.CHIPHITD);
        }
        private void Load(string ma, string full)
        {

            dtgviewLuaChon.Columns.Add(ma, full);
            dtgviewLuaChon.Columns.Add("MOTA", "Mô tả");
            dtgviewLuaChon.Columns.Add("CHIPHITD", "Chi phí tuyển dụng");
            dtgviewLuaChon.Columns[0].Visible = false;
            dtgviewLuaChon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgviewLuaChon.DefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Regular);


            dtgviewDaChon.Columns.Add(ma, full);
            dtgviewDaChon.Columns.Add("MOTA", "Mô tả");
            dtgviewDaChon.Columns.Add("CHIPHITD", "Chi phí tuyển dụng");
            dtgviewDaChon.Columns[0].Visible = false;
            dtgviewDaChon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgviewDaChon.DefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Regular);

            dtgviewLuaChon.SelectionChanged += dtgview_SelectionChanged;
            dtgviewDaChon.SelectionChanged += dtgview_SelectionChanged;
        }
        private void dtgview_SelectionChanged(object sender, EventArgs e)
        {
            if (sender is DataGridView dataGridView)
            {
                if (dataGridView.Name == "dtgviewLuaChon")
                {
                    if (dtgviewLuaChon.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = dtgviewLuaChon.SelectedRows[0];
                        chosen += selectedRow.Cells[0].Value.ToString().Trim() + ",";
                        dtgviewLuaChon.Rows.RemoveAt(selectedRow.Index);
                        dtgviewDaChon.Rows.Add(selectedRow);
                    }
                }
                else if (dataGridView.Name == "dtgviewDaChon")
                {
                    if (dtgviewDaChon.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = dtgviewDaChon.SelectedRows[0];
                        chosen = chosen.Replace(selectedRow.Cells[0].Value.ToString().Trim() + ",", "");
                        dtgviewDaChon.Rows.RemoveAt(selectedRow.Index);
                        dtgviewLuaChon.Rows.Add(selectedRow);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string getResult()
        {
            if(chosen != "")
                return chosen.Substring(0, chosen.Length - 1);
            else return chosen;
        }

        public string getTextBox()
        {
            if (chosen != "")
            {
                string tb = "";
                string[] a = chosen.Substring(0, chosen.Length - 1).Split(",");

                if (listHinhThuc != null)
                    foreach (string i in a)
                        tb += (listHinhThuc.Where(s => s.MAHT.Contains(i)).ToList().First().MOTA + ", ");
                if (listKyNang != null)
                    foreach (string i in a)
                        tb += (listKyNang.Where(s => s.MAKN.Contains(i)).ToList().First().MOTA + ", ");

                return tb.Substring(0, tb.Length - 2);
            }
            else return chosen;
        }
    }
}
