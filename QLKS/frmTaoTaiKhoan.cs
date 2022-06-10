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
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if(txtMaNV.Text == "")
            {
                MessageBox.Show("Chưa chọn mã NV");
                btnChonMaNV.Focus();
                return;
            }

            string sql = "CREATE LOGIN " + txtLoginName.Text + " WITH PASSWORD = N'123', " +
                            "default_database = master, " +
                            "check_expiration = off, " +
                            "check_policy = off ";

            sql += ("\nCREATE USER " + txtLoginName.Text + " FOR LOGIN " + txtLoginName.Text);

            sql += ("\nEXEC sp_addrolemember '" + cbxVaiTro.SelectedValue.ToString() + "', N'" + txtLoginName.Text + "'");

            /*if(cbxVaiTro.SelectedValue.ToString() == "QUANLY" || cbxVaiTro.SelectedValue.ToString() == "NHANVIEN")
            {
                
            }*/

            if (cbxVaiTro.SelectedValue.ToString() == "QUANLY")
            {
                // cho phép tạo login nếu tạo tài khoản có vai trò là QUANLY
                sql += ("\nEXEC sp_addsrvrolemember '" + txtLoginName.Text + "', 'SecurityAdmin'");

                // cho phép restore db
                sql += ("\nEXEC sp_addsrvrolemember '" + txtLoginName.Text + "', 'dbcreator'");

                // để select cái session
                sql += ("\nEXEC sp_addsrvrolemember '" + txtLoginName.Text + "', 'ServerAdmin'");

                // để quản lý các session (KILL...)
                sql += ("\nEXEC sp_addsrvrolemember '" + txtLoginName.Text + "', 'ProcessAdmin'");
            }

            sql += ("\nGRANT EXECUTE ON SP_Lay_Thong_Tin_NV_Tu_Login TO " + txtLoginName.Text);

            if (Program.ExecSqlNonQuery(sql) == 0)
            {
                MessageBox.Show("Tạo tài khoản " + txtLoginName.Text +" thành công!\nMật khẩu mặc định là: 123");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại");
                return;
            }
        }

        private void layDanhSachRole()
        {
            string sql = "SELECT * FROM V_GetRoles";
            SqlCommand cmd = new SqlCommand(sql, Program.conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Program.conn.Close();

            cbxVaiTro.DataSource = dt;
            cbxVaiTro.DisplayMember = "name";
            cbxVaiTro.ValueMember = "name";
        }

        private void cbxVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            layDanhSachRole();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnChonMaNV_Click(object sender, EventArgs e)
        {
            Form frm = CheckExists(typeof(frmChonNhanVien));
            if (frm != null)
                frm.Activate();
            else
            {
                frmChonNhanVien f = new frmChonNhanVien();
                f.ShowDialog();
                this.txtMaNV.Text = Program.maNvDaChon;
                txtLoginName.Text = Program.maNvDaChon.Trim();
            }
        }
    }
}
