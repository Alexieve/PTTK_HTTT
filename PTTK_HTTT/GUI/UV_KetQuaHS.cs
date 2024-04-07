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
    public partial class UV_KetQuaHS : Form
    {
        public UV_KetQuaHS()
        {
            InitializeComponent();

            // add sample data to the DataGridView tên doanh nghiệp, tên vị trí, ngày nộp hồ sơ, trạng thái
            KetQuaTb.Rows.Add("Công ty ABC", "Software Engineer", "01/01/2021", "Đã đạt");
            KetQuaTb.Rows.Add("Công ty XYZ", "Data Engineer", "01/01/2021", "Không đạt");
            KetQuaTb.Rows.Add("Công ty DEF", "Data Analyst", "01/01/2021", "Đã đủ điều kiện");
            KetQuaTb.Rows.Add("Công ty GHI", "Software Engineer", "01/01/2021", "Chưa đủ điều kiện");
            KetQuaTb.Rows.Add("Công ty KLM", "Data Engineer", "01/01/2021", "Chưa duyệt");
            KetQuaTb.Rows.Add("Công ty NOP", "Data Analyst", "01/01/2021", "Cần hiệu chỉnh");
        }

        private void KetQuaTb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UV_KetQuaHS_ChiTietHS hieuChinhHSModal = new UV_KetQuaHS_ChiTietHS();
            hieuChinhHSModal.Show();
        }
    }
}
