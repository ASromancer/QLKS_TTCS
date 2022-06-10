using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtOldPass.Text != Program.password)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!");
                return;
            }

            string sql = "USE master " +
                         "ALTER LOGIN " + Program.manv + " WITH PASSWORD=N'" + txtNewPass.Text + "'";

            if(Program.ExecSqlNonQuery(sql) == 0 )
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                Program.frmChinh.btnLogout_ItemClick(sender, null);
                this.Dispose();
            }
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtLoginName.Text = Program.manv;
        }
    }
}
