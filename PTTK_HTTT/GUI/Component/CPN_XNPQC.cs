using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace GUI
{
    public partial class CPN_XNPQC : UserControl
    {
        private string _kynang;
        private string _hinhthuc;
        private HopDongBLL _HopDongBLL;
        public CPN_XNPQC()
        {
            InitializeComponent();
            _HopDongBLL = new HopDongBLL();
        }
        public string Capbac
        { 
            set { tbCapbac.Text = value;}
        }
        public string Vitri
        {
            set { tbVitri.Text = value;}
        }
        public void KyNang(string kn)
        {
            string[] a = kn.Split(", ");
            richboxKyNang.Clear();
            foreach (string line in a)
            {
                richboxKyNang.AppendText(line + Environment.NewLine);
            }
        }
        public string kynang { set => _kynang = value; }
        public string Soluong
        {
            set { tbSoluong.Text = value;}
        }
        public string Yeucau
        {
            set { richboxYeucau.Text = value;}
        }
        public void HinhThuc(string ht)
        {
            string[] a = ht.Split(", ");
            richboxHinhThuc.Clear();
            foreach (string line in a)
            {
                richboxHinhThuc.AppendText(line + Environment.NewLine);
            }
        }
        public string hinhthuc { set => _hinhthuc = value;}
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
            string CAPBAC = tbCapbac.Text.Split('-')[0].Trim();
            string VITRITD = tbVitri.Text.Split('-')[0].Trim();
            string KYNANG = _kynang;
            int SOLUONG = int.Parse(tbSoluong.Text);
            string YEUCAU = richboxYeucau.Text;
            string HINHTHUC = _hinhthuc;
            int THOIGIANTD = int.Parse(tbThoigian.Text);
            DateTime NGAYTD = dtpkNgayTD.Value;
            string status = _HopDongBLL.Insert(CAPBAC, VITRITD, KYNANG, SOLUONG, YEUCAU, HINHTHUC, THOIGIANTD, NGAYTD);
            MessageBox.Show(status);
        }
    }
}
