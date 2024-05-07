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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace GUI.DN
{
    public partial class MultiSelect : Form
    {
        private List<HinhThucDTO> listHinhThuc = null;
        private List<KyNangDTO> listKyNang = null;
        private List<string> chosen = null;
        public MultiSelect(List<HinhThucDTO> list, string title, string alreadyChosen)
        {
            InitializeComponent();
            listHinhThuc = list;
            lbTitle.Text = title;
            if(alreadyChosen != "")
                chosen = new List<string>(alreadyChosen.Split(','));
            else
                chosen = new List<string>();
            Load("MAHT", "Mã hình thức");
            foreach (HinhThucDTO item in list)
                if(!chosen.Contains(item.MAHT))
                    dtgviewLuaChon.Rows.Add(item.MAHT, item.MOTA, item.CHIPHITD);
                else
                    dtgviewDaChon.Rows.Add(item.MAHT, item.MOTA, item.CHIPHITD);
        }
        public MultiSelect(List<KyNangDTO> list, string title, string alreadyChosen)
        {
            InitializeComponent();
            listKyNang = list;
            lbTitle.Text = title;
            if (alreadyChosen != "")
                chosen = new List<string>(alreadyChosen.Split(','));
            else
                chosen = new List<string>();
            Load("MAKN", "Mã kỹ năng");
            foreach (KyNangDTO item in list)
                if (!chosen.Contains(item.MAKN))
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
            dtgviewLuaChon.AllowUserToAddRows = false;

            dtgviewDaChon.Columns.Add(ma, full);
            dtgviewDaChon.Columns.Add("MOTA", "Mô tả");
            dtgviewDaChon.Columns.Add("CHIPHITD", "Chi phí tuyển dụng");
            dtgviewDaChon.Columns[0].Visible = false;
            dtgviewDaChon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgviewDaChon.DefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Regular);
            dtgviewDaChon.AllowUserToAddRows = false;

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
                        chosen.Add(selectedRow.Cells[0].Value.ToString().Trim());
                        dtgviewLuaChon.Rows.RemoveAt(selectedRow.Index);
                        dtgviewDaChon.Rows.Add(selectedRow);
                    }
                }
                else if (dataGridView.Name == "dtgviewDaChon")
                {
                    if (dtgviewDaChon.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = dtgviewDaChon.SelectedRows[0];
                        chosen.Remove(selectedRow.Cells[0].Value.ToString().Trim());
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
            if (chosen == null || chosen.Count() == 0)
                return "";
            return string.Join(",", chosen);
        }

        public string getTextBox()
        {
            if (chosen == null || chosen.Count() == 0)
                return "";

            string tb = "";

            if (listHinhThuc != null)
                foreach (string i in chosen)
                    tb += (listHinhThuc.Where(s => s.MAHT.Contains(i)).ToList().First().MOTA + ", ");
            if (listKyNang != null)
                foreach (string i in chosen)
                    tb += (listKyNang.Where(s => s.MAKN.Contains(i)).ToList().First().MOTA + ", ");

            return tb.Substring(0, tb.Length - 2);
            
        }
    }
}
