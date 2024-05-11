﻿using BLL;
using DTO;
using GUI.DN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace GUI
{
    public partial class CPN_LTTDT : UserControl
    {
        public event EventHandler btnSaveMain_click;
        private HinhThucBLL _HinhThucBLL = new HinhThucBLL();
        private KyNangBLL _KyNangBLL = new KyNangBLL();
        private ViTriBLL _ViTriBLL = new ViTriBLL();
        private CapBacBLL _CapBacBLL = new CapBacBLL();
        private List<HinhThucDTO> listHinhThuc;
        private List<KyNangDTO> listKyNang;
        private List<ViTriDTO> listViTri;
        private List<CapBacDTO> listCapBac;

        private string _kynang = "";
        private string _hinhthuc = "";
        private bool done = false;
        public CPN_LTTDT()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {

            listViTri = _ViTriBLL.getAll();
            cbboxVitri.DropDownHeight = 200;
            foreach (ViTriDTO item in listViTri)
                cbboxVitri.Items.Add(item.MAVT + " - " + item.MOTA);
            cbboxVitri.KeyPress += KeyPress;

            listCapBac = _CapBacBLL.getAll();
            cbboxCapbac.DropDownHeight = 200;
            foreach (CapBacDTO item in listCapBac)
                cbboxCapbac.Items.Add(item.MACB + " - " + item.MOTA);
            cbboxCapbac.KeyPress += KeyPress;

            listHinhThuc = _HinhThucBLL.getAll();
            tbHinhThuc.Click += MultiSelect;
            tbHinhThuc.KeyPress += KeyPress;

            listKyNang = _KyNangBLL.getAll();
            tbKyNang.Click += MultiSelect;
            tbKyNang.KeyPress += KeyPress;
        }

        private void MultiSelect(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Name == "tbHinhThuc")
                {
                    MultiSelect _MultiSelect = new MultiSelect(listHinhThuc, "Chọn Hình Thức", _hinhthuc);
                    _MultiSelect.StartPosition = FormStartPosition.CenterScreen;
                    _MultiSelect.ShowDialog();
                    textBox.Text = _MultiSelect.getTextBox();
                    _hinhthuc = _MultiSelect.getResult();
                }
                if (textBox.Name == "tbKyNang")
                {
                    MultiSelect _MultiSelect = new MultiSelect(listKyNang, "Chọn Kỹ Năng", _kynang);
                    _MultiSelect.StartPosition = FormStartPosition.CenterScreen;
                    _MultiSelect.ShowDialog();
                    textBox.Text = _MultiSelect.getTextBox();
                    _kynang = _MultiSelect.getResult();
                }
            }
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        public string Capbac { get => cbboxCapbac.Text; }
        public string Vitri { get => cbboxVitri.Text; }
        public string KyNang { get => tbKyNang.Text; }
        public string kynang { get => _kynang; }
        public string Soluong { get => nbSoluong.Value.ToString(); }
        public string Yeucau { get => richboxYeucau.Text; }
        public string HinhThuc { get => tbHinhThuc.Text; }
        public string hinhthuc { get => _hinhthuc; }
        public string ThoiGian { get => nbThoigian.Value.ToString(); }
        public DateTime NgayTD { get => dtpkNgayTD.Value; }
        public bool DONE { get => done; }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string errorMessage = KiemTraTT_DangTuyen();
            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage);
                return;
            }    
            MessageBox.Show("Lưu thành công");
            done = true;
            btnSaveMain_click?.Invoke(this, EventArgs.Empty);
        }

        private string KiemTraTT_DangTuyen()
        {
            if (cbboxCapbac.Text == "")
                return "Bạn chưa chọn cấp bậc tuyển dụng";
            if (cbboxVitri.Text == "")
                return "Bạn chưa chọn vị trí tuyển dụng";
            if (tbKyNang.Text == "")
                return "Bạn chưa chọn kỹ năng tuyển dụng";
            if (nbSoluong.Value == 0)
                return "Bạn chưa chọn số lượng tuyển dụng";
            if (richboxYeucau.Text == "")
                return "Bạn chưa điền yêu cầu tuyển dụng";
            if (tbHinhThuc.Text == "")
                return "Bạn chưa chọn hình thức tuyển dụng";
            if (nbThoigian.Value == 0)
                return "Bạn chưa chọn thời gian tuyển dụng";
            if(dtpkNgayTD.Value < DateTime.Now)
                return "Ngày tuyển dụng không hợp lệ";
            return "";
        }
    }
}
