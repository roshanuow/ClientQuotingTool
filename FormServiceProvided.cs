using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientQuoting
{
    public partial class FormServiceProvided : Form
    {
        public FormServiceProvided()
        {
            InitializeComponent();
        }
        string firstName, surName;
        System.Int64 ndisNo;
        int dateSelected = 0;
        private void FormServiceProvided_Load(object sender, EventArgs e)
        {
            DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
            DataTable CostCode = connection.GetCostCentre();
            //Combobox_CostCentre.DataSource = CostCode;
            foreach (DataRow dr in CostCode.Rows)
            {
                combobox_CostCentre.Items.Add(dr["CostCode"].ToString() + ' ' + dr["CostDescription"].ToString());
            }
            combobox_CostCentre.Text = "Select Cost Centre";
            DataTable clients = connection.GetFullClient();
            foreach (DataRow cDr in clients.Rows)
            {
                comboBox_ClientsFullName.Items.Add(string.Format(cDr["FirstName"].ToString() + ',' + cDr["SurName"].ToString()));
            }
            comboBox_NDISBillablre.Items.Insert(0, "Select Yes/No");
            comboBox_NDISBillablre.Items.Insert(1, "Yes");
            comboBox_NDISBillablre.Items.Insert(2, "No");
            comboBox_NDISBillablre.Text = "Select Yes/No";

            combobox_ReadyToPost.Items.Insert(0, "Select Yes/No");
            combobox_ReadyToPost.Items.Insert(1, "Yes");
            combobox_ReadyToPost.Items.Insert(2, "No");
            combobox_ReadyToPost.Text = "Select Yes/No";

            //Load Custom datagridview Column DataPropertyName..
            dataGridViewServiceProvided.AutoGenerateColumns = false;
            dataGridViewServiceProvided.Columns["Client"].DataPropertyName = "Client";
            dataGridViewServiceProvided.Columns["SupportItemDescription"].DataPropertyName = "SupportItemDescription";
            dataGridViewServiceProvided.Columns["UnitOfMeasure"].DataPropertyName = "UnitOfMeasure";
            dataGridViewServiceProvided.Columns["MondayUnit"].DataPropertyName = "MondayUnit";
            dataGridViewServiceProvided.Columns["TuesdayUnit"].DataPropertyName = "TuesdayUnit";
            dataGridViewServiceProvided.Columns["WednesdayUnit"].DataPropertyName = "WednesdayUnit";
            dataGridViewServiceProvided.Columns["ThursdayUnit"].DataPropertyName = "ThursdayUnit";
            dataGridViewServiceProvided.Columns["FridayUnit"].DataPropertyName = "FridayUnit";
            dataGridViewServiceProvided.Columns["SaturdayUnit"].DataPropertyName = "SaturdayUnit";
            dataGridViewServiceProvided.Columns["SundayUnit"].DataPropertyName = "SundayUnit";
            dataGridViewServiceProvided.Columns["TotalHours"].DataPropertyName = "TotalHours";
            dataGridViewServiceProvided.Columns["CheckedOkToBill"].DataPropertyName = "CheckedOkToBill";
            dataGridViewServiceProvided.Columns["ID"].DataPropertyName = "ID";
        }

        private void comboBox_ClientsFullName_SelectedValueChanged(object sender, EventArgs e)
        {

            string[] fullName;
            fullName = comboBox_ClientsFullName.Text.Split(',');
            firstName = fullName[0];
            surName = fullName[1];
            DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
            DataTable planTable = connection.GetClientPlanByName(firstName, surName);
            foreach (DataRow pRow in planTable.Rows)
            {
                comboBox_SupportItem.Items.Add(pRow[0].ToString());
            }
        }

        private void comboBox_SupportItem_SelectedValueChanged(object sender, EventArgs e)
        {
            DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
            DataTable sTable = connection.GetServiceSupportItemDesc(firstName, surName, comboBox_SupportItem.Text);
            foreach (DataRow sRow in sTable.Rows)
            {
                Txt_ItemNO.Text = sRow["SupportItemNumber"].ToString();
                Txt_SupportItemDesc.Text = sRow["SupportItemDescription"].ToString();
                Txt_UnitOfMeasure.Text = sRow["UnitOfMeasure"].ToString();
            }
        }

        private void comboBox_NDISBillablre_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_ClientsFullName.Text != "Select Client")
            {
                comboBox_SupportItem.Items.Clear();
                bool isBillable = true;
                if (comboBox_NDISBillablre.Text == "Yes")
                    isBillable = true;
                else if (comboBox_NDISBillablre.Text == "No")
                    isBillable = false;
                DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                DataTable isBillableTable = connection.GetNdisBillableSupportItem(firstName, surName, isBillable);
                foreach (DataRow bRow in isBillableTable.Rows)
                {
                    comboBox_SupportItem.Items.Add(bRow["SupportItem"].ToString());
                }
            }
        }

        private void SearchService()
        {
            if (!string.IsNullOrEmpty(combobox_CostCentre.Text) && combobox_CostCentre.Text != "Select Cost Centre")
            {
                int costC = Convert.ToInt32(combobox_CostCentre.Text.Substring(0, combobox_CostCentre.Text.IndexOf(' ')));
                DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                // DataTable serviceTable = connection.GetServiceProvidedByName(firstName, surName);
                DataTable serviceTable = connection.GetServiceProvidedByCostDate(costC, DateTimerPicker_CreatedDate.Text);
                dataGridViewServiceProvided.DataSource = serviceTable;
                if (dataGridViewServiceProvided.RowCount >= 7)
                    dataGridViewServiceProvided.Height = dataGridViewServiceProvided.RowCount * 35;
                else
                    dataGridViewServiceProvided.Height = 210;
            }
            else
                MessageBox.Show("Please Select Cost Centre and Date to search");

        }
        private void Btn_SearchService_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(combobox_CostCentre.Text) && combobox_CostCentre.Text != "Select Cost Centre" && !string.IsNullOrEmpty(DateTimerPicker_CreatedDate.Text))
            //if (comboBox_ClientsFullName.Text != "" && comboBox_ClientsFullName.Text != "Select Client")
            //{
            SearchService();
            //}
            //else
            //    MessageBox.Show("Please Select client from dropdown list before search");
        }

        private void Btn_ExitService_Click(object sender, EventArgs e)
        {
            Form_Client clientform = new Form_Client();
            clientform.MdiParent = this.ParentForm;
            clientform.Dock = DockStyle.Fill;
            clientform.WindowState = FormWindowState.Maximized;
            this.Close();
            clientform.Show();
        }

        private void Btn_InsertService_Click(object sender, EventArgs e)
        {
            if (comboBox_ClientsFullName.Text != "" && comboBox_ClientsFullName.Text != "Select Client")
            {

                DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                DataTable cTable = connection.GetClientByNo(firstName, surName);
                foreach (DataRow cRow in cTable.Rows)
                    ndisNo = Convert.ToInt64(cRow["NDISNumber"]);
                if (!string.IsNullOrEmpty(Txt_TotalHours.Text))
                {

                    bool isOkToBill = true;
                    if (combobox_ReadyToPost.Text == "Yes")
                        isOkToBill = true;
                    else if (combobox_ReadyToPost.Text == "No")
                        isOkToBill = false;
                    decimal mon, tues, wed, thurs, fri, sat, sun, totalhrs;
                    int costCentre = 0;
                    if (string.IsNullOrEmpty(Txt_Monday.Text))
                        mon = 0;
                    else
                        mon = Convert.ToDecimal(Txt_Monday.Text);

                    if (string.IsNullOrEmpty(Txt_Tuesday.Text))
                        tues = 0;
                    else
                        tues = Convert.ToDecimal(Txt_Tuesday.Text);

                    if (string.IsNullOrEmpty(Txt_Wednesday.Text))
                        wed = 0;
                    else
                        wed = Convert.ToDecimal(Txt_Wednesday.Text);

                    if (string.IsNullOrEmpty(Txt_Thursday.Text))
                        thurs = 0;
                    else
                        thurs = Convert.ToDecimal(Txt_Thursday.Text);

                    if (string.IsNullOrEmpty(Txt_Friday.Text))
                        fri = 0;
                    else
                        fri = Convert.ToDecimal(Txt_Friday.Text);

                    if (string.IsNullOrEmpty(Txt_Saturday.Text))
                        sat = 0;
                    else
                        sat = Convert.ToDecimal(Txt_Saturday.Text);

                    if (string.IsNullOrEmpty(Txt_Sunday.Text))
                        sun = 0;
                    else
                        sun = Convert.ToDecimal(Txt_Sunday.Text);

                    totalhrs = mon + tues + wed + thurs + fri + sat + sun;
                    string inputDate = DateTimerPicker_CreatedDate.Text;
                    if (!string.IsNullOrEmpty(combobox_CostCentre.Text) && combobox_CostCentre.Text != "Select Cost Centre")
                    {
                        costCentre = Convert.ToInt32(combobox_CostCentre.Text.Substring(0, combobox_CostCentre.Text.IndexOf(' ')));
                    }
                    if (referenceID == 0)
                    {
                        connection.InsertServiceProvidedInfo(ndisNo, inputDate, Txt_ItemNO.Text, Txt_SupportItemDesc.Text, Txt_UnitOfMeasure.Text, costCentre, Txt_CreatedBy.Text, isOkToBill, mon, tues, wed, thurs, fri, sat, sun, totalhrs);
                        SearchService();
                        MessageBox.Show("Service Inserted Successfully");
                        ClearData();
                    }
                    else
                        MessageBox.Show("Record already exist\n You can only update the existing record");
                }
            }
            else
                MessageBox.Show("You must first fill the relevant information before insert");

        }

        private void ClearData()
        {
            comboBox_ClientsFullName.Text = "";
            comboBox_NDISBillablre.Text = "";
            comboBox_SupportItem.Text = "";
            Txt_ItemNO.Text = "";
            Txt_SupportItemDesc.Text = "";
            Txt_UnitOfMeasure.Text = "";
            Txt_Monday.Text = "";
            Txt_Tuesday.Text = "";
            Txt_Wednesday.Text = "";
            Txt_Thursday.Text = "";
            Txt_Friday.Text = "";
            Txt_Saturday.Text = "";
            Txt_Sunday.Text = "";
            Txt_TotalHours.Text = "";
            //Txt_CreatedBy.Text = "";
            //combobox_CostCentre.Text = "";
           // DateTimerPicker_CreatedDate.Text = "";
            combobox_ReadyToPost.Text = "";
        }

        private void Txt_Monday_TextChanged(object sender, EventArgs e)
        {
            decimal mon, tues, wed, thurs, fri, sat, sun, totalhrs;
            if (string.IsNullOrEmpty(Txt_Monday.Text))
                mon = 0;
            else
            {
                if (Txt_UnitOfMeasure.Text.Trim() != "Hour" && Txt_Monday.Text != "1" && Txt_Monday.Text != "1.00" && Txt_Monday.Text != "0" && Txt_Monday.Text != "0.00")
                {
                    MessageBox.Show("You can only enter 1 as a value for Unit Type" + Txt_UnitOfMeasure.Text);
                    Txt_Monday.Text = "1";
                    mon = Convert.ToDecimal(Txt_Monday.Text);
                }
                else
                    mon = Convert.ToDecimal(Txt_Monday.Text);
                
            }

            if (string.IsNullOrEmpty(Txt_Tuesday.Text))
                tues = 0;
            else
                tues = Convert.ToDecimal(Txt_Tuesday.Text);

            if (string.IsNullOrEmpty(Txt_Wednesday.Text))
                wed = 0;
            else
                wed = Convert.ToDecimal(Txt_Wednesday.Text);

            if (string.IsNullOrEmpty(Txt_Thursday.Text))
                thurs = 0;
            else
                thurs = Convert.ToDecimal(Txt_Thursday.Text);

            if (string.IsNullOrEmpty(Txt_Friday.Text))
                fri = 0;
            else
                fri = Convert.ToDecimal(Txt_Friday.Text);

            if (string.IsNullOrEmpty(Txt_Saturday.Text))
                sat = 0;
            else
                sat = Convert.ToDecimal(Txt_Saturday.Text);

            if (string.IsNullOrEmpty(Txt_Sunday.Text))
                sun = 0;
            else
                sun = Convert.ToDecimal(Txt_Sunday.Text);

            totalhrs = mon + tues + wed + thurs + fri + sat + sun;
            Txt_TotalHours.Text = Convert.ToString(totalhrs);
        }

        private void Txt_Tuesday_TextChanged(object sender, EventArgs e)
        {
            decimal mon, tues, wed, thurs, fri, sat, sun, totalhrs;
            if (string.IsNullOrEmpty(Txt_Monday.Text))
                mon = 0;
            else
                mon = Convert.ToDecimal(Txt_Monday.Text);

            if (string.IsNullOrEmpty(Txt_Tuesday.Text))
                tues = 0;
            else
            {
                if (Txt_UnitOfMeasure.Text.Trim() != "Hour" && Txt_Tuesday.Text != "1" && Txt_Tuesday.Text != "1.00" && Txt_Tuesday.Text != "0" && Txt_Tuesday.Text != "0.00")
                {
                    MessageBox.Show("You can only enter 1 as a value for Unit Type" + Txt_UnitOfMeasure.Text);
                    Txt_Tuesday.Text = "1";
                    tues = Convert.ToDecimal(Txt_Tuesday.Text);
                }
                else
                    tues = Convert.ToDecimal(Txt_Tuesday.Text);

            }

            if (string.IsNullOrEmpty(Txt_Wednesday.Text))
                wed = 0;
            else
                wed = Convert.ToDecimal(Txt_Wednesday.Text);

            if (string.IsNullOrEmpty(Txt_Thursday.Text))
                thurs = 0;
            else
                thurs = Convert.ToDecimal(Txt_Thursday.Text);

            if (string.IsNullOrEmpty(Txt_Friday.Text))
                fri = 0;
            else
                fri = Convert.ToDecimal(Txt_Friday.Text);

            if (string.IsNullOrEmpty(Txt_Saturday.Text))
                sat = 0;
            else
                sat = Convert.ToDecimal(Txt_Saturday.Text);

            if (string.IsNullOrEmpty(Txt_Sunday.Text))
                sun = 0;
            else
                sun = Convert.ToDecimal(Txt_Sunday.Text);

            totalhrs = mon + tues + wed + thurs + fri + sat + sun;
            Txt_TotalHours.Text = Convert.ToString(totalhrs);
        }

        private void Txt_Wednesday_TextChanged(object sender, EventArgs e)
        {
            decimal mon, tues, wed, thurs, fri, sat, sun, totalhrs;
            if (string.IsNullOrEmpty(Txt_Monday.Text))
                mon = 0;
            else
                mon = Convert.ToDecimal(Txt_Monday.Text);

            if (string.IsNullOrEmpty(Txt_Tuesday.Text))
                tues = 0;
            else
                tues = Convert.ToDecimal(Txt_Tuesday.Text);

            if (string.IsNullOrEmpty(Txt_Wednesday.Text))
                wed = 0;
            else
            {
                if (Txt_UnitOfMeasure.Text.Trim() != "Hour" && Txt_Wednesday.Text != "1" && Txt_Wednesday.Text != "1.00" && Txt_Wednesday.Text != "0" && Txt_Wednesday.Text != "0.00")
                {
                    MessageBox.Show("You can only enter 1 as a value for Unit Type" + Txt_UnitOfMeasure.Text);
                    Txt_Wednesday.Text = "1";
                    wed = Convert.ToDecimal(Txt_Wednesday.Text);
                }
                else
                    wed = Convert.ToDecimal(Txt_Wednesday.Text);

            }

            if (string.IsNullOrEmpty(Txt_Thursday.Text))
                thurs = 0;
            else
                thurs = Convert.ToDecimal(Txt_Thursday.Text);

            if (string.IsNullOrEmpty(Txt_Friday.Text))
                fri = 0;
            else
                fri = Convert.ToDecimal(Txt_Friday.Text);

            if (string.IsNullOrEmpty(Txt_Saturday.Text))
                sat = 0;
            else
                sat = Convert.ToDecimal(Txt_Saturday.Text);

            if (string.IsNullOrEmpty(Txt_Sunday.Text))
                sun = 0;
            else
                sun = Convert.ToDecimal(Txt_Sunday.Text);

            totalhrs = mon + tues + wed + thurs + fri + sat + sun;
            Txt_TotalHours.Text = Convert.ToString(totalhrs);
        }

        private void Txt_Thursday_TextChanged(object sender, EventArgs e)
        {
            decimal mon, tues, wed, thurs, fri, sat, sun, totalhrs;
            if (string.IsNullOrEmpty(Txt_Monday.Text))
                mon = 0;
            else
                mon = Convert.ToDecimal(Txt_Monday.Text);

            if (string.IsNullOrEmpty(Txt_Tuesday.Text))
                tues = 0;
            else
                tues = Convert.ToDecimal(Txt_Tuesday.Text);

            if (string.IsNullOrEmpty(Txt_Wednesday.Text))
                wed = 0;
            else
                wed = Convert.ToDecimal(Txt_Wednesday.Text);

            if (string.IsNullOrEmpty(Txt_Thursday.Text))
                thurs = 0;
            else
            {
                if (Txt_UnitOfMeasure.Text.Trim() != "Hour" && Txt_Thursday.Text != "1" && Txt_Thursday.Text != "1.00" && Txt_Thursday.Text != "0" && Txt_Thursday.Text != "0.00")
                {
                    MessageBox.Show("You can only enter 1 as a value for Unit Type" + Txt_UnitOfMeasure.Text);
                    Txt_Thursday.Text = "1";
                    thurs = Convert.ToDecimal(Txt_Thursday.Text);
                }
                else
                thurs = Convert.ToDecimal(Txt_Thursday.Text);

            }

            if (string.IsNullOrEmpty(Txt_Friday.Text))
                fri = 0;
            else
                fri = Convert.ToDecimal(Txt_Friday.Text);

            if (string.IsNullOrEmpty(Txt_Saturday.Text))
                sat = 0;
            else
                sat = Convert.ToDecimal(Txt_Saturday.Text);

            if (string.IsNullOrEmpty(Txt_Sunday.Text))
                sun = 0;
            else
                sun = Convert.ToDecimal(Txt_Sunday.Text);

            totalhrs = mon + tues + wed + thurs + fri + sat + sun;
            Txt_TotalHours.Text = Convert.ToString(totalhrs);
        }

        private void Txt_Friday_TextChanged(object sender, EventArgs e)
        {
            decimal mon, tues, wed, thurs, fri, sat, sun, totalhrs;
            if (string.IsNullOrEmpty(Txt_Monday.Text))
                mon = 0;
            else
                mon = Convert.ToDecimal(Txt_Monday.Text);

            if (string.IsNullOrEmpty(Txt_Tuesday.Text))
                tues = 0;
            else
                tues = Convert.ToDecimal(Txt_Tuesday.Text);

            if (string.IsNullOrEmpty(Txt_Wednesday.Text))
                wed = 0;
            else
                wed = Convert.ToDecimal(Txt_Wednesday.Text);

            if (string.IsNullOrEmpty(Txt_Thursday.Text))
                thurs = 0;
            else
                thurs = Convert.ToDecimal(Txt_Thursday.Text);

            if (string.IsNullOrEmpty(Txt_Friday.Text))
                fri = 0;
            else
            {
                if (Txt_UnitOfMeasure.Text.Trim() != "Hour" && Txt_Friday.Text != "1" && Txt_Friday.Text != "1.00" && Txt_Friday.Text != "0" && Txt_Friday.Text != "0.00")
                {
                    MessageBox.Show("You can only enter 1 as a value for Unit Type" + Txt_UnitOfMeasure.Text);
                    Txt_Friday.Text = "1";
                    fri = Convert.ToDecimal(Txt_Friday.Text);
                }
                else
                    fri = Convert.ToDecimal(Txt_Friday.Text);

            }

            if (string.IsNullOrEmpty(Txt_Saturday.Text))
                sat = 0;
            else
                sat = Convert.ToDecimal(Txt_Saturday.Text);

            if (string.IsNullOrEmpty(Txt_Sunday.Text))
                sun = 0;
            else
                sun = Convert.ToDecimal(Txt_Sunday.Text);

            totalhrs = mon + tues + wed + thurs + fri + sat + sun;
            Txt_TotalHours.Text = Convert.ToString(totalhrs);
        }

        private void Txt_Saturday_TextChanged(object sender, EventArgs e)
        {
            decimal mon, tues, wed, thurs, fri, sat, sun, totalhrs;
            if (string.IsNullOrEmpty(Txt_Monday.Text))
                mon = 0;
            else
                mon = Convert.ToDecimal(Txt_Monday.Text);

            if (string.IsNullOrEmpty(Txt_Tuesday.Text))
                tues = 0;
            else
                tues = Convert.ToDecimal(Txt_Tuesday.Text);

            if (string.IsNullOrEmpty(Txt_Wednesday.Text))
                wed = 0;
            else
                wed = Convert.ToDecimal(Txt_Wednesday.Text);

            if (string.IsNullOrEmpty(Txt_Thursday.Text))
                thurs = 0;
            else
                thurs = Convert.ToDecimal(Txt_Thursday.Text);

            if (string.IsNullOrEmpty(Txt_Friday.Text))
                fri = 0;
            else
                fri = Convert.ToDecimal(Txt_Friday.Text);

            if (string.IsNullOrEmpty(Txt_Saturday.Text))
                sat = 0;
            else
            {
                if (Txt_UnitOfMeasure.Text.Trim() != "Hour" && Txt_Saturday.Text != "1" && Txt_Saturday.Text != "1.00" && Txt_Saturday.Text != "0" && Txt_Saturday.Text != "0.00")
                {
                    MessageBox.Show("You can only enter 1 as a value for Unit Type" + Txt_UnitOfMeasure.Text);
                    Txt_Saturday.Text = "1";
                    sat = Convert.ToDecimal(Txt_Saturday.Text);
                }
                else
                    sat = Convert.ToDecimal(Txt_Saturday.Text);

            }

            if (string.IsNullOrEmpty(Txt_Sunday.Text))
                sun = 0;
            else
                sun = Convert.ToDecimal(Txt_Sunday.Text);

            totalhrs = mon + tues + wed + thurs + fri + sat + sun;
            Txt_TotalHours.Text = Convert.ToString(totalhrs);
        }

        private void Txt_Sunday_TextChanged(object sender, EventArgs e)
        {
            decimal mon, tues, wed, thurs, fri, sat, sun, totalhrs;
            if (string.IsNullOrEmpty(Txt_Monday.Text))
                mon = 0;
            else
                mon = Convert.ToDecimal(Txt_Monday.Text);

            if (string.IsNullOrEmpty(Txt_Tuesday.Text))
                tues = 0;
            else
                tues = Convert.ToDecimal(Txt_Tuesday.Text);

            if (string.IsNullOrEmpty(Txt_Wednesday.Text))
                wed = 0;
            else
                wed = Convert.ToDecimal(Txt_Wednesday.Text);

            if (string.IsNullOrEmpty(Txt_Thursday.Text))
                thurs = 0;
            else
                thurs = Convert.ToDecimal(Txt_Thursday.Text);

            if (string.IsNullOrEmpty(Txt_Friday.Text))
                fri = 0;
            else
                fri = Convert.ToDecimal(Txt_Friday.Text);

            if (string.IsNullOrEmpty(Txt_Saturday.Text))
                sat = 0;
            else
                sat = Convert.ToDecimal(Txt_Saturday.Text);

            if (string.IsNullOrEmpty(Txt_Sunday.Text))
                sun = 0;
            else
            {
                if (Txt_UnitOfMeasure.Text.Trim() != "Hour" && Txt_Sunday.Text != "1" && Txt_Sunday.Text != "1.00" && Txt_Sunday.Text != "0" && Txt_Sunday.Text != "0.00")
                {
                    MessageBox.Show("You can only enter 1 as a value for Unit Type" + Txt_UnitOfMeasure.Text);
                    Txt_Sunday.Text = "1";
                    sun = Convert.ToDecimal(Txt_Sunday.Text);
                }
                else
                    sun = Convert.ToDecimal(Txt_Sunday.Text);

            }

            totalhrs = mon + tues + wed + thurs + fri + sat + sun;
            Txt_TotalHours.Text = Convert.ToString(totalhrs);
        }
        int referenceID = 0;
        private void dataGridViewServiceProvided_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewServiceProvided.RowCount != 1)
            {
                comboBox_ClientsFullName.Text = dataGridViewServiceProvided.Rows[e.RowIndex].Cells[0].Value.ToString();
                Txt_SupportItemDesc.Text = dataGridViewServiceProvided.Rows[e.RowIndex].Cells[1].Value.ToString();
                Txt_UnitOfMeasure.Text = dataGridViewServiceProvided.Rows[e.RowIndex].Cells[2].Value.ToString();
                Txt_Monday.Text = dataGridViewServiceProvided.Rows[e.RowIndex].Cells[3].Value.ToString();
                Txt_Tuesday.Text = dataGridViewServiceProvided.Rows[e.RowIndex].Cells[4].Value.ToString();
                Txt_Wednesday.Text = dataGridViewServiceProvided.Rows[e.RowIndex].Cells[5].Value.ToString();
                Txt_Thursday.Text = dataGridViewServiceProvided.Rows[e.RowIndex].Cells[6].Value.ToString();
                Txt_Friday.Text = dataGridViewServiceProvided.Rows[e.RowIndex].Cells[7].Value.ToString();
                Txt_Saturday.Text = dataGridViewServiceProvided.Rows[e.RowIndex].Cells[8].Value.ToString();
                Txt_Sunday.Text = dataGridViewServiceProvided.Rows[e.RowIndex].Cells[9].Value.ToString();
                Txt_TotalHours.Text = dataGridViewServiceProvided.Rows[e.RowIndex].Cells[10].Value.ToString();
                string isReady = dataGridViewServiceProvided.Rows[e.RowIndex].Cells[11].Value.ToString();
                if (isReady == "True")
                    combobox_ReadyToPost.Text = "Yes";
                else if (isReady == "False")
                    combobox_ReadyToPost.Text = "No";
                referenceID = Convert.ToInt32(dataGridViewServiceProvided.Rows[e.RowIndex].Cells[12].Value);
                DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                DataTable scTable = connection.GetServiceClientPlanByRefID(referenceID);
                foreach (DataRow dRow in scTable.Rows)
                {
                    Txt_CreatedBy.Text = dRow["CreatedBy"].ToString();
                    Txt_ItemNO.Text = dRow["SupportItemNumber"].ToString();
                    comboBox_SupportItem.Text = dRow["SupportItem"].ToString();
                    string isBillable = dRow["NDISBillable"].ToString();
                    if (isBillable == "True")
                        comboBox_NDISBillablre.Text = "Yes";
                    else if (isBillable == "False")
                        comboBox_NDISBillablre.Text = "No";
                }
            }

        }

        private void Btn_UpdateService_Click(object sender, EventArgs e)
        {
            decimal monDay, tuesDay, wedDay, thursDay, friDay, satDay, sunDay, totalHour;

            if (!string.IsNullOrEmpty(Txt_TotalHours.Text))
            {
                if (string.IsNullOrEmpty(Txt_Monday.Text))
                    monDay = 0;
                else
                    monDay = Convert.ToDecimal(Txt_Monday.Text);

                if (string.IsNullOrEmpty(Txt_Tuesday.Text))
                    tuesDay = 0;
                else
                    tuesDay = Convert.ToDecimal(Txt_Tuesday.Text);

                if (string.IsNullOrEmpty(Txt_Wednesday.Text))
                    wedDay = 0;
                else
                    wedDay = Convert.ToDecimal(Txt_Wednesday.Text);

                if (string.IsNullOrEmpty(Txt_Thursday.Text))
                    thursDay = 0;
                else
                    thursDay = Convert.ToDecimal(Txt_Thursday.Text);

                if (string.IsNullOrEmpty(Txt_Friday.Text))
                    friDay = 0;
                else
                    friDay = Convert.ToDecimal(Txt_Friday.Text);

                if (string.IsNullOrEmpty(Txt_Saturday.Text))
                    satDay = 0;
                else
                    satDay = Convert.ToDecimal(Txt_Saturday.Text);

                if (string.IsNullOrEmpty(Txt_Sunday.Text))
                    sunDay = 0;
                else
                    sunDay = Convert.ToDecimal(Txt_Sunday.Text);
                totalHour = Convert.ToDecimal(Txt_TotalHours.Text);
                bool readyToBill = false;
                if (combobox_ReadyToPost.Text == "Yes")
                    readyToBill = true;
                else if (combobox_ReadyToPost.Text == "No")
                    readyToBill = false;
                DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                int returnValue=connection.UpdateServiceProvided(monDay, tuesDay, wedDay, thursDay, friDay, satDay, sunDay, totalHour, readyToBill, referenceID);
                if(returnValue!=0)
                    MessageBox.Show(" Selected Service Updated Successfully");
                else
                    MessageBox.Show(" Selected Service Cannot be Updated because this has been already Posted To Ledger");
                SearchService();
                
                ClearData();
            }
            else
                MessageBox.Show("You must select row from grid to update and delete");
        }

        private void Btn_DeleteService_Click(object sender, EventArgs e)
        {
            int row = dataGridViewServiceProvided.RowCount;
            if (referenceID != 0)
            {
                DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                int deleteRowCount=connection.DeleteServiceInfo(referenceID);
                if(deleteRowCount!=0)
                    MessageBox.Show("Selected row deleted successfully");
                else
                    MessageBox.Show("Selected row cannot be deleted because this has already been Posted To Ledger");
                SearchService();
                ClearData();
            }

            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
        //This DatTime Picker event is added to only allow users to select Monday date..
        int msgCount = 0;
        private void DateTimerPicker_CreatedDate_ValueChanged(object sender, EventArgs e)
        {
            dateSelected = 1;
            var dtp_created = sender as DateTimePicker;

            var selectedDate = dtp_created.Value;

            if (selectedDate.DayOfWeek != DayOfWeek.Monday)
            {

                var offset = (int)DayOfWeek.Monday - (int)selectedDate.DayOfWeek;

                var monday = selectedDate + TimeSpan.FromDays(offset);

                dtp_created.Value = monday;  
            }
            if (!string.IsNullOrEmpty(combobox_CostCentre.Text) && combobox_CostCentre.Text != "Select Cost Centre")
            {
                int costC = Convert.ToInt32(combobox_CostCentre.Text.Substring(0, combobox_CostCentre.Text.IndexOf(' ')));
                DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                // DataTable serviceTable = connection.GetServiceProvidedByName(firstName, surName);
                DataTable serviceTable = connection.GetServiceProvidedByCostDate(costC, DateTimerPicker_CreatedDate.Text);
                //if (serviceTable.Rows.Count > 0)
                //    MessageBox.Show("Cost Centre and Created Date exist");
                dataGridViewServiceProvided.DataSource = serviceTable;
                if (dataGridViewServiceProvided.RowCount >= 7)
                    dataGridViewServiceProvided.Height = dataGridViewServiceProvided.RowCount * 35;
                else
                    dataGridViewServiceProvided.Height = 210;
            }
            else
            {
                msgCount++;
                if(msgCount <=1)
                MessageBox.Show("Please Select Cost Centre to search");

            }
            //return;
        }

        private void combobox_CostCentre_SelectedValueChanged(object sender, EventArgs e)
        {
            if (dateSelected != 1)
            {
                if (dateSelected != 1)
                {
                    MessageBox.Show("Please Select the date");
                    return;
                }
            }
            if (!string.IsNullOrEmpty(combobox_CostCentre.Text) && combobox_CostCentre.Text != "Select Cost Centre")
            {
                int costC = Convert.ToInt32(combobox_CostCentre.Text.Substring(0, combobox_CostCentre.Text.IndexOf(' ')));
                DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                // DataTable serviceTable = connection.GetServiceProvidedByName(firstName, surName);
                DataTable serviceTable = connection.GetServiceProvidedByCostDate(costC, DateTimerPicker_CreatedDate.Text);
                //if (serviceTable.Rows.Count > 0)
                //    MessageBox.Show("Cost Centre and Created Date exist");
                dataGridViewServiceProvided.DataSource = serviceTable;
                if (dataGridViewServiceProvided.RowCount >= 7)
                    dataGridViewServiceProvided.Height = dataGridViewServiceProvided.RowCount * 35;
                else
                    dataGridViewServiceProvided.Height = 210;
            }
            else
                MessageBox.Show("Please Select Cost Centre and Date to search");
        }

        private void Btn_CopyService_Click(object sender, EventArgs e)
        {
            if (dateSelected != 1)
            {
                MessageBox.Show("Please Select the date to copy");
                return;
            }
            if (!string.IsNullOrEmpty(combobox_CostCentre.Text) && combobox_CostCentre.Text != "Select Cost Centre")
            {
                int costCentre = Convert.ToInt32(combobox_CostCentre.Text.Substring(0, combobox_CostCentre.Text.IndexOf(' ')));
                DateTime currentDate = DateTime.Today;
                DateTime mondayOfLastWeek = currentDate.AddDays(-(int)currentDate.DayOfWeek - 6);
                mondayOfLastWeek.ToShortDateString();
                string mondayPreviousWeek = mondayOfLastWeek.ToString("yyyy-MM-dd");
                DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                int copiedrow=connection.CopyServiceProvidedInfo(DateTimerPicker_CreatedDate.Text, mondayPreviousWeek, costCentre);
                if (copiedrow != 0)
                    MessageBox.Show(copiedrow + " " + "rows copied for the cost centre:" + " " + costCentre);
                DataTable serviceTable = connection.GetServiceProvidedByCostDate(costCentre, DateTimerPicker_CreatedDate.Text);
                //if (serviceTable.Rows.Count > 0)
                //    MessageBox.Show("Cost Centre and Created Date exist");
                dataGridViewServiceProvided.DataSource = serviceTable;
                if (dataGridViewServiceProvided.RowCount >= 7)
                    dataGridViewServiceProvided.Height = dataGridViewServiceProvided.RowCount * 35;
                else
                    dataGridViewServiceProvided.Height = 210;
                         
            }
            else
                MessageBox.Show("Please Select Cost Centre To copy");
        }
    }
}
