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
    public partial class frmChonNhanVien : Form
    {
        public frmChonNhanVien()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmChonNhanVien_Load(object sender, EventArgs e)
        {
            this.nHANVIENTableAdapter.Connection = Program.conn;
            this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.maNvDaChon = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString();
            this.Dispose();
        }
    }
}
