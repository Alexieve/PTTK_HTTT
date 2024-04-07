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
    public partial class PhanHoiHS_DSHoSo : Form
    {
        private PhanHoiHSTab phanHoiHsTab;
        public PhanHoiHS_DSHoSo(PhanHoiHSTab phanHoiHsTab)
        {
            InitializeComponent();
            addSample();
            this.phanHoiHsTab = phanHoiHsTab;
        }

        void addSample()
        {
            // add 2 state to combobox:  Đã đủ điều kiện, đã đạt
            KetQuaCbb.Items.Add("Đã đủ điều kiện");
            KetQuaCbb.Items.Add("Đã đạt");
            // set ketquaCbb to 0
            KetQuaCbb.SelectedIndex = 0;

            // Add some sample data to the DataGridView for each state
            if (KetQuaCbb.SelectedItem.ToString() == "Đã đủ điều kiện")
            {
                HoSoTb.Rows.Add("1", "Nguyễn Văn A", "12/12/2021", "Đã đủ điều kiện");
                HoSoTb.Rows.Add("2", "Nguyễn Văn B", "12/12/2021", "Đã đủ điều kiện");
                HoSoTb.Rows.Add("3", "Nguyễn Văn C", "12/12/2021", "Đã đủ điều kiện");
            }
            else
            {
                HoSoTb.Rows.Add("4", "Nguyễn Văn D", "12/12/2021", "Đã đạt");
                HoSoTb.Rows.Add("5", "Nguyễn Văn E", "12/12/2021", "Đã đạt");
                HoSoTb.Rows.Add("6", "Nguyễn Văn F", "12/12/2021", "Đã đạt");
            }
        }

        private void HoSoTb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PhanHoiHS_ChiTietHS phanHoiHSModal = new PhanHoiHS_ChiTietHS();
            phanHoiHSModal.ShowDialog();
        }
    }
}
