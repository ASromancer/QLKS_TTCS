using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLKS
{
    public partial class ReportDoanhThu : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDoanhThu(DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            this.sqlDataSource1.Queries[0].Parameters[0].Value = fromDate;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = toDate;
            this.sqlDataSource1.Fill();
        }

    }
}
