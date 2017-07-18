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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportClientPlanDataSet.uspNameBaseSearchClientPlan' table. You can move, or remove it, as needed.
            //this.uspNameBaseSearchClientPlanTableAdapter.Fill(this.ReportClientPlanDataSet.uspNameBaseSearchClientPlan, Txt_FirstName.Text, Txt_SurName.Text);
            // TODO: This line of code loads data into the 'DatasetReportClientPlan.ClientsPlan' table. You can move, or remove it, as needed.
           // this.reportViewer1.RefreshReport();
            this.AcceptButton = Btn_SearchPlan;
            DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
            DataTable clientTable = connection.GetFullClient();
            foreach (DataRow cRow in clientTable.Rows)
            {
                combobox_FirstName.Items.Add(cRow["FirstName"]);
                combobox_SurName.Items.Add(cRow["SurName"]);
                combobox_NdisNo.Items.Add(cRow["NDISNumber"]);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_SearchPlan_Click(object sender, EventArgs e)
        {
            System.Int64 parseValue;
            System.Int64 no = 0;
            if (!string.IsNullOrEmpty(combobox_NdisNo.Text))
            {
                if (!System.Int64.TryParse(combobox_NdisNo.Text, out parseValue))
                {
                    MessageBox.Show("Please Enter Numbers Only");
                    return;
                }
                else
                {
                    no = Convert.ToInt64(combobox_NdisNo.Text);
                     ReportDataSource s = new ReportDataSource("ReportDataSet", uspReportClientPlanByNoBindingSource);
                    this.uspReportClientPlanByNoTableAdapter.Fill(this.clientQuotationDataSetReportByNo.uspReportClientPlanByNo,no);
                    this.reportViewer1.LocalReport.DataSources.Add(s);
                    System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
                    //pg.Landscape = false;
                    //pg.PaperSize = new System.Drawing.Printing.PaperSize("A4", 210, 297);
                    //pg.PaperSize.RawKind = (int)System.Drawing.Printing.PaperKind.A4;
                    pg.Margins.Top = 2;
                    pg.Margins.Bottom = 2;
                    pg.Margins.Left = 2;
                    pg.Margins.Right = 2;
                     pg.Landscape = true;
                    //pg.Landscape = false;
                    //System.Drawing.Printing.PaperSize size = new System.Drawing.Printing.PaperSize();
                    //size.RawKind = (int)PaperKind.A4;
                    //pg.PaperSize = size;
                    reportViewer1.SetPageSettings(pg);
                    DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                    DataTable rTable = connection.GetReportClientByNameNo(combobox_FirstName.Text, combobox_SurName.Text, no);
                    string firstName=string.Empty;
                    string surName = string.Empty;

                    foreach (DataRow rRow in rTable.Rows)
                    {
                        firstName = rRow["FirstName"].ToString();
                        surName = rRow["SurName"].ToString();
                        combobox_FirstName.Text = firstName;
                        combobox_SurName.Text = surName;
                    }


                    ReportParameterCollection reportParameters = new ReportParameterCollection();
                    reportParameters.Add(new ReportParameter("ReportSurName", surName));
                    reportParameters.Add(new ReportParameter("ReportFirstName", firstName));
                    this.reportViewer1.LocalReport.SetParameters(reportParameters);
                    this.reportViewer1.RefreshReport();
              }
        }
            else if (string.IsNullOrEmpty(combobox_NdisNo.Text) && !string.IsNullOrEmpty(combobox_FirstName.Text) && !string.IsNullOrEmpty(combobox_SurName.Text))
            {
                DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                DataTable rTable = connection.GetReportClientByNameNo(combobox_FirstName.Text, combobox_SurName.Text, no);
                foreach (DataRow rRow in rTable.Rows)
                {
                    combobox_NdisNo.Text = rRow["NDISNumber"].ToString();
                }
                ReportDataSource s = new ReportDataSource("ReportDataSet", uspNameBaseSearchClientPlanBindingSource);

                this.uspNameBaseSearchClientPlanTableAdapter.GetData(combobox_FirstName.Text, combobox_SurName.Text);
                this.uspNameBaseSearchClientPlanTableAdapter.Fill(this.ReportClientPlanDataSet.uspNameBaseSearchClientPlan, combobox_FirstName.Text, combobox_SurName.Text);
                this.reportViewer1.LocalReport.DataSources.Add(s);
                System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
                pg.Margins.Top = 2;
                pg.Margins.Bottom = 2;
                pg.Margins.Left = 2;
                pg.Margins.Right = 2;
                pg.Landscape = true;
                //System.Drawing.Printing.PaperSize size = new System.Drawing.Printing.PaperSize();
                //size.RawKind = (int)PaperKind.A4;
                //pg.PaperSize = size;
                reportViewer1.SetPageSettings(pg);
                ReportParameterCollection reportParameters = new ReportParameterCollection();
                reportParameters.Add(new ReportParameter("ReportSurName", combobox_SurName.Text));
                reportParameters.Add(new ReportParameter("ReportFirstName", combobox_FirstName.Text));
                this.reportViewer1.LocalReport.SetParameters(reportParameters);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
