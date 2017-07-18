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
    public partial class FormClientPlan : Form
    {
        // public  FormClientPlan()
        //{
        //     InitializeComponent();
        //}
         //List<BusinessLogic.Clients> myclient = new List<BusinessLogic.Clients>();
        string updateItemno = string.Empty;
        bool IsBillok;
        BusinessLogic.Clients clients1=new BusinessLogic.Clients();
        BusinessLogic.ClientContacts contacts1=new BusinessLogic.ClientContacts();

       
        public FormClientPlan(BusinessLogic.Clients clients,BusinessLogic.ClientContacts contacts)
        {
            clients1.NdisNumber =  clients.NdisNumber;
            clients1.FirstName = clients.FirstName;
           clients1.Surname= clients.Surname ;
            clients1.Address1=clients.Address1;
            clients1.Address2=clients.Address2 ;
           clients1.State= clients.State;
            clients1.PostCode=clients.PostCode;
           clients1.HomePhone= clients.HomePhone;
            clients1.MobilePhone=clients.MobilePhone; 
            clients1.ExistingClient=clients.ExistingClient; 
           clients1.CreatedBy= clients.CreatedBy;
            clients1.ApprovedBy=clients.ApprovedBy ;
           clients1.PlanStartDate= clients.PlanStartDate;
           clients1.PlanEndtDate = clients.PlanEndtDate;
           clients1.CostCentre = clients.CostCentre;
           //myclient.Add(clients1);

           contacts1.ContactFirstName = contacts.ContactFirstName;
           contacts1.ContactMiddleName= contacts.ContactMiddleName;
           contacts1.ContactSurname=contacts.ContactSurname;
           contacts1.ContactMobileNo=contacts.ContactMobileNo;
           contacts1.Email=contacts.Email;
           contacts1.Realtionship=contacts.Realtionship;
           contacts1.NdisNumber=contacts.NdisNumber;
           InitializeComponent();
           Txt_FirstName.Text = clients1.FirstName;
           Txt_SurName.Text = clients1.Surname;
           Txt_NDISNo.Text = clients1.NdisNumber.ToString();
           Txt_CostCentre.Text = clients1.CostCentre.ToString();          
        }
       

        private void Btn_SearchAddPlan_Click(object sender, EventArgs e)
        {
            //if (Txt_FirstName.Text != "" || Txt_SurName.Text != "")
            //{
                DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                if (string.IsNullOrEmpty(Txt_NDISNo.Text) || Txt_NDISNo.Text=="0" || Txt_FirstName.Text!="" || Txt_SurName.Text!="")
                {
                    DataTable clientPlanTable = connection.GetClientPlanByName(Txt_FirstName.Text, Txt_SurName.Text);
                    foreach (DataRow dr in clientPlanTable.Rows)
                    {
                        Txt_NDISNo.Text = dr["NDISNumber"].ToString();
                        break;
                    }
                    //This for posting cost centre in the textbox only...
                    DataTable clientTable = connection.GetClient(Convert.ToInt64(Txt_NDISNo.Text), Txt_FirstName.Text, Txt_SurName.Text);
                    foreach (DataRow dr in clientTable.Rows)
                    {
                        Txt_CostCentre.Text = dr["CostCentre"].ToString();
                        break;
                    }
                    dataGridView1.DataSource = clientPlanTable;
                    ClearData();
                }
                else
                {
                    DataTable clientPlanNo = connection.GetClientPlan(Convert.ToInt64(Txt_NDISNo.Text));
                    DataTable clientTable = connection.GetClient(Convert.ToInt64(Txt_NDISNo.Text), Txt_FirstName.Text, Txt_SurName.Text);
                    foreach (DataRow dr in clientTable.Rows)
                    {
                        Txt_FirstName.Text = dr["FirstName"].ToString();
                        Txt_SurName.Text = dr["SurName"].ToString();
                        Txt_CostCentre.Text=dr["CostCentre"].ToString();
                        break;
                    }
                    dataGridView1.DataSource = clientPlanNo;
                    ClearData();

                }
                if (dataGridView1.RowCount >= 7)
                    dataGridView1.Height = dataGridView1.RowCount * 35;
                else
                    dataGridView1.Height = 210;
            

            //Show the Sum of Budget,TotalCost and DiffToBudget in datagridview1 last row..
                ShowGridTotal();
            //}
            //foreach(var c in myclient)
            //MessageBox.Show(c.FirstName + c.NdisNumber);
           
        }

        private void ShowGridTotal()
        {
            //Show the Sum of Budget,TotalCost and DiffToBudget in datagridview1 last row..
            int sumRow = dataGridView1.RowCount - 1;
            decimal sumBudget = 0, sumTotalCost = 0, sumDiffToBudget = 0;
            string itemCheck = string.Empty;
           // string textCode = string.Empty;
            string checkCode = string.Empty;
            string matchingRow = string.Empty;
            for (int x = 0; x < dataGridView1.Rows.Count - 1; ++x)
            {
                for (int z = x + 1; z < dataGridView1.Rows.Count; ++z)
                {
                    // Use list[x] and list[z]
                    if (dataGridView1.Rows[x].Cells[2].Value != null && dataGridView1.Rows[x].Cells[8].Value != null && dataGridView1.Rows[x].Cells[9].Value != null)
                    {
                        if (dataGridView1.Rows[x].Cells[1].Value != null)
                        {
                            string s = dataGridView1.Rows[x].Cells[1].Value.ToString();
                            itemCheck = s.Substring(0, 2);
                        }
                        if (dataGridView1.Rows[z].Cells[1].Value != null)
                        {
                            string s1 = dataGridView1.Rows[z].Cells[1].Value.ToString();
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
            string[] rows=matchingRow.Split(',');
            for (int i = 0; i < dataGridView1.Rows.Count-1; ++i)
            {
                if (dataGridView1.Rows[i].Cells[2].Value != DBNull.Value && dataGridView1.Rows[i].Cells[8].Value != DBNull.Value && dataGridView1.Rows[i].Cells[9].Value != DBNull.Value)
                {
                    if (!rows.Contains(i.ToString()))
                    {
                        sumBudget += Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
                    }
                    sumTotalCost += Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value);
                    //sumDiffToBudget += Convert.ToDecimal(dataGridView1.Rows[i].Cells[9].Value);
                }
            }
            sumDiffToBudget = sumBudget - sumTotalCost;
            dataGridView1.Rows[sumRow].Cells[1].Value = "Sum";
                dataGridView1.Rows[sumRow].Cells[1].Style.BackColor = Color.RosyBrown;
                dataGridView1.Rows[sumRow].Cells[0].Style.BackColor = Color.RosyBrown;
                dataGridView1.Rows[sumRow].Cells[2].Value = sumBudget;
                dataGridView1.Rows[sumRow].Cells[2].Style.ForeColor = Color.Green;
                dataGridView1.Rows[sumRow].Cells[8].Value = sumTotalCost;
                dataGridView1.Rows[sumRow].Cells[8].Style.ForeColor = Color.Green;
                dataGridView1.Rows[sumRow].Cells[9].Value = sumDiffToBudget;
                if (sumDiffToBudget > 0)
                    dataGridView1.Rows[sumRow].Cells[9].Style.ForeColor = Color.Green;
                else
                    dataGridView1.Rows[sumRow].Cells[9].Style.ForeColor = Color.Red;
        }

        private void FormClientPlan_Load(object sender, EventArgs e)
        {
            
            
            Btn_Update.Hide();
            this.AcceptButton = Btn_SearchAddPlan;
            DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
            DataTable catTable=connection.GetSupportCatCode();
            comboBox_CatCode.DataSource = catTable;
            comboBox_CatCode.DisplayMember = "SupportCatCode";
            comboBox_CatCode.ValueMember = "SupportCatCode";
            comboBox_NDISBillablre.Items.Insert(0, "Select Yes/No");
            comboBox_NDISBillablre.Items.Insert(1, "Yes");
            comboBox_NDISBillablre.Items.Insert(2, "No");
            comboBox_CatCode.Text = "";
            Txt_SupportPurpose.Text = "";
            comboBox_SupportItem.Text = "";
            Txt_ItemNO.Text = "";
            Txt_CostPerHr.Text = "";
            if (clients1.NdisNumber == 0)
                Txt_NDISNo.Text = "";
            if (clients1.CostCentre == 0)
                Txt_CostCentre.Text = "";
            Txt_UnitType.Text = "";
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns["SupportItemDescription"].DataPropertyName = "SupportItemDescription";
            dataGridView1.Columns["SupportItemNumber"].DataPropertyName = "SupportItemNumber";
            dataGridView1.Columns["Budget"].DataPropertyName = "Budget";
            dataGridView1.Columns["HoursPerDay"].DataPropertyName = "HoursPerDay";
            dataGridView1.Columns["NumberOfDaysPerWeek"].DataPropertyName = "NumberOfDaysPerWeek";
            dataGridView1.Columns["HoursPerWeek"].DataPropertyName = "HoursPerWeek";
            dataGridView1.Columns["CostPerHour"].DataPropertyName = "CostPerHour";
            dataGridView1.Columns["WeeksPerYear"].DataPropertyName = "WeeksPerYear";
            dataGridView1.Columns["TotalCost"].DataPropertyName = "TotalCost";
            dataGridView1.Columns["DiffToBudget"].DataPropertyName = "DiffToBudget";
            dataGridView1.Columns["NDISNumber"].DataPropertyName = "NDISNumber";
            dataGridView1.Columns["NDISBillable"].DataPropertyName = "NDISBillable";    
        }

        BusinessLogic.ParticipantPlanInfo plan = new BusinessLogic.ParticipantPlanInfo();
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            //update the plan..

            if (string.IsNullOrEmpty(Txt_NDISNo.Text))
            {
                MessageBox.Show("NDIS NO is Empty");
                return;
            }

            else
            {
                
                //Check if its updating the same record..
                bool billValue = false;
                if (comboBox_NDISBillablre.Text == "Yes")
                    billValue = true;
                else if (comboBox_NDISBillablre.Text == "No")
                    billValue = false;
                System.Int64 pNo = Convert.ToInt64((Txt_NDISNo.Text));
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
                    if (ds == Txt_NDISNo.Text && newBillable.Equals(billValue) && itemNo == Txt_ItemNO.Text && !newBillable.Equals(IsBillok))
                    {
                       MessageBox.Show("Record already exist for this client with the same support item no and billable value.\n You can't change NDIS Bilable value");
                            return;
                    }
                    //break;
                }
                plan.NdisNumber = Convert.ToInt64((Txt_NDISNo.Text));
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
                    plan.NdisBillable = true;
                else if (comboBox_NDISBillablre.Text == "No")
                    plan.NdisBillable = false;
                //DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                connection.UpdatePlanInfo(plan, updateItemno);
                // DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                DataTable clientPlanTable = connection.GetClientPlanByName(Txt_FirstName.Text, Txt_SurName.Text);
                dataGridView1.DataSource = clientPlanTable;
                MessageBox.Show("Record Updatesuccessfully");
                ShowGridTotal();
                ClearData();
            }
            if (dataGridView1.RowCount >= 7)
                dataGridView1.Height = dataGridView1.RowCount * 35;
            else
                dataGridView1.Height = 210;
            //comboBox_NDISBillablre.Enabled = true;

        }

        private void comboBox_CatCode_SelectedValueChanged(object sender, EventArgs e)
        {

            string cval = comboBox_CatCode.Text;
            if(cval !="System.Data.DataRowView")
            {
                DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                Dictionary<string,List<string>> supportPurposeItem;
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

        private void Txt_HrPerDay_TextChanged(object sender, EventArgs e)
        {
            if (Txt_HrPerDay.Text != "" && Txt_DaysPerWeek.Text != "")
            {
                hrpweek = Convert.ToDecimal(Txt_HrPerDay.Text) * Convert.ToDecimal(Txt_DaysPerWeek.Text);
                Txt_HrPerWeek.Text = hrpweek.ToString();
            }
           
            if (Txt_HrPerWeek.Text != "" && Txt_CostPerHr.Text != "" && Txt_Budget.Text != "" && Txt_WeeksPerYr.Text != "")
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

        private void Txt_DaysPerWeek_TextChanged(object sender, EventArgs e)
        {
            if (Txt_HrPerDay.Text != "" && Txt_DaysPerWeek.Text != "")
            {
                hrpweek = Convert.ToDecimal(Txt_HrPerDay.Text) * Convert.ToDecimal(Txt_DaysPerWeek.Text);
                Txt_HrPerWeek.Text = hrpweek.ToString();
            }

            if (Txt_HrPerWeek.Text != "" && Txt_CostPerHr.Text != "" && Txt_Budget.Text != "" && Txt_WeeksPerYr.Text != "")
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

        private void Txt_Budget_TextChanged(object sender, EventArgs e)
        {
            if (Txt_HrPerWeek.Text != "" && Txt_CostPerHr.Text != "" && Txt_Budget.Text!="" && Txt_WeeksPerYr.Text!="")
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
   

        private void ClearData()
        {
            comboBox_CatCode.Text = "";
            Txt_SupportPurpose.Text = "";
            comboBox_SupportItem.Text = "";
            Txt_ItemNO.Text = "";
            comboBox_NDISBillablre.Text = "";
            Txt_Budget.Text = "";
            Txt_HrPerDay.Text = "";
            Txt_DaysPerWeek.Text="";
            Txt_HrPerWeek.Text="";
            Txt_CostPerHr.Text="";
            Txt_WeeksPerYr.Text="";
            Txt_TotalCost.Text="";
            Txt_DiffToBudget.Text="";
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (dataGridView1.RowCount != 1)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() == "Sum")
                {
                    return;
                }
                Btn_Update.Show();
                Txt_ItemNO.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                updateItemno = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Txt_Budget.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Txt_HrPerDay.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                Txt_DaysPerWeek.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                Txt_HrPerWeek.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                Txt_CostPerHr.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                Txt_WeeksPerYr.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                Txt_TotalCost.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                Txt_DiffToBudget.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                Txt_NDISNo.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                string isBillable = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
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
                comboBox_SupportItem.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                //Show the Sum of Budget,TotalCost and DiffToBudget in datagridview1 last row..
                ShowGridTotal();
                
            }
        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {

            int forcustomermessage = 0;
            if (string.IsNullOrEmpty(Txt_FirstName.Text) || string.IsNullOrEmpty(Txt_SurName.Text) || string.IsNullOrEmpty(Txt_NDISNo.Text))
            {
                return;
            }
            System.Int64 cNo=Convert.ToInt64((Txt_NDISNo.Text));
            bool billValue=false;
            if (comboBox_NDISBillablre.Text == "Yes")
                   billValue = true;
                else if (comboBox_NDISBillablre.Text == "No")
                    billValue = false;
            string mNO=string.Empty;
            DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
            DataTable ndisTable = connection.GetClientPlan(cNo);
            foreach (DataRow ndisRow in ndisTable.Rows)
            {
                mNO = ndisRow["NDISNumber"].ToString();
                break;
            }
            DataTable billTable = connection.GetClientPlanByNoItemBillable(cNo, Txt_ItemNO.Text, billValue);
            string ds = string.Empty;
            bool newBillable = false;
            string ndisBillable=string.Empty;
            string itemNo = string.Empty;
            foreach (DataRow dr in billTable.Rows)
            {
                ds= dr["NDISNumber"].ToString();
               // newBillable = dr["NDISBillable"].ToString();
                newBillable = Convert.ToBoolean(dr["NDISBillable"]);
                itemNo = dr["SupportItemNumber"].ToString();
                if (ds == Txt_NDISNo.Text && newBillable.Equals(billValue) && itemNo == Txt_ItemNO.Text)
                {
                    MessageBox.Show("Record already exist for this client with the same support item no and billable value\n You can only update the existing record");
                    return;
                }
                //break;
            }

           
           // if (ds == clients1.NdisNumber.ToString())
            if (mNO == Txt_NDISNo.Text)
            {
               // BusinessLogic.ParticipantPlanInfo plan = new BusinessLogic.ParticipantPlanInfo();
                if(!string.IsNullOrEmpty(Txt_NDISNo.Text))
                {
                plan.NdisNumber = Convert.ToInt64((Txt_NDISNo.Text));
                plan.SupportItemNo = Txt_ItemNO.Text;
                if (!string.IsNullOrEmpty(Txt_Budget.Text))
                {
                    plan.Budget = Convert.ToDecimal(Txt_Budget.Text);
                }
                if (string.IsNullOrEmpty(Txt_DiffToBudget.Text))
                {
                    MessageBox.Show("Please provided all the hours and budget to create a plan");
                    return;
                }
                if (!string.IsNullOrEmpty(Txt_HrPerDay.Text))
                plan.HoursPerDay = Convert.ToDecimal(Txt_HrPerDay.Text);
                if (!string.IsNullOrEmpty(Txt_DaysPerWeek.Text))
                plan.NumberOfDaysPerWeek = Convert.ToInt32(Txt_DaysPerWeek.Text);
                plan.HoursPerWeek = Convert.ToDecimal(Txt_HrPerWeek.Text);
                plan.CostPerHour = Convert.ToDecimal(Txt_CostPerHr.Text);
                plan.WeeksPerYear = Convert.ToInt32(Txt_WeeksPerYr.Text);
                plan.TotalCost = Convert.ToDecimal(Txt_TotalCost.Text);
                plan.DifferenceToBudget = Convert.ToDecimal(Txt_DiffToBudget.Text);
                if (comboBox_NDISBillablre.Text == "Yes")
                    plan.NdisBillable = true;
                else if (comboBox_NDISBillablre.Text == "No")
                    plan.NdisBillable = false;

                connection.InsertPlanInfo(plan);
                forcustomermessage = 1;
            }
            }
            else
            {
                if (clients1 == null || clients1.IsInitialized || contacts1 == null || contacts1.ContactIsInitialized)
                {
                    MessageBox.Show("Please fill all the required field in the Participant Plan Form to add client's info and create plan");
                    return;
                }
                string myc=contacts1.FirstName;
                connection.InsertClientInfo(clients1);
                connection.InsertContactInfo(contacts1);
               // BusinessLogic.ParticipantPlanInfo plan = new BusinessLogic.ParticipantPlanInfo();
                plan.NdisNumber = Convert.ToInt64((clients1.NdisNumber));
                plan.SupportItemNo = Txt_ItemNO.Text;
                if (!string.IsNullOrEmpty(Txt_Budget.Text))
                {
                    plan.Budget = Convert.ToDecimal(Txt_Budget.Text);
                }
                else
                    return;
               // plan.Budget = Convert.ToDecimal(Txt_Budget.Text);
                plan.HoursPerDay = Convert.ToDecimal(Txt_HrPerDay.Text);
                plan.NumberOfDaysPerWeek = Convert.ToInt32(Txt_DaysPerWeek.Text);
                plan.HoursPerWeek = Convert.ToDecimal(Txt_HrPerWeek.Text);
                plan.CostPerHour = Convert.ToDecimal(Txt_CostPerHr.Text);
                plan.WeeksPerYear = Convert.ToInt32(Txt_WeeksPerYr.Text);
                plan.TotalCost = Convert.ToDecimal(Txt_TotalCost.Text);
                plan.DifferenceToBudget = Convert.ToDecimal(Txt_DiffToBudget.Text);
                if (comboBox_NDISBillablre.Text == "Yes")
                    plan.NdisBillable = true;
                else if (comboBox_NDISBillablre.Text == "No")
                    plan.NdisBillable = false;

                connection.InsertPlanInfo(plan);
                forcustomermessage = 2;
            }
            DataTable clientPlanTable = connection.GetClientPlanByName(Txt_FirstName.Text, Txt_SurName.Text);
            dataGridView1.DataSource = clientPlanTable;
            if(forcustomermessage==1)
             MessageBox.Show("Client's Plan Inserted Successfully");
            if(forcustomermessage==2)
                MessageBox.Show("Client,Contact and Client's Plan Inserted Successfully");
            ShowGridTotal();
            ClearData();
            if (dataGridView1.RowCount >= 7)
                dataGridView1.Height = dataGridView1.RowCount * 35;
            else
                dataGridView1.Height = 210;
            
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            int row=dataGridView1.RowCount;
            bool bill=false;
            if (string.IsNullOrEmpty(Txt_ItemNO.Text))
                row = 0;
            if (row != 0)
            {
                DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                System.Int64 ndisNo = Convert.ToInt64(Txt_NDISNo.Text);
                if (comboBox_NDISBillablre.Text == "Yes")
                    bill = true;
                else if (comboBox_NDISBillablre.Text == "No")
                    bill = false;
                connection.DeletePlanInfo(Txt_ItemNO.Text, ndisNo,bill);
                DataTable clientPlanTable = connection.GetClientPlanByName(Txt_FirstName.Text, Txt_SurName.Text);
                dataGridView1.DataSource = clientPlanTable;
                MessageBox.Show("Selected row" + " " + row + "deleted successfully");
                ShowGridTotal();
                ClearData();
            }

            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
            if (dataGridView1.RowCount >= 7)
                dataGridView1.Height = dataGridView1.RowCount * 35;
            else
                dataGridView1.Height = 210;
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
        
    }
}
