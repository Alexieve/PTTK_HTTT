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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace GUI
{
    public partial class XemPhanHoiBaiDang : Form
    {
        private HopDongBLL hdBLL = new HopDongBLL();
        public XemPhanHoiBaiDang(string tmp)
        {
            InitializeComponent();
            LoadData(tmp);
        }
        private void LoadData(string keyword)
        {
            HopDongDTO hdDTO = hdBLL.Get_PHANHOI_For_TraCuuHD_DN(keyword);
            DateTime ngayTD = hdDTO.NGAYPH;
            textBox4.Text = ngayTD.ToString("dd/MM/yyyy");
            textBox8.Text = hdDTO.NOIDUNG;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
