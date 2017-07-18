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
    public partial class FormQuoteAccepted : Form
    {
        public FormQuoteAccepted()
        {
            InitializeComponent();
        }
        string updateItemno = string.Empty;
        bool IsBillok; 
        private void FormQuoteAccepted_Load(object sender, EventArgs e)
        {
            Btn_Update.Hide();
            DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
            DataTable myClient = connection.GetFullClient();
            foreach (DataRow row in myClient.Rows)
            {
                combobox_FirstName.Items.Add(row["FirstName"]);
                combobox_SurName.Items.Add(row["SurName"]);
                combobox_NdisNo.Items.Add(row["NDISNumber"]);
                combobox_CostCentre.Items.Add(row["CostCentre"]);
                Txt_BookingBy.Text = row["BookingBy"].ToString();
                //Txt_QuoteAcceptedDate.Text = row["QuoteAcceptDate"].ToString();
                //Txt_PlanId.Text = row["NDISPlanID"].ToString();

            }
            this.AcceptButton = Btn_SearchAddPlan;
            DataTable catTable = connection.GetSupportCatCode();
            comboBox_CatCode.DataSource = catTable;
            comboBox_CatCode.DisplayMember = "SupportCatCode";
            comboBox_CatCode.ValueMember = "SupportCatCode";
            comboBox_NDISBillablre.Items.Insert(0, "Select Yes/No");
            comboBox_NDISBillablre.Items.Insert(1, "Yes");
            comboBox_NDISBillablre.Items.Insert(1, "No");
            comboBox_CatCode.Text = "";
            Txt_SupportPurpose.Text = "";
            comboBox_SupportItem.Text = "";
            Txt_ItemNO.Text = "";
            Txt_CostPerHr.Text = "";
            Txt_UnitType.Text = "";
            

            //Load the custom datagrid column DataPropertyName..
            dataGridView_QuoteAccepted.AutoGenerateColumns = false;
            dataGridView_QuoteAccepted.Columns["SupportItemDescription"].DataPropertyName = "SupportItemDescription";
            dataGridView_QuoteAccepted.Columns["SupportItemNumber"].DataPropertyName = "SupportItemNumber";
            dataGridView_QuoteAccepted.Columns["Budget"].DataPropertyName = "Budget";
            dataGridView_QuoteAccepted.Columns["HoursPerDay"].DataPropertyName = "HoursPerDay";
            dataGridView_QuoteAccepted.Columns["NumberOfDaysPerWeek"].DataPropertyName = "NumberOfDaysPerWeek";
            dataGridView_QuoteAccepted.Columns["HoursPerWeek"].DataPropertyName = "HoursPerWeek";
            dataGridView_QuoteAccepted.Columns["CostPerHour"].DataPropertyName = "CostPerHour";
            dataGridView_QuoteAccepted.Columns["WeeksPerYear"].DataPropertyName = "WeeksPerYear";
            dataGridView_QuoteAccepted.Columns["TotalCost"].DataPropertyName = "TotalCost";
            dataGridView_QuoteAccepted.Columns["DiffToBudget"].DataPropertyName = "DiffToBudget";
            dataGridView_QuoteAccepted.Columns["NDISNumber"].DataPropertyName = "NDISNumber";
            dataGridView_QuoteAccepted.Columns["NDISBillable"].DataPropertyName = "NDISBillable";
        }

        private void SelectedValueSearch()
        {
            DataTable clientTable;
            DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
            if (combobox_NdisNo.Text == "" && combobox_FirstName.Text != "" && combobox_SurName.Text!="")
            {
                //int no = 0;
               // clientTable = connection.GetClient(no, combobox_FirstName.Text, combobox_SurName.Text);
                clientTable = connection.GetClientContactByFullName(combobox_FirstName.Text,combobox_SurName.Text);
                combobox_FirstName.Items.Clear();
                combobox_NdisNo.Items.Clear();
                combobox_SurName.Items.Clear();
                combobox_CostCentre.Items.Clear();
                foreach (DataRow row in clientTable.Rows)
                {
                    combobox_FirstName.Items.Add(row["FirstName"].ToString());
                    combobox_SurName.Items.Add(row["SurName"].ToString());
                    combobox_NdisNo.Items.Add(row["NDISNumber"].ToString());
                     combobox_NdisNo.Text=row["NDISNumber"].ToString();
                    combobox_CostCentre.Items.Add(row["CostCentre"].ToString());
                    combobox_CostCentre.Text = row["CostCentre"].ToString();
                    Txt_BookingBy.Text = row["BookingBy"].ToString();
                    DateTimePicker_QuoteAcceptDate.Text = row["QuoteAcceptDate"].ToString();
                    Txt_PlanId.Text = row["NDISPlanID"].ToString();
                }
            }
            else if (combobox_NdisNo.Text != "" && combobox_FirstName.Text == "" && combobox_SurName.Text == "")
            {
                clientTable = connection.GetClientByNdisNo(Convert.ToInt64(combobox_NdisNo.Text));
                combobox_FirstName.Items.Clear();
                combobox_NdisNo.Items.Clear();
                combobox_SurName.Items.Clear();
                combobox_CostCentre.Items.Clear();
                foreach (DataRow row in clientTable.Rows)
                {
                    combobox_FirstName.Items.Add(row["FirstName"].ToString());
                    combobox_SurName.Items.Add(row["SurName"].ToString());
                    combobox_NdisNo.Items.Add(row["NDISNumber"].ToString());
                    combobox_CostCentre.Items.Add(row["CostCentre"].ToString());
                    Txt_BookingBy.Text = row["BookingBy"].ToString();
                    DateTimePicker_QuoteAcceptDate.Text = row["QuoteAcceptDate"].ToString();
                    Txt_PlanId.Text = row["NDISPlanID"].ToString();
                }
            }
                //clientTable = connection.GetClient(Convert.ToInt64(combobox_NdisNo.Text), combobox_FirstName.Text, combobox_SurName.Text);
           

           
        }

        private void combobox_SurName_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectedValueSearch();
        }

        private void combobox_FirstName_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectedValueSearch();
        }

        private void combobox_NdisNo_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable clientTable;
            DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
            clientTable = connection.GetClientByNdisNo(Convert.ToInt64(combobox_NdisNo.Text));
            combobox_FirstName.Items.Clear();
            combobox_NdisNo.Items.Clear();
            combobox_SurName.Items.Clear();
            combobox_CostCentre.Items.Clear();
            foreach (DataRow row in clientTable.Rows)
            {
                combobox_FirstName.Items.Add(row["FirstName"].ToString());
                combobox_FirstName.Text = row["FirstName"].ToString();
                combobox_SurName.Items.Add(row["SurName"].ToString());
                combobox_SurName.Text = row["SurName"].ToString();
                combobox_NdisNo.Items.Add(row["NDISNumber"].ToString());
                combobox_CostCentre.Items.Add(row["CostCentre"].ToString());
                combobox_CostCentre.Text = row["CostCentre"].ToString();
                Txt_BookingBy.Text = row["BookingBy"].ToString();
                DateTimePicker_QuoteAcceptDate.Text = row["QuoteAcceptDate"].ToString();
                Txt_PlanId.Text = row["NDISPlanID"].ToString();
            }
        }

        private void ShowGridTotal()
        {
            //Show the Sum of Budget,TotalCost and DiffToBudget in datagridview1 last row..
            int sumRow = dataGridView_QuoteAccepted.RowCount - 1;
            decimal sumBudget = 0, sumTotalCost = 0, sumDiffToBudget = 0;
            string itemCheck = string.Empty;
            // string textCode = string.Empty;
            string checkCode = string.Empty;
            string matchingRow = string.Empty;
            for (int x = 0; x < dataGridView_QuoteAccepted.Rows.Count - 1; ++x)
            {
                for (int z = x + 1; z < dataGridView_QuoteAccepted.Rows.Count; ++z)
                {
                    // Use list[x] and list[z]
                    if (dataGridView_QuoteAccepted.Rows[x].Cells[2].Value != null && dataGridView_QuoteAccepted.Rows[x].Cells[8].Value != null && dataGridView_QuoteAccepted.Rows[x].Cells[9].Value != null)
                    {
                        if (dataGridView_QuoteAccepted.Rows[x].Cells[1].Value != null)
                        {
                            string s = dataGridView_QuoteAccepted.Rows[x].Cells[1].Value.ToString();
                            itemCheck = s.Substring(0, 2);
                        }
                        if (dataGridView_QuoteAccepted.Rows[z].Cells[1].Value != null)
                        {
                            string s1 = dataGridView_QuoteAccepted.Rows[z].Cells[1].Value.ToString();
                            checkCode = s1.Substring(0, 2);
                        }
                        if (itemCheck == checkCode)
                        {
                            matchingRow += z.ToString() + ",";
                        }
                        itemCheck = "";
                        checkCode = "";

                    }
                }
            }
            string[] rows = matchingRow.Split(',');
            for (int i = 0; i < dataGridView_QuoteAccepted.Rows.Count; ++i)
            {
                if (dataGridView_QuoteAccepted.Rows[i].Cells[2].Value != DBNull.Value && dataGridView_QuoteAccepted.Rows[i].Cells[8].Value != DBNull.Value && dataGridView_QuoteAccepted.Rows[i].Cells[9].Value != DBNull.Value)
                {
                    if (!rows.Contains(i.ToString()))
                    {
                        sumBudget += Convert.ToDecimal(dataGridView_QuoteAccepted.Rows[i].Cells[2].Value);
                    }
                    sumTotalCost += Convert.ToDecimal(dataGridView_QuoteAccepted.Rows[i].Cells[8].Value);
                    //sumDiffToBudget += Convert.ToDecimal(dataGridView_QuoteAccepted.Rows[i].Cells[9].Value);
                }
            }
            sumDiffToBudget = sumBudget - sumTotalCost;
            dataGridView_QuoteAccepted.Rows[sumRow].Cells[1].Value = "Sum";
            dataGridView_QuoteAccepted.Rows[sumRow].Cells[1].Style.BackColor = Color.RosyBrown;
            dataGridView_QuoteAccepted.Rows[sumRow].Cells[0].Style.BackColor = Color.RosyBrown;
            dataGridView_QuoteAccepted.Rows[sumRow].Cells[2].Value = sumBudget;
            dataGridView_QuoteAccepted.Rows[sumRow].Cells[2].Style.ForeColor = Color.Green;
            dataGridView_QuoteAccepted.Rows[sumRow].Cells[8].Value = sumTotalCost;
            dataGridView_QuoteAccepted.Rows[sumRow].Cells[8].Style.ForeColor = Color.Green;
            dataGridView_QuoteAccepted.Rows[sumRow].Cells[9].Value = sumDiffToBudget;
            if (sumDiffToBudget > 0)
                dataGridView_QuoteAccepted.Rows[sumRow].Cells[9].Style.ForeColor = Color.Green;
            else
                dataGridView_QuoteAccepted.Rows[sumRow].Cells[9].Style.ForeColor = Color.Red;
        }

        private void Btn_SearchAddPlan_Click(object sender, EventArgs e)
        {
            DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
            if (string.IsNullOrEmpty(combobox_NdisNo.Text) || combobox_NdisNo.Text == "0" || combobox_FirstName.Text != "" || combobox_SurName.Text != "")
            {
                DataTable clientPlanTable = connection.GetClientPlanByName(combobox_FirstName.Text, combobox_SurName.Text);
                //foreach (DataRow dr in clientPlanTable.Rows)
                //{
                //    Txt_NDISNo.Text = dr["NDISNumber"].ToString();
                //    break;
                //}
                dataGridView_QuoteAccepted.DataSource = clientPlanTable; 
                ClearData();
            }
            else
            {
                DataTable clientPlanNo = connection.GetClientPlan(Convert.ToInt64(combobox_NdisNo.Text));
                //DataTable clientTable = connection.GetClient(Convert.ToInt64(Txt_NDISNo.Text), Txt_FirstName.Text, Txt_SurName.Text);
                //foreach (DataRow dr in clientTable.Rows)
                //{
                //    Txt_FirstName.Text = dr["FirstName"].ToString();
                //    Txt_SurName.Text = dr["SurName"].ToString();
                //    Txt_CostCentre.Text = dr["CostCentre"].ToString();
                //    break;
                //}
                dataGridView_QuoteAccepted.DataSource = clientPlanNo;
                ClearData();

            }
            ShowGridTotal();
            if (dataGridView_QuoteAccepted.RowCount >= 7)
                dataGridView_QuoteAccepted.Height = dataGridView_QuoteAccepted.RowCount * 35;
            else
                dataGridView_QuoteAccepted.Height = 210;
        }
        private void ClearData()
        {
            comboBox_CatCode.Text = "";
            Txt_SupportPurpose.Text = "";
            comboBox_SupportItem.Text = "";
            Txt_ItemNO.Text = "";
            comboBox_NDISBillablre.Text = "";
            Txt_Budget.Text = "";
            Txt_HrPerDay.Text = "";
            Txt_DaysPerWeek.Text = "";
            Txt_HrPerWeek.Text = "";
            Txt_CostPerHr.Text = "";
            Txt_WeeksPerYr.Text = "";
            Txt_TotalCost.Text = "";
            Txt_DiffToBudget.Text = "";
        }

        private void comboBox_CatCode_SelectedValueChanged(object sender, EventArgs e)
        {

            string cval = comboBox_CatCode.Text;
            if (cval != "System.Data.DataRowView")
            {
                DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                Dictionary<string, List<string>> supportPurposeItem;
                supportPurposeItem = connection.GetSupportPurposeAndItemNo(comboBox_CatCode.Text);
                List<string> supportPurpose = supportPurposeItem["Purpose"];
                List<string> supportItem = supportPurposeItem["ItemNumber"];
                List<string> distinctPurpose = supportPurpose.Distinct().ToList();
                if (distinctPurpose.Count == 0)
                {
                    MessageBox.Show("GDS CURRENTLY DOES NOT SUPPORT ITEM WITH A CODE:" + " " + comboBox_CatCode.Text);
                }

                else
                    foreach (string s in distinctPurpose)
                        Txt_SupportPurpose.Text = s;

                comboBox_SupportItem.DataSource = supportItem;
                //comboBox_SupportItem.DisplayMember = "SupportItem";
                //comboBox_SupportItem.ValueMember = "SupportItem";
            }
        }

        private void comboBox_SupportItem_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_SupportItem.Text != "")
            {
                DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                Dictionary<string, List<string>> supportItemNoPrice;
                supportItemNoPrice = connection.GetSupportItemPrice(comboBox_SupportItem.Text);
                List<string> itemNo = supportItemNoPrice["SupportItem"];
                foreach (string i in itemNo)
                    Txt_ItemNO.Text = i;
                List<string> price = supportItemNoPrice["Price"];
                foreach (string p in price)
                {
                    Txt_CostPerHr.Text = p;
                    if (!string.IsNullOrEmpty(Txt_CostPerHr.Text))
                        Txt_CostPerHr.ReadOnly = true;
                    else
                        Txt_CostPerHr.ReadOnly = false;
                }
                List<string> unitType = supportItemNoPrice["UnitType"];
                foreach (string u in unitType)
                {
                    Txt_UnitType.Text = u;
                }

            }
        }
        decimal hrpweek;
        decimal weekPYr;

        private void Txt_HrPerWeek_Leave(object sender, EventArgs e)
        {
            if (Txt_HrPerDay.Text != "" && Txt_DaysPerWeek.Text != "")
            {
                hrpweek = Convert.ToDecimal(Txt_HrPerDay.Text) * Convert.ToDecimal(Txt_DaysPerWeek.Text);
                Txt_HrPerWeek.Text = hrpweek.ToString();
            }

        }
        private void Txt_HrPerWeek_LostFocus(object sender, EventArgs e)
        {
            if (Txt_HrPerDay.Text != "" && Txt_DaysPerWeek.Text != "")
            {
                hrpweek = Convert.ToDecimal(Txt_HrPerDay.Text) * Convert.ToDecimal(Txt_DaysPerWeek.Text);
                Txt_HrPerWeek.Text = hrpweek.ToString();
            }
        }

        private void Txt_WeeksPerYr_LostFocus(object sender, EventArgs e)
        {
            if (Txt_HrPerWeek.Text != "" && Txt_CostPerHr.Text != "")
            {
                if (!string.IsNullOrEmpty(Txt_WeeksPerYr.Text))
                    weekPYr = Convert.ToDecimal(Txt_WeeksPerYr.Text);
                decimal total = hrpweek * Convert.ToDecimal(Txt_CostPerHr.Text) * weekPYr;
                Txt_TotalCost.Text = total.ToString();
                decimal diffBudget = Convert.ToDecimal(Txt_Budget.Text) - total;
                Txt_DiffToBudget.Text = diffBudget.ToString();
                if (Txt_DiffToBudget.Text.Contains('-'))
                    Txt_DiffToBudget.ForeColor = Color.Red;
                else
                    Txt_DiffToBudget.ForeColor = Color.Green;

                //Txt_DiffToBudget.BackColor = Color.White;
            }
        }

        private void dataGridView_QuoteAccepted_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView_QuoteAccepted.RowCount != 1)
            {
                if (dataGridView_QuoteAccepted.Rows[e.RowIndex].Cells[1].Value.ToString() == "Sum")
                {
                    return;
                }
                Btn_Update.Show();
                Txt_ItemNO.Text = dataGridView_QuoteAccepted.Rows[e.RowIndex].Cells[1].Value.ToString();
                updateItemno = dataGridView_QuoteAccepted.Rows[e.RowIndex].Cells[1].Value.ToString();
                Txt_Budget.Text = dataGridView_QuoteAccepted.Rows[e.RowIndex].Cells[2].Value.ToString();
                Txt_HrPerDay.Text = dataGridView_QuoteAccepted.Rows[e.RowIndex].Cells[3].Value.ToString();
                Txt_DaysPerWeek.Text = dataGridView_QuoteAccepted.Rows[e.RowIndex].Cells[4].Value.ToString();
                Txt_HrPerWeek.Text = dataGridView_QuoteAccepted.Rows[e.RowIndex].Cells[5].Value.ToString();
                Txt_CostPerHr.Text = dataGridView_QuoteAccepted.Rows[e.RowIndex].Cells[6].Value.ToString();
                Txt_WeeksPerYr.Text = dataGridView_QuoteAccepted.Rows[e.RowIndex].Cells[7].Value.ToString();
                Txt_TotalCost.Text = dataGridView_QuoteAccepted.Rows[e.RowIndex].Cells[8].Value.ToString();
                Txt_DiffToBudget.Text = dataGridView_QuoteAccepted.Rows[e.RowIndex].Cells[9].Value.ToString();
                combobox_NdisNo.Text = dataGridView_QuoteAccepted.Rows[e.RowIndex].Cells[10].Value.ToString();
                string isBillable = dataGridView_QuoteAccepted.Rows[e.RowIndex].Cells[11].Value.ToString();
                if (isBillable == "True")
                {
                    comboBox_NDISBillablre.Text = "Yes";
                    IsBillok = true;
                }
                else if (isBillable == "False")
                {
                    comboBox_NDISBillablre.Text = "No";
                    IsBillok = false;
                }
                
                DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                DataTable cTable = connection.GetCatCodePurposeByItemNo(Txt_ItemNO.Text);
                foreach (DataRow cRow in cTable.Rows)
                {
                    comboBox_CatCode.Text = cRow["SupportCatCode"].ToString();
                    Txt_SupportPurpose.Text = cRow["SupportPurpose"].ToString();
                }
                comboBox_SupportItem.Text = dataGridView_QuoteAccepted.Rows[e.RowIndex].Cells[0].Value.ToString();
                //Show the Sum of Budget,TotalCost and DiffToBudget in datagridview1 last row..
                ShowGridTotal();
            }
        }
        BusinessLogic.ParticipantPlanInfo plan = new BusinessLogic.ParticipantPlanInfo();
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(combobox_NdisNo.Text))
                MessageBox.Show("NDIS NO is Empty");
            else
            {
                //Check if its updating the same record..
                bool billValue = false;
                if (comboBox_NDISBillablre.Text == "Yes")
                    billValue = true;
                else if (comboBox_NDISBillablre.Text == "No")
                    billValue = false;
                System.Int64 pNo = Convert.ToInt64((combobox_NdisNo.Text));
                DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                DataTable billTable = connection.GetClientPlanByNoItemBillable(pNo, Txt_ItemNO.Text, billValue);
                string ds = string.Empty;
                bool newBillable = false;
                string ndisBillable = string.Empty;
                string itemNo = string.Empty;
                foreach (DataRow dr in billTable.Rows)
                {
                    ds = dr["NDISNumber"].ToString();
                    // newBillable = dr["NDISBillable"].ToString();
                    newBillable = Convert.ToBoolean(dr["NDISBillable"]);
                    itemNo = dr["SupportItemNumber"].ToString();
                    if (ds == combobox_NdisNo.Text && newBillable.Equals(billValue) && itemNo == Txt_ItemNO.Text && !newBillable.Equals(IsBillok))
                    {
                       MessageBox.Show("Record already exist for this client with the same support item no and billable value.\n You can't change NDIS Bilable value");
                         return;
 
                    }
                    //break;
                }
                plan.NdisNumber = Convert.ToInt64((combobox_NdisNo.Text));
                plan.SupportItemNo = Txt_ItemNO.Text;
                plan.Budget = Convert.ToDecimal(Txt_Budget.Text);
                plan.HoursPerDay = Convert.ToDecimal(Txt_HrPerDay.Text);
                plan.NumberOfDaysPerWeek = Convert.ToInt32(Txt_DaysPerWeek.Text);
                plan.HoursPerWeek = Convert.ToDecimal(Txt_HrPerWeek.Text);
                plan.CostPerHour = Convert.ToDecimal(Txt_CostPerHr.Text);
                plan.WeeksPerYear = Convert.ToInt32(Txt_WeeksPerYr.Text);
                plan.TotalCost = Convert.ToDecimal(Txt_TotalCost.Text);
                plan.DifferenceToBudget = Convert.ToDecimal(Txt_DiffToBudget.Text);
                if (comboBox_NDISBillablre.Text == "Yes")
                    plan.NdisBillable = Convert.ToBoolean(1);
                else if (comboBox_NDISBillablre.Text == "No")
                    plan.NdisBillable = Convert.ToBoolean(0);
               // DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                connection.UpdatePlanInfo(plan, updateItemno);
                // DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                DataTable clientPlanTable = connection.GetClientPlanByName(combobox_FirstName.Text, combobox_SurName.Text);
                dataGridView_QuoteAccepted.DataSource = clientPlanTable;
                ShowGridTotal();
                ClearData();
            }
            if (dataGridView_QuoteAccepted.RowCount >= 7)
                dataGridView_QuoteAccepted.Height = dataGridView_QuoteAccepted.RowCount * 35;
            else
                dataGridView_QuoteAccepted.Height = 210;
        }

        private void Btn_QuoteAccepted_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to update client and accept the quote", "Quote Acceptance", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {

                if (!string.IsNullOrEmpty(combobox_NdisNo.Text))
                {
                    DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                    connection.UpdateClientQuote(DateTimePicker_QuoteAcceptDate.Text, Convert.ToInt64(Txt_PlanId.Text), Txt_BookingBy.Text, Convert.ToInt64(combobox_NdisNo.Text));
                    DataTable clientQuote = connection.GetClientByNdisNo(Convert.ToInt64(combobox_NdisNo.Text));
                    foreach (DataRow row in clientQuote.Rows)
                    {
                        Txt_BookingBy.Text = row["BookingBy"].ToString();
                        DateTimePicker_QuoteAcceptDate.Text = row["QuoteAcceptDate"].ToString();
                        Txt_PlanId.Text = row["NDISPlanID"].ToString();
                    }
                }
                else
                    MessageBox.Show("No Client NDIS No to Accept the Quote");

            }

        }

        private void Txt_PlanId_TextChanged(object sender, EventArgs e)
        {
            System.Int64 parseValue;
            if (!string.IsNullOrEmpty(Txt_PlanId.Text))
            {
                if (!System.Int64.TryParse(Txt_PlanId.Text, out parseValue))
                {
                    MessageBox.Show("Please Enter Numbers Only");
                    return;
                }
            }
        }

        private void Btn_ExitQuote_Click(object sender, EventArgs e)
        {
            Form_Client clientform = new Form_Client();
            clientform.MdiParent = this.ParentForm;
            clientform.Dock = DockStyle.Fill;
            clientform.WindowState = FormWindowState.Maximized;
            this.Close();
            clientform.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://myplace.ndis.gov.au");
        }

    }
}
