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
    public partial class CPN_XNPQC : UserControl
    {
        public CPN_XNPQC()
        {
            InitializeComponent();
        }

        public string Capbac
        { 
            set { tbCapbac.Text = value;}
        }
        public string Vitri
        {
            set { tbVitri.Text = value;}
        }
        public string Soluong
        {
            set { tbSoluong.Text = value;}
        }
        public string Yeucau
        {
            set { richboxYeucau.Text = value;}
        }
        public string Hinhthuc
        {
            set { tbHinhthuc.Text = value;}
        }
        public string Thoigian
        {
            set { tbThoigian.Text = value;}
        }
        public DateTime NgayTD
        {
            set { dtpkNgayTD.Value = value;}
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {

        }
    }
}
