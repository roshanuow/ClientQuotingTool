using System;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace ClientQuoting
{
    public partial class Form_Client : Form
    {
        int eventFiredNo = 0;
        int eventFireName = 0;
        public Form_Client()
        {
            InitializeComponent();
        }
        BusinessLogic.Clients clients = new BusinessLogic.Clients();
        BusinessLogic.ClientContacts contacts = new BusinessLogic.ClientContacts();
        private void Form_CLient_Load(object sender, EventArgs e)
        {
            DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection(); 
            DataTable CostCode = connection.GetCostCentre();
            //Combobox_CostCentre.DataSource = CostCode;
            foreach (DataRow dr in CostCode.Rows)
            {
                Combobox_CostCentre.Items.Add(dr["CostCode"].ToString() + ' ' + dr["CostDescription"].ToString());
            }
            Combobox_CostCentre.Text = "Select Cost Centre";
            LbleNote.Text = "Note: All the fields marked with red asteriks are required field only if you want to create a plan for a new client" + Environment.NewLine + "If you want to search the existing client's plan you don't need to fill the forms";
            LbleNote.Font = new Font(LbleNote.Font.Name, 10, FontStyle.Bold | FontStyle.Underline);
            LbleNote.ForeColor = Color.Brown;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_AddRow_Click(object sender, EventArgs e)
        {
            //string ndisNo = string.Empty;
            //clients = new BusinessLogic.Clients();
            System.Int64 parseValue;
            //if (!string.IsNullOrEmpty(Txt_NDISNo.Text))
            //{
            //    if (!System.Int64.TryParse(Txt_NDISNo.Text, out parseValue))
            //    {
            //        MessageBox.Show("Please Enter Numbers Only");
            //        return;
            //    }
            //    else
            //    {
                    //clients.NdisNumber = Convert.ToInt64(Txt_NDISNo.Text);
            //        DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
            //        DataTable clientNoTable = connection.GetClientPlan(Convert.ToInt64(Txt_NDISNo.Text));
            //        foreach (DataRow dr in clientNoTable.Rows)
            //        {
            //            ndisNo=dr["NDISNumber"].ToString();
            //            break;
            //        }
            //            if (Txt_NDISNo.Text == ndisNo)
            //            {
            //                DialogResult result = MessageBox.Show("This NDIS Number already exists,would you like to edit the plan", "NDIS NO exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //                if (result == DialogResult.No)
            //                {
            //                    Txt_NDISNo.Focus();
            //                    return;
            //                }

            //          }               
            //    }
            //}
            //else
            //{
            //    //DialogResult result = MessageBox.Show("NDIS NO is compulsory if You are a new client along with all other information presented\n and click cancel. But if you just want to proceed with vieweing the client plan click ok.", "NDISNO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //    //if (result == DialogResult.Cancel)
            //    //    return;
            //}
            if (System.Int64.TryParse(Txt_NDISNo.Text, out parseValue))
            {
                clients.NdisNumber = Convert.ToInt64(Txt_NDISNo.Text);
            }
            
            clients.FirstName = Txt_FirstName.Text;
            clients.Surname = Txt_Surname.Text;
            clients.Address1 = Txt_ParticipantAddress1.Text;
            clients.Address2 = Txt_ParticipantAddress2.Text;
            clients.State = Txt_participantState.Text;
            clients.PostCode = Txt_ParticipantPostCode.Text;
            clients.HomePhone = Txt_ParticipantHomePhone.Text;
            clients.MobilePhone = Txt_ParticipantMobile.Text;
            clients.ExistingClient = checkbox_IsExistingClient.Checked;
            clients.CreatedBy = Txt_CreatedBy.Text;
            clients.ApprovedBy = Txt_ApprovedBy.Text;
            clients.PlanStartDate = DateTimePicker_PlanStartDate.Text;
            clients.PlanEndtDate = DateTimerPicker_PlanEndDate.Text;
            if (string.IsNullOrEmpty(Combobox_CostCentre.Text) || Combobox_CostCentre.Text=="Select Cost Centre")
            {
                //MessageBox.Show("Cost Center cannot be empty");
               // return;
                
            }
            else
            clients.CostCentre = Convert.ToInt32(Combobox_CostCentre.Text.Substring(0, Combobox_CostCentre.Text.IndexOf(' ')));
            contacts = new BusinessLogic.ClientContacts();
            contacts.ContactFirstName = Txt_ContactName.Text;
            contacts.ContactMiddleName = Txt_ContactMiddleName.Text;
            contacts.ContactSurname = Txt_ContactSurname.Text;
            contacts.ContactMobileNo = Txt_ContactPhone.Text;
            contacts.Email = Txt_ContactEmail.Text;
            contacts.Realtionship = Txt_Relationship.Text;
            if (!string.IsNullOrEmpty(Txt_NDISNo.Text))
            contacts.NdisNumber = Convert.ToInt64(Txt_NDISNo.Text);
            if (clients.FirstName=="" || clients.Surname=="" || Combobox_CostCentre.Text=="")
            {
                DialogResult objResult = MessageBox.Show("Compulsory fields are empty.\n Are you sure you just want to edit the existing client's plan", "Client Plan Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (objResult == DialogResult.Cancel)
                     return;
            }
            FormClientPlan cPlan = new FormClientPlan(clients, contacts);
            cPlan.MdiParent = this.ParentForm;
            cPlan.Dock = DockStyle.Fill;
            cPlan.WindowState = FormWindowState.Maximized;
            cPlan.Show();
            
          
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Do you want to exit the application", "Application Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               // this.Close();
                //this.ParentForm.Close();
                Application.Exit();
            }
        }

        private void Txt_NDISNo_TextChanged(object sender, EventArgs e)
        {
            eventFiredNo++;
            string ndisNo = string.Empty;
            clients = new BusinessLogic.Clients();
            System.Int64 parseValue;
            if (!string.IsNullOrEmpty(Txt_NDISNo.Text))
            {
                if (!System.Int64.TryParse(Txt_NDISNo.Text, out parseValue))
                {
                    MessageBox.Show("Please Enter Numbers Only");
                    return;
                }
                else
                {
                    clients.NdisNumber = Convert.ToInt64(Txt_NDISNo.Text);
                    DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                    DataTable clientNoTable = connection.GetClientPlan(Convert.ToInt64(Txt_NDISNo.Text));
                    foreach (DataRow dr in clientNoTable.Rows)
                    {
                        ndisNo = dr["NDISNumber"].ToString();
                        break;
                    }
                    if (Txt_NDISNo.Text == ndisNo && eventFireName==0)
                    {
                        DialogResult result = MessageBox.Show("This NDIS Number already exists,would you like to edit the plan", "NDIS NO exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            DataTable clientContactTable = connection.GetClientContactByNdisNo(Convert.ToInt64(Txt_NDISNo.Text));
                            foreach (DataRow cRow in clientContactTable.Rows)
                            {
                                Txt_Surname.Text = cRow["SurName"].ToString();
                                Txt_FirstName.Text = cRow["FirstName"].ToString();
                                Txt_ParticipantAddress1.Text = cRow["Address 1"].ToString();
                                Txt_ParticipantAddress2.Text = cRow["Address 2"].ToString();
                                Txt_participantState.Text = cRow["State"].ToString();
                                Txt_ParticipantPostCode.Text = cRow["PostCode"].ToString();
                                Txt_ParticipantHomePhone.Text = cRow["HomePhone"].ToString();
                                Txt_ParticipantMobile.Text = cRow["MobilePhone"].ToString();
                                checkbox_IsExistingClient.Checked = Convert.ToBoolean(cRow["ExistingClient"]);
                                Txt_CreatedBy.Text = cRow["CreatedBy"].ToString();
                                Txt_ApprovedBy.Text = cRow["ApprovedBy"].ToString();
                                DateTimePicker_PlanStartDate.Text = cRow["PlanStartDate"].ToString();
                                DateTimerPicker_PlanEndDate.Text = cRow["PlanEndDate"].ToString();
                                Txt_ApprovedBy.Text = cRow["ApprovedBy"].ToString();
                                Txt_ContactName.Text = cRow["FirstName1"].ToString();
                                Txt_ContactMiddleName.Text = cRow["MiddleName"].ToString();
                                Txt_ContactSurname.Text = cRow["SurName1"].ToString();
                                Txt_ContactPhone.Text = cRow["PhoneNumber"].ToString();
                                Txt_Relationship.Text = cRow["ClientRelationship"].ToString();
                                Txt_ContactEmail.Text = cRow["Email"].ToString();
                                Combobox_CostCentre.Text = cRow["CostCentre"].ToString() + " " + cRow["CostDescription"].ToString();
                            }
                        }
                        else
                            //Txt_NDISNo.Focus();
                        return;
                    }
                }
            }
        }
        
        private void Txt_Surname_TextChanged(object sender, EventArgs e)
        {
            eventFireName++;
            if (!string.IsNullOrEmpty(Txt_Surname.Text) && !string.IsNullOrEmpty(Txt_FirstName.Text) && eventFiredNo==0)
            {
                DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                DataTable CFTable = connection.GetClientContactByFullName(Txt_FirstName.Text, Txt_Surname.Text);
                if (CFTable.Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("This Client with the provided FirstName,SurName already exists,would you like to edit the plan", "Client Name exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        foreach (DataRow cRow in CFTable.Rows)
                        {
                            //Txt_Surname.Text = cRow["SurName"].ToString();
                            //Txt_FirstName.Text = cRow["FirstName"].ToString();
                            Txt_NDISNo.Text= cRow["NDISNumber"].ToString();
                            Txt_ParticipantAddress1.Text = cRow["Address 1"].ToString();
                            Txt_ParticipantAddress2.Text = cRow["Address 2"].ToString();
                            Txt_participantState.Text = cRow["State"].ToString();
                            Txt_ParticipantPostCode.Text = cRow["PostCode"].ToString();
                            Txt_ParticipantHomePhone.Text = cRow["HomePhone"].ToString();
                            Txt_ParticipantMobile.Text = cRow["MobilePhone"].ToString();
                            checkbox_IsExistingClient.Checked = Convert.ToBoolean(cRow["ExistingClient"]);
                            Txt_CreatedBy.Text = cRow["CreatedBy"].ToString();
                            Txt_ApprovedBy.Text = cRow["ApprovedBy"].ToString();
                            DateTimePicker_PlanStartDate.Text = cRow["PlanStartDate"].ToString();
                            DateTimerPicker_PlanEndDate.Text = cRow["PlanEndDate"].ToString();
                            Txt_ApprovedBy.Text = cRow["ApprovedBy"].ToString();
                            Txt_ContactName.Text = cRow["FirstName1"].ToString();
                            Txt_ContactMiddleName.Text = cRow["MiddleName"].ToString();
                            Txt_ContactSurname.Text = cRow["SurName1"].ToString();
                            Txt_ContactPhone.Text = cRow["PhoneNumber"].ToString();
                            Txt_Relationship.Text = cRow["ClientRelationship"].ToString();
                            Txt_ContactEmail.Text = cRow["Email"].ToString();
                            Combobox_CostCentre.Text = cRow["CostCentre"].ToString() + " " + cRow["CostDescription"].ToString();
                        }
                    }
                    else
                        Txt_Surname.Focus();
                }
            }
        }

        private void Txt_FirstName_TextChanged(object sender, EventArgs e)
        {
            eventFireName++;
            if (!string.IsNullOrEmpty(Txt_Surname.Text) && !string.IsNullOrEmpty(Txt_FirstName.Text) && eventFiredNo == 0)
            {
                DatabaseConnection.DBConnection connection = new DatabaseConnection.DBConnection();
                DataTable CFTable = connection.GetClientContactByFullName(Txt_FirstName.Text, Txt_Surname.Text);
                if (CFTable.Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("This Client with the provided FirstName,SurName already exists,would you like to edit the plan", "Client Name exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        foreach (DataRow cRow in CFTable.Rows)
                        {
                            //Txt_Surname.Text = cRow["SurName"].ToString();
                            //Txt_FirstName.Text = cRow["FirstName"].ToString();
                            Txt_NDISNo.Text = cRow["NDISNumber"].ToString();
                            Txt_ParticipantAddress1.Text = cRow["Address 1"].ToString();
                            Txt_ParticipantAddress2.Text = cRow["Address 2"].ToString();
                            Txt_participantState.Text = cRow["State"].ToString();
                            Txt_ParticipantPostCode.Text = cRow["PostCode"].ToString();
                            Txt_ParticipantHomePhone.Text = cRow["HomePhone"].ToString();
                            Txt_ParticipantMobile.Text = cRow["MobilePhone"].ToString();
                            checkbox_IsExistingClient.Checked = Convert.ToBoolean(cRow["ExistingClient"]);
                            Txt_CreatedBy.Text = cRow["CreatedBy"].ToString();
                            Txt_ApprovedBy.Text = cRow["ApprovedBy"].ToString();
                            DateTimePicker_PlanStartDate.Text = cRow["PlanStartDate"].ToString();
                            DateTimerPicker_PlanEndDate.Text = cRow["PlanEndDate"].ToString();
                            Txt_ApprovedBy.Text = cRow["ApprovedBy"].ToString();
                            Txt_ContactName.Text = cRow["FirstName1"].ToString();
                            Txt_ContactMiddleName.Text = cRow["MiddleName"].ToString();
                            Txt_ContactSurname.Text = cRow["SurName1"].ToString();
                            Txt_ContactPhone.Text = cRow["PhoneNumber"].ToString();
                            Txt_Relationship.Text = cRow["ClientRelationship"].ToString();
                            Txt_ContactEmail.Text = cRow["Email"].ToString();
                            Combobox_CostCentre.Text = cRow["CostCentre"].ToString() + " " + cRow["CostDescription"].ToString();
                        }
                    }
                    else
                    Txt_Surname.Focus();
                    return;
                }
            }
        }
    }
}
