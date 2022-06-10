using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLKS
{
    public partial class ReportChiTietHoaDon : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportChiTietHoaDon(string MAPT)
        {
            InitializeComponent();
            this.sqlDataSource1.Queries[0].Parameters[0].Value = MAPT;
            this.sqlDataSource1.Queries[1].Parameters[0].Value = MAPT;
            this.sqlDataSource1.Fill();
        }

    }
}
