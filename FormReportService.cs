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
    public partial class FormReportService : Form
    {
        public FormReportService()
        {
            InitializeComponent();
        }

        private void FormReportService_Load(object sender, EventArgs e)
        {
            this.AcceptButton = Btn_SearchService;
            DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
            DataTable CostCode = connection.GetCostCentre();
            //Combobox_CostCentre.DataSource = CostCode;
            foreach (DataRow dr in CostCode.Rows)
            {
                combobox_CostCentre.Items.Add(dr["CostCode"].ToString() + ' ' + dr["CostDescription"].ToString());
            }
            combobox_CostCentre.Text = "Select Cost Centre";
           // this.reportViewerService.RefreshReport();
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
            if (!string.IsNullOrEmpty(combobox_CostCentre.Text) && combobox_CostCentre.Text != "Select Cost Centre")
            {
                //ReportDataSource s = new ReportDataSource("ReportDataSet", uspReportServiceProvidedBindingSource);
                int costC = Convert.ToInt32(combobox_CostCentre.Text.Substring(0, combobox_CostCentre.Text.IndexOf(' ')));
                string sDate = DateTimerPicker_CreatedDate.Text;
                this.uspReportServiceProvidedTableAdapter.Fill(this.ClientQuotationDataSetReportService.uspReportServiceProvided, costC, Convert.ToDateTime(sDate));
                System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
                pg.Margins.Top = 2;
                pg.Margins.Bottom = 2;
                pg.Margins.Left = 2;
                pg.Margins.Right = 2;
               // pg.Landscape = true;
                pg.Landscape = true;
                System.Drawing.Printing.PaperSize size = new System.Drawing.Printing.PaperSize();
                size.RawKind = (int)PaperKind.A4;
                pg.PaperSize = size;
                reportViewerService.SetPageSettings(pg);

                //Adding parameters from code to show in the report viewer..
                var startDate = DateTimerPicker_CreatedDate.Value.Date.ToShortDateString();
                ReportParameterCollection reportParameters = new ReportParameterCollection();
                reportParameters.Add(new ReportParameter("ReportParameterCostCentre", combobox_CostCentre.Text));
                reportParameters.Add(new ReportParameter("ReportParameterDate", startDate));
                this.reportViewerService.LocalReport.SetParameters(reportParameters);
                this.reportViewerService.RefreshReport();

            }
            else
                MessageBox.Show("Please Select Cost Centre and Date from the fields to generate the report");
        }
    }
}
