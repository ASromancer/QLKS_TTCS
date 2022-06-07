using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class frmThemVaiTro : DevExpress.XtraEditors.XtraForm
    {
        public frmThemVaiTro()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void layDanhSachDBRole()
        {
            string sql = "USE [QLKS] " +
                "DECLARE @return_value int " +
                "EXEC    @return_value = [dbo].[sp_GetRoles] " +
                "SELECT  'Return Value' = @return_value ";
            SqlCommand cmd = new SqlCommand(sql, Program.conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Program.conn.Close();

            ((ListBox)cListBoxRole).DataSource = dt;
            ((ListBox)cListBoxRole).DisplayMember = "name";
            ((ListBox)cListBoxRole).ValueMember = "name";
        }

        private void frmThemVaiTro_Load(object sender, EventArgs e)
        {
            this.DS.EnforceConstraints = false;

            this.bOPHANTableAdapter.Connection = Program.conn;
            this.bOPHANTableAdapter.Fill(this.DS.BOPHAN);

            layDanhSachDBRole();
        }

        private bool checkThongTin()
        {
            string tenRole = txtTenRole.Text.Trim();

            if(!Regex.IsMatch(tenRole, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Tên vai trò không hợp lệ, phải là chữ cái không dấu, a-z hoặc A-Z!");
                txtTenRole.Focus();
                return false;
            }
            return true;
        }

        private void btnTaoRole_Click(object sender, EventArgs e)
        {
            if(!checkThongTin())
            {
                return;
            }

            string tenRole = txtTenRole.Text.Trim();
            tenRole = tenRole.ToUpper();

            string sql = "CREATE ROLE " + tenRole;
            foreach (object item in cListBoxRole.CheckedItems)
            {
                DataRowView drv = (DataRowView)item;
                string role = drv["name"].ToString();
                sql += ("\nALTER ROLE " + role + " ADD MEMBER " + tenRole);
            }

            if (Program.ExecSqlNonQuery(sql) == 0) {
                MessageBox.Show("Tạo vai trò thành công");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Tạo vai trò thất bại");
                return;
            }
        }
    }
}