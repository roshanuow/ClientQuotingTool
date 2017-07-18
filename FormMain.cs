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

namespace ClientQuoting
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void MenuItemParticipants_Click(object sender, EventArgs e)
        {
           // pictureBox1.Dispose();
            pictureBoxGds.Dispose();
            pictureBoxGdsLogo.Dispose();
            Lb_Footer.Dispose();
            Lbl_footercopywrite.Dispose();
            linkLabelGDS.Dispose();
            Form_Client ClientForm = new Form_Client();
            //Set the parent form for this child window..
            ClientForm.MdiParent = this;
            ClientForm.Dock = DockStyle.Fill;
            ClientForm.WindowState = FormWindowState.Maximized;
            //Display the Form..
            ClientForm.Show();
        }

        private void MenuItemServiceQuote_Click(object sender, EventArgs e)
        {
            pictureBoxGds.Dispose();
            pictureBoxGdsLogo.Dispose();
            Lb_Footer.Dispose();
            Lbl_footercopywrite.Dispose();
            linkLabelGDS.Dispose();
            FormQuoteAccepted QuoteAcceptedForm = new FormQuoteAccepted();
            //Set the parent form for this child window..
            QuoteAcceptedForm.MdiParent = this;
            QuoteAcceptedForm.Dock = DockStyle.Fill;
            QuoteAcceptedForm.WindowState = FormWindowState.Maximized;
            //Display the Form..
            QuoteAcceptedForm.Show();
        }

        private void serviceProvidedMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxGds.Dispose();
            pictureBoxGdsLogo.Dispose();
            Lb_Footer.Dispose();
            Lbl_footercopywrite.Dispose();
            linkLabelGDS.Dispose();
            FormServiceProvided serviceProvided = new FormServiceProvided();
            //Set the parent form for this child window..
            serviceProvided.MdiParent = this;
            serviceProvided.Dock = DockStyle.Fill;
            serviceProvided.WindowState = FormWindowState.Maximized;
            //Display the Form..
            serviceProvided.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pictureBoxGds.Dispose();
            //pictureBoxGdsLogo.Dispose();
            //Lb_Footer.Dispose();
            //Lbl_footercopywrite.Dispose();
            //linkLabelGDS.Dispose();
            //FormReport ClientReport = new FormReport();
            ////Set the parent form for this child window..
            //ClientReport.MdiParent = this;
            //ClientReport.Dock = DockStyle.Fill;
            //ClientReport.WindowState = FormWindowState.Maximized;
            //ClientReport.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            string windowName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            if (windowName == @"GREENACRES\roshank" || windowName == @"GREENACRES\gregm" || windowName == @"GREENACRES\roshan.admin" || windowName == @"GREENACRES\SharonF" || windowName == @"GREENACRES\traceyp")
            {
                ExportToCSVToolStripMenuItem.Visible = true;
            }
            else
            ExportToCSVToolStripMenuItem.Visible = false;

        }

        private void reportClientPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxGds.Dispose();
            pictureBoxGdsLogo.Dispose();
            Lb_Footer.Dispose();
            Lbl_footercopywrite.Dispose();
            linkLabelGDS.Dispose();
            FormReport ClientReport = new FormReport();
            //Set the parent form for this child window..
            ClientReport.MdiParent = this;
            ClientReport.Dock = DockStyle.Fill;
            ClientReport.WindowState = FormWindowState.Maximized;
            ClientReport.Show();
        }

        private void reportServiceProvidedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxGds.Dispose();
            pictureBoxGdsLogo.Dispose();
            Lb_Footer.Dispose();
            Lbl_footercopywrite.Dispose();
            linkLabelGDS.Dispose();
            FormReportService ServiceReport = new FormReportService();
            //Set the parent form for this child window..
            ServiceReport.MdiParent = this;
            ServiceReport.Dock = DockStyle.Fill;
            ServiceReport.WindowState = FormWindowState.Maximized;
            ServiceReport.Show();
        }

        private void ExportToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
            pictureBoxGds.Dispose();
            pictureBoxGdsLogo.Dispose();
            Lb_Footer.Dispose();
            Lbl_footercopywrite.Dispose();
            linkLabelGDS.Dispose();
            DateTime dtime = DateTime.Now;
            string val=dtime.ToShortDateString();
            val= val.Replace('/',' ');
           string fileName= val.Replace(" ", "");
            DialogResult result=MessageBox.Show("Are You Sure You Want to Export Service Provided Data To CSV File", "Export To CSV File", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataTable serviceTable=new DataTable();
                DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                try
                {
                    serviceTable = connection.GetServiceDataForExport();
                    string filePath = @"\\ibis\\Data\\RTransfer\\ClientQuotingTool\\ExportData\\Export_" + fileName + "_exp" + ".csv";
                    using (TextWriter csvWriter = new StreamWriter(filePath))
                    {
                        ExportServiceToCSV.CSVWriter.WriteServiceDataTableToCSV(serviceTable, csvWriter, true);
                    }
                    MessageBox.Show("Service Provided Data Exported Successfully by the user" + " " + System.Security.Principal.WindowsIdentity.GetCurrent().Name +" in the location " + filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to Export Data To File " + ex.Message);
                    return;
                }
                //List<string> idList = new List<string>();
                string ids = string.Empty;
                int count = 0;       
                foreach (DataRow iDRow in serviceTable.Rows)
                {
                    count++;
                    if (count < serviceTable.Rows.Count)
                        ids += iDRow["ActivityID"].ToString() + ",";
                    else if (count == serviceTable.Rows.Count)
                        ids += iDRow["ActivityID"].ToString();

                }
                DateTime todayDate = DateTime.Today;
                todayDate.ToShortDateString();
                string date=todayDate.ToString("yyyy-MM-dd");
                string dateDelivered = "'" + date + "'";
                int updatedLedger = connection.UpdatePostedToLedgerAfterExport(ids, dateDelivered);
                MessageBox.Show("PostedToLedger date has been updated for" + " " + updatedLedger + " " + "rows");
            }
            else
                MessageBox.Show("Have a nice day\n You can always come back later.","Greetings From Roshan",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void linkLabelGDS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelGDS.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.greenacres.net.au");
        }

        private void reportServiceNotReadyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxGds.Dispose();
            pictureBoxGdsLogo.Dispose();
            Lb_Footer.Dispose();
            Lbl_footercopywrite.Dispose();
            linkLabelGDS.Dispose();
            FormReportServiceNotReady NotReadyServiceReport = new FormReportServiceNotReady();
            //Set the parent form for this child window..
            NotReadyServiceReport.MdiParent = this;
            NotReadyServiceReport.Dock = DockStyle.Fill;
            NotReadyServiceReport.WindowState = FormWindowState.Maximized;
            NotReadyServiceReport.Show();
        }
    }
}
