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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GUI
{
    public partial class NV_ThanhToan : Form
    {
        HoaDonBLL _HoaDonBLL;
        HopDongBLL _HopDongBLL;
        HopDongDTO _HopDongDTO;
        public NV_ThanhToan()
        {
            InitializeComponent();
            _HoaDonBLL = new HoaDonBLL();
            _HopDongBLL = new HopDongBLL();
        }

        private void btnTimBai_Click(object sender, EventArgs e)
        {
            _HopDongDTO = null;
            _HopDongDTO = _HopDongBLL.Find_BY_MAHOPDONG(tbMAHOPDONG.Text);
            if (_HopDongDTO != null)
            {
                tbTongTien.Text = _HopDongDTO.TONGTIEN.ToString();
                tbConLai.Text = _HopDongDTO.TIENCONLAI.ToString();
                dtgHoaDon.DataSource = null;
            }
            else
            {
                MessageBox.Show("Không tìm thấy hợp đồng");
                return;
            }
            List<HoaDonDTO> list = _HoaDonBLL.GET_BY_MAHOPDONG(tbMAHOPDONG.Text);
            if (list.Count() != 0)
            {
                dtgHoaDon.DataSource = list;
                dtgHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgHoaDon.Columns[0].HeaderText = "Mã Hóa Đơn";
                dtgHoaDon.Columns[1].HeaderText = "Ngày Thanh Toán";
                dtgHoaDon.Columns[2].HeaderText = "Số Tiền";
                dtgHoaDon.Columns[3].HeaderText = "Hình Thức Thanh Toán";
                dtgHoaDon.Columns[4].HeaderText = "Nhân Viên Thanh Toán";
                dtgHoaDon.Columns[5].Visible = false;
                tbSoLan.Text = list.Count.ToString();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (_HopDongDTO == null)
            {
                MessageBox.Show("Vui lòng chọn hợp đồng hợp lệ");
                return;
            }

            if (!rbtnTTToanBo.Checked && !rbtnTT30.Checked)
            {
                MessageBox.Show("Vui lòng chọn mức thanh toán");
                return;
            }

            if (!rbtnTienMat.Checked && !rbtnThe.Checked)
            {
                MessageBox.Show("Vui lòng chọn loại thanh toán");
                return;
            }

            if (_HopDongDTO.TIENCONLAI == 0)
            {
                MessageBox.Show("Hợp đồng đã thanh toán toàn bộ số tiền");
                return;
            }

            float SOTIEN = -1;
            if (rbtnTT30.Checked)
            {
                if (_HopDongDTO.THOIGIANTD > 30)
                {
                    if (_HopDongDTO.TIENCONLAI >= _HopDongDTO.TONGTIEN * 0.3)
                        SOTIEN = (float)(_HopDongDTO.TONGTIEN * 0.3);
                }
                if (SOTIEN == -1)
                {
                    MessageBox.Show("Thanh toán mức 30% không khả thi vì số ngày tuyển dụng không hơn 30 ngày");
                    return;
                }
            }    
            else
            {

                SOTIEN = (float)(_HopDongDTO.TIENCONLAI);
            }
            string MAHOPDONG = tbMAHOPDONG.Text;
            string HINHTHUCTT = rbtnTienMat.Checked ? "Tiền mặt" : "Thẻ";
            HoaDonDTO _HoaDonDTO = new HoaDonDTO(SOTIEN, HINHTHUCTT, MAHOPDONG);
            string status = _HoaDonBLL.THANH_TOAN(_HoaDonDTO);
            MessageBox.Show(status);
            btnTimBai_Click(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
        }
    }
}
