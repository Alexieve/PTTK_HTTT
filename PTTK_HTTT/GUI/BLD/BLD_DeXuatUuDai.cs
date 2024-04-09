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
    public partial class BLD_DeXuatUuDai : Form
    {
        public BLD_DeXuatUuDai()
        {
            InitializeComponent();
            addSampleData();

        }

        private void addSampleData()
        {
            dataGridView1.Rows.Add(false, "XX", 5, 5, "27/02/2024");
            dataGridView1.Rows.Add(false, "XX", 5, 5, "27/02/2024");
            dataGridView1.Rows.Add(false, "XX", 5, 5, "27/02/2024");
            dataGridView1.Rows.Add(false, "XX", 5, 5, "27/02/2024");
            dataGridView1.Rows.Add(false, "XX", 5, 5, "27/02/2024");
            dataGridView1.Rows.Add(false, "XX", 5, 5, "27/02/2024");
            dataGridView1.Rows.Add(false, "XX", 5, 5, "27/02/2024");
            dataGridView1.Rows.Add(false, "XX", 5, 5, "27/02/2024");
            dataGridView1.Rows.Add(false, "XX", 5, 5, "27/02/2024");
            dataGridView1.Rows.Add(false, "XX", 5, 5, "27/02/2024");

        }
    }
}
