using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS.BUSLayer;
namespace GUI.UC
{
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        private void loadtodgv()
        {
            dgvPB.DataSource = BUS.xuat_NV();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            loadtodgv();
        }
    }
}
