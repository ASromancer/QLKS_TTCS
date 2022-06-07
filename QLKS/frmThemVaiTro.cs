using DevExpress.XtraEditors;
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
    public partial class frmThemVaiTro : DevExpress.XtraEditors.XtraForm
    {
        public frmThemVaiTro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmThemVaiTro_Load(object sender, EventArgs e)
        {
            this.dS.EnforceConstraints = false;

            this.bOPHANTableAdapter.Connection = Program.conn;
            this.bOPHANTableAdapter.Fill(this.dS.BOPHAN);
        }
    }
}