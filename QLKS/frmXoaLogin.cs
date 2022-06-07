using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class frmXoaLogin : Form
    {
        public frmXoaLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void xoaTatCaPhienDangNhap(string login)
        {
            //Để select thì cấp serveradmin cho login
            string sql = "SELECT session_id " +
                          "FROM sys.dm_exec_sessions " +
                          "WHERE login_name = '" + login + "'";
            SqlDataReader data = Program.ExecSqlDataReader(sql);
            List<int> sids = new List<int>();

            while(data.Read())
            {
                sids.Add(int.Parse(data.GetValue(0).ToString()));
            }

            data.Close();
            foreach (int sid in sids)
            {
                //Để xóa thì cấp processadmin cho login
                Program.ExecSqlNonQuery("KILL " + sid);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginname = cbxTK.SelectedValue.ToString();

            if(loginname == Program.manv)
            {
                MessageBox.Show("Không thể xóa tài khoản đang đăng nhập!");
                return;
            }

            xoaTatCaPhienDangNhap(loginname);

            string sql = "DROP LOGIN " + loginname +
                          "\n DROP USER " + loginname;

            if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản này ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Program.ExecSqlNonQuery(sql) == 0)
                {
                    MessageBox.Show("Xóa tài khoản thành công!");
                    this.Dispose();
                }
            }
                
        }

        private void layDSLogin()
        {
            string sql = "select name " +
                        "from sys.server_principals " +
                        "where name like 'NV%'";
            SqlCommand cmd = new SqlCommand(sql, Program.conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Program.conn.Close();

            cbxTK.DataSource = dt;
            cbxTK.DisplayMember = "name";
            cbxTK.ValueMember = "name";
        }

        private void frmXoaLogin_Load(object sender, EventArgs e)
        {
            layDSLogin();
        }
    }
}
