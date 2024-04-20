﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class GiayToCpn : UserControl
    {
        internal bool isOld;
        private string MAHOPDONG;
        public GiayToCpn(string MAHOPDONG)
        {
            InitializeComponent();
            isOld = false;
            this.MAHOPDONG = MAHOPDONG;
        }

        public GiayToCpn(string MAHOPDONG, string LOAI, string NOIDUNG)
        {
            InitializeComponent();
            LoaiGTBox.Text = LOAI;
            MoTaBox.Text = NOIDUNG;
            isOld = true;
            this.MAHOPDONG = MAHOPDONG;
        }

        public GiayToDTO Get()
        {
            string LOAI = LoaiGTBox.Text;
            string NOIDUNG = MoTaBox.Text;
            GiayToDTO giayToDTO = new GiayToDTO(MAHOPDONG, LOAI, NOIDUNG);
            return giayToDTO;
        }

        private void DelGiayToBtn_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
