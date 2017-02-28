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
namespace GUI
{
    public partial class taotk : Form
    {
        public taotk()
        {
            InitializeComponent();
        }
       
        
        private void txttk_Click(object sender, EventArgs e)
        {
            txttk.Text = "";
            txtmk.Text = "";
        }

        private void btntaotk_Click(object sender, EventArgs e)
        {
            if ((txttk.Text == "") || (txtmk.Text == ""))
            {
                MessageBox.Show("Xin hãy Điền Đủ Thông Tin", "Thông Báo");
                return;
            }
            else
            {
                QLNS.ValueObject.TaiKhoan a = new QLNS.ValueObject.TaiKhoan();
                a.Acc = txttk.Text;
                a.Pass = txtmk.Text;
                if (BUS.them_TK(a) > 0)
                {
                    MessageBox.Show("Bạn Đã Tạo Tài Khoản Thành Công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bạn Đã Tạo Tài Khoản Thất Bại,Điền Lại Tài Khoản Và Mật Khẩu");
                    txttk.Text = "";
                    txtmk.Text = "";
                }
            }

        }

        private void btnthot_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
