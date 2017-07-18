using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientQuoting
{
    public partial class FormReportServiceNotReady : Form
    {
        public FormReportServiceNotReady()
        {
            InitializeComponent();
        }

        private void FormReportServiceNotReady_Load(object sender, EventArgs e)
        {
   
            // TODO: This line of code loads data into the 'DataSetReportServiceNotReady.uspReportNotReadyToPost' table. You can move, or remove it, as needed.
        }

        private void DateTimerPicker_CreatedDate_ValueChanged(object sender, EventArgs e)
        {
            var dtp_created = sender as DateTimePicker;

            var selectedDate = dtp_created.Value;

            if (selectedDate.DayOfWeek != DayOfWeek.Monday)
            {

                var offset = (int)DayOfWeek.Monday - (int)selectedDate.DayOfWeek;

                var monday = selectedDate + TimeSpan.FromDays(offset);

                dtp_created.Value = monday;
            }
        }

        private void Btn_SearchService_Click(object sender, EventArgs e)
        {
             string sDate = DateTimerPicker_CreatedDate.Text;
             this.uspReportNotReadyToPostTableAdapter.Fill(this.DataSetReportServiceNotReady.uspReportNotReadyToPost,Convert.ToDateTime(sDate));
             System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
             pg.Margins.Top = 0;
             pg.Margins.Bottom = 0;
             pg.Margins.Left = 0;
             pg.Margins.Right = 0;
             pg.Landscape = true;
             reportViewerServiceNotReady.SetPageSettings(pg);

            //    //Adding parameters from code to show in the report viewer..
            //    var startDate = DateTimerPicker_CreatedDate.Value.Date.ToShortDateString();
            //    ReportParameterCollection reportParameters = new ReportParameterCollection();
            //    reportParameters.Add(new ReportParameter("ReportParameterCostCentre", combobox_CostCentre.Text));
            //    reportParameters.Add(new ReportParameter("ReportParameterDate", startDate));
            //    this.reportViewerServiceNotReady.LocalReport.SetParameters(reportParameters);
             this.reportViewerServiceNotReady.RefreshReport();
        }
    }
}
