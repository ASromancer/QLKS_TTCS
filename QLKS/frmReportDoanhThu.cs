using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class frmReportDoanhThu : DevExpress.XtraEditors.XtraForm
    {
        public frmReportDoanhThu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmReportDoanhThu_Load(object sender, EventArgs e)
        {
            dteTuNgay.EditValue = "01-05-2000";
            dteToiNgay.EditValue = DateTime.Today.ToString("dd-MM-yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            if(dteTuNgay.DateTime > dteToiNgay.DateTime)
            {
                MessageBox.Show("Từ Ngày không được lớn hơn tới ngày");
                dteTuNgay.EditValue = DateTime.Today.ToString("dd-MM-yyyy");
                dteToiNgay.EditValue = DateTime.Today.ToString("dd-MM-yyyy");
                return;
            }
            DateTime fromDate = (DateTime)dteTuNgay.DateTime;
            DateTime toDate = (DateTime)dteToiNgay.DateTime;

            ReportDoanhThu report = new ReportDoanhThu(fromDate,toDate);
            report.txtTuNgay.Text = dteTuNgay.EditValue.ToString();
            report.txtToiNgay.Text = dteToiNgay.EditValue.ToString();

            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dteTuNgay.DateTime > dteToiNgay.DateTime)
            {
                MessageBox.Show("Từ Ngày không được lớn hơn tới ngày");
                dteTuNgay.EditValue = DateTime.Today.ToString("dd-MM-yyyy");
                dteToiNgay.EditValue = DateTime.Today.ToString("dd-MM-yyyy");
                return;
            }

            DateTime fromDate = (DateTime)dteTuNgay.DateTime;
            DateTime toDate = (DateTime)dteToiNgay.DateTime;
            try
            {

                ReportDoanhThu report = new ReportDoanhThu(fromDate, toDate);
                if (File.Exists(@"D:\ReportDoanhThu.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File ReportDoanhThu.pdf tại ổ D đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        report.ExportToPdf(@"D:\ReportDoanhThu.pdf");
                        MessageBox.Show("File ReportDSNhanVien.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    report.ExportToPdf(@"D:\ReportDoanhThu.pdf");
                    MessageBox.Show("File ReportDoanhThu.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Vui lòng đóng file ReportDonHangKhongPhieuNhap.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}