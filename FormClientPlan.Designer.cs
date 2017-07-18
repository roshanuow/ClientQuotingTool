namespace ClientQuoting
{
    partial class FormClientPlan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientPlan));
            this.Lbl_CostCentre = new System.Windows.Forms.Label();
            this.Grpbox_ParticipantPlanInfo = new System.Windows.Forms.GroupBox();
            this.LblUnitType = new System.Windows.Forms.Label();
            this.Txt_UnitType = new System.Windows.Forms.TextBox();
            this.Lbl_DiffToBudget = new System.Windows.Forms.Label();
            this.Txt_DiffToBudget = new System.Windows.Forms.TextBox();
            this.Lbl_TotalCost = new System.Windows.Forms.Label();
            this.Txt_TotalCost = new System.Windows.Forms.TextBox();
            this.Lbl_weeksPerYr = new System.Windows.Forms.Label();
            this.Txt_WeeksPerYr = new System.Windows.Forms.TextBox();
            this.Lbl_CostPerHr = new System.Windows.Forms.Label();
            this.Txt_CostPerHr = new System.Windows.Forms.TextBox();
            this.Lbl_HrPerWeek = new System.Windows.Forms.Label();
            this.Txt_HrPerWeek = new System.Windows.Forms.TextBox();
            this.Lbl_DaysPerWeek = new System.Windows.Forms.Label();
            this.Txt_DaysPerWeek = new System.Windows.Forms.TextBox();
            this.HrpDay = new System.Windows.Forms.Label();
            this.Txt_HrPerDay = new System.Windows.Forms.TextBox();
            this.Lbl_budget = new System.Windows.Forms.Label();
            this.comboBox_NDISBillablre = new System.Windows.Forms.ComboBox();
            this.Lbl_NDISBillable = new System.Windows.Forms.Label();
            this.Lbl_SupportItemNo = new System.Windows.Forms.Label();
            this.comboBox_SupportItem = new System.Windows.Forms.ComboBox();
            this.Txt_ItemNO = new System.Windows.Forms.TextBox();
            this.Lbl_SupportItem = new System.Windows.Forms.Label();
            this.comboBox_CatCode = new System.Windows.Forms.ComboBox();
            this.Txt_Budget = new System.Windows.Forms.TextBox();
            this.Txt_SupportPurpose = new System.Windows.Forms.TextBox();
            this.Lbl_ParticipantAddress2 = new System.Windows.Forms.Label();
            this.Lbl_ParticipantsAddress1 = new System.Windows.Forms.Label();
            this.GrpboxParticipants = new System.Windows.Forms.GroupBox();
            this.Txt_CostCentre = new System.Windows.Forms.TextBox();
            this.Txt_NDISNo = new System.Windows.Forms.TextBox();
            this.Txt_FirstName = new System.Windows.Forms.TextBox();
            this.Txt_SurName = new System.Windows.Forms.TextBox();
            this.Lbl_FirstName = new System.Windows.Forms.Label();
            this.Lbl_NdisNo = new System.Windows.Forms.Label();
            this.Btn_SearchAddPlan = new System.Windows.Forms.Button();
            this.Lbl_Surname = new System.Windows.Forms.Label();
            this.Lbl_Banner_Name = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SupportItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupportItemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Budget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfDaysPerWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursPerWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeeksPerYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiffToBudget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDISNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDISBillable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Lbl_update = new System.Windows.Forms.Label();
            this.GrpBoxUnitNote = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_UnitNote = new System.Windows.Forms.Label();
            this.Btn_ExitQuote = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Insert = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Grpbox_ParticipantPlanInfo.SuspendLayout();
            this.GrpboxParticipants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GrpBoxUnitNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_CostCentre
            // 
            this.Lbl_CostCentre.AutoSize = true;
            this.Lbl_CostCentre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CostCentre.Location = new System.Drawing.Point(79, 177);
            this.Lbl_CostCentre.Name = "Lbl_CostCentre";
            this.Lbl_CostCentre.Size = new System.Drawing.Size(98, 17);
            this.Lbl_CostCentre.TabIndex = 14;
            this.Lbl_CostCentre.Text = "Cost Centre:";
            // 
            // Grpbox_ParticipantPlanInfo
            // 
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.LblUnitType);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Txt_UnitType);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Lbl_DiffToBudget);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Txt_DiffToBudget);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Lbl_TotalCost);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Txt_TotalCost);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Lbl_weeksPerYr);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Txt_WeeksPerYr);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Lbl_CostPerHr);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Txt_CostPerHr);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Lbl_HrPerWeek);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Txt_HrPerWeek);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Lbl_DaysPerWeek);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Txt_DaysPerWeek);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.HrpDay);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Txt_HrPerDay);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Lbl_budget);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.comboBox_NDISBillablre);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Lbl_NDISBillable);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Lbl_SupportItemNo);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.comboBox_SupportItem);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Txt_ItemNO);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Lbl_SupportItem);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.comboBox_CatCode);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Txt_Budget);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Txt_SupportPurpose);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Lbl_ParticipantAddress2);
            this.Grpbox_ParticipantPlanInfo.Controls.Add(this.Lbl_ParticipantsAddress1);
            this.Grpbox_ParticipantPlanInfo.Location = new System.Drawing.Point(26, 262);
            this.Grpbox_ParticipantPlanInfo.Name = "Grpbox_ParticipantPlanInfo";
            this.Grpbox_ParticipantPlanInfo.Size = new System.Drawing.Size(1140, 172);
            this.Grpbox_ParticipantPlanInfo.TabIndex = 20;
            this.Grpbox_ParticipantPlanInfo.TabStop = false;
            this.Grpbox_ParticipantPlanInfo.Text = "Participant Plan Info";
            // 
            // LblUnitType
            // 
            this.LblUnitType.AutoSize = true;
            this.LblUnitType.Location = new System.Drawing.Point(142, 74);
            this.LblUnitType.Name = "LblUnitType";
            this.LblUnitType.Size = new System.Drawing.Size(50, 13);
            this.LblUnitType.TabIndex = 34;
            this.LblUnitType.Text = "UnitType";
            // 
            // Txt_UnitType
            // 
            this.Txt_UnitType.BackColor = System.Drawing.Color.White;
            this.Txt_UnitType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_UnitType.Location = new System.Drawing.Point(200, 70);
            this.Txt_UnitType.Name = "Txt_UnitType";
            this.Txt_UnitType.ReadOnly = true;
            this.Txt_UnitType.Size = new System.Drawing.Size(70, 20);
            this.Txt_UnitType.TabIndex = 33;
            // 
            // Lbl_DiffToBudget
            // 
            this.Lbl_DiffToBudget.AutoSize = true;
            this.Lbl_DiffToBudget.Location = new System.Drawing.Point(975, 128);
            this.Lbl_DiffToBudget.Name = "Lbl_DiffToBudget";
            this.Lbl_DiffToBudget.Size = new System.Drawing.Size(70, 13);
            this.Lbl_DiffToBudget.TabIndex = 32;
            this.Lbl_DiffToBudget.Text = "DiffToBudget";
            // 
            // Txt_DiffToBudget
            // 
            this.Txt_DiffToBudget.BackColor = System.Drawing.Color.White;
            this.Txt_DiffToBudget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_DiffToBudget.Location = new System.Drawing.Point(1051, 126);
            this.Txt_DiffToBudget.Name = "Txt_DiffToBudget";
            this.Txt_DiffToBudget.ReadOnly = true;
            this.Txt_DiffToBudget.Size = new System.Drawing.Size(83, 20);
            this.Txt_DiffToBudget.TabIndex = 17;
            // 
            // Lbl_TotalCost
            // 
            this.Lbl_TotalCost.AutoSize = true;
            this.Lbl_TotalCost.Location = new System.Drawing.Point(806, 126);
            this.Lbl_TotalCost.Name = "Lbl_TotalCost";
            this.Lbl_TotalCost.Size = new System.Drawing.Size(52, 13);
            this.Lbl_TotalCost.TabIndex = 30;
            this.Lbl_TotalCost.Text = "TotalCost";
            // 
            // Txt_TotalCost
            // 
            this.Txt_TotalCost.BackColor = System.Drawing.Color.White;
            this.Txt_TotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_TotalCost.Location = new System.Drawing.Point(864, 121);
            this.Txt_TotalCost.Name = "Txt_TotalCost";
            this.Txt_TotalCost.ReadOnly = true;
            this.Txt_TotalCost.Size = new System.Drawing.Size(83, 20);
            this.Txt_TotalCost.TabIndex = 16;
            // 
            // Lbl_weeksPerYr
            // 
            this.Lbl_weeksPerYr.AutoSize = true;
            this.Lbl_weeksPerYr.Location = new System.Drawing.Point(663, 121);
            this.Lbl_weeksPerYr.Name = "Lbl_weeksPerYr";
            this.Lbl_weeksPerYr.Size = new System.Drawing.Size(67, 13);
            this.Lbl_weeksPerYr.TabIndex = 28;
            this.Lbl_weeksPerYr.Text = "WeeksPerYr";
            // 
            // Txt_WeeksPerYr
            // 
            this.Txt_WeeksPerYr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_WeeksPerYr.Location = new System.Drawing.Point(736, 119);
            this.Txt_WeeksPerYr.Name = "Txt_WeeksPerYr";
            this.Txt_WeeksPerYr.Size = new System.Drawing.Size(52, 20);
            this.Txt_WeeksPerYr.TabIndex = 15;
            this.Txt_WeeksPerYr.TextChanged += new System.EventHandler(this.Txt_WeeksPerYr_LostFocus);
            // 
            // Lbl_CostPerHr
            // 
            this.Lbl_CostPerHr.AutoSize = true;
            this.Lbl_CostPerHr.Location = new System.Drawing.Point(536, 121);
            this.Lbl_CostPerHr.Name = "Lbl_CostPerHr";
            this.Lbl_CostPerHr.Size = new System.Drawing.Size(63, 13);
            this.Lbl_CostPerHr.TabIndex = 26;
            this.Lbl_CostPerHr.Text = "CostPerUnit";
            // 
            // Txt_CostPerHr
            // 
            this.Txt_CostPerHr.BackColor = System.Drawing.Color.White;
            this.Txt_CostPerHr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_CostPerHr.Location = new System.Drawing.Point(605, 119);
            this.Txt_CostPerHr.Name = "Txt_CostPerHr";
            this.Txt_CostPerHr.Size = new System.Drawing.Size(52, 20);
            this.Txt_CostPerHr.TabIndex = 14;
            // 
            // Lbl_HrPerWeek
            // 
            this.Lbl_HrPerWeek.AutoSize = true;
            this.Lbl_HrPerWeek.Location = new System.Drawing.Point(409, 118);
            this.Lbl_HrPerWeek.Name = "Lbl_HrPerWeek";
            this.Lbl_HrPerWeek.Size = new System.Drawing.Size(50, 13);
            this.Lbl_HrPerWeek.TabIndex = 24;
            this.Lbl_HrPerWeek.Text = "TotalUnit";
            // 
            // Txt_HrPerWeek
            // 
            this.Txt_HrPerWeek.BackColor = System.Drawing.Color.White;
            this.Txt_HrPerWeek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_HrPerWeek.Location = new System.Drawing.Point(478, 114);
            this.Txt_HrPerWeek.Name = "Txt_HrPerWeek";
            this.Txt_HrPerWeek.ReadOnly = true;
            this.Txt_HrPerWeek.Size = new System.Drawing.Size(52, 20);
            this.Txt_HrPerWeek.TabIndex = 13;
            this.Txt_HrPerWeek.Click += new System.EventHandler(this.Txt_HrPerWeek_LostFocus);
            this.Txt_HrPerWeek.Leave += new System.EventHandler(this.Txt_HrPerWeek_Leave);
            // 
            // Lbl_DaysPerWeek
            // 
            this.Lbl_DaysPerWeek.AutoSize = true;
            this.Lbl_DaysPerWeek.Location = new System.Drawing.Point(269, 116);
            this.Lbl_DaysPerWeek.Name = "Lbl_DaysPerWeek";
            this.Lbl_DaysPerWeek.Size = new System.Drawing.Size(76, 13);
            this.Lbl_DaysPerWeek.TabIndex = 22;
            this.Lbl_DaysPerWeek.Text = "DaysPerWeek";
            // 
            // Txt_DaysPerWeek
            // 
            this.Txt_DaysPerWeek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_DaysPerWeek.Location = new System.Drawing.Point(351, 111);
            this.Txt_DaysPerWeek.Name = "Txt_DaysPerWeek";
            this.Txt_DaysPerWeek.Size = new System.Drawing.Size(52, 20);
            this.Txt_DaysPerWeek.TabIndex = 12;
            this.Txt_DaysPerWeek.TextChanged += new System.EventHandler(this.Txt_DaysPerWeek_TextChanged);
            // 
            // HrpDay
            // 
            this.HrpDay.AutoSize = true;
            this.HrpDay.Location = new System.Drawing.Point(137, 113);
            this.HrpDay.Name = "HrpDay";
            this.HrpDay.Size = new System.Drawing.Size(61, 13);
            this.HrpDay.TabIndex = 20;
            this.HrpDay.Text = "UnitPerDay";
            // 
            // Txt_HrPerDay
            // 
            this.Txt_HrPerDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_HrPerDay.Location = new System.Drawing.Point(200, 113);
            this.Txt_HrPerDay.Name = "Txt_HrPerDay";
            this.Txt_HrPerDay.Size = new System.Drawing.Size(59, 20);
            this.Txt_HrPerDay.TabIndex = 11;
            this.Txt_HrPerDay.TextChanged += new System.EventHandler(this.Txt_HrPerDay_TextChanged);
            // 
            // Lbl_budget
            // 
            this.Lbl_budget.AutoSize = true;
            this.Lbl_budget.Location = new System.Drawing.Point(6, 111);
            this.Lbl_budget.Name = "Lbl_budget";
            this.Lbl_budget.Size = new System.Drawing.Size(41, 13);
            this.Lbl_budget.TabIndex = 18;
            this.Lbl_budget.Text = "Budget";
            // 
            // comboBox_NDISBillablre
            // 
            this.comboBox_NDISBillablre.FormattingEnabled = true;
            this.comboBox_NDISBillablre.Location = new System.Drawing.Point(86, 66);
            this.comboBox_NDISBillablre.Name = "comboBox_NDISBillablre";
            this.comboBox_NDISBillablre.Size = new System.Drawing.Size(50, 21);
            this.comboBox_NDISBillablre.TabIndex = 9;
            // 
            // Lbl_NDISBillable
            // 
            this.Lbl_NDISBillable.AutoSize = true;
            this.Lbl_NDISBillable.Location = new System.Drawing.Point(8, 69);
            this.Lbl_NDISBillable.Name = "Lbl_NDISBillable";
            this.Lbl_NDISBillable.Size = new System.Drawing.Size(72, 13);
            this.Lbl_NDISBillable.TabIndex = 16;
            this.Lbl_NDISBillable.Text = "NDISBillable?";
            // 
            // Lbl_SupportItemNo
            // 
            this.Lbl_SupportItemNo.AutoSize = true;
            this.Lbl_SupportItemNo.Location = new System.Drawing.Point(927, 40);
            this.Lbl_SupportItemNo.Name = "Lbl_SupportItemNo";
            this.Lbl_SupportItemNo.Size = new System.Drawing.Size(78, 13);
            this.Lbl_SupportItemNo.TabIndex = 15;
            this.Lbl_SupportItemNo.Text = "SupportItemNo";
            // 
            // comboBox_SupportItem
            // 
            this.comboBox_SupportItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_SupportItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_SupportItem.FormattingEnabled = true;
            this.comboBox_SupportItem.Location = new System.Drawing.Point(455, 32);
            this.comboBox_SupportItem.Name = "comboBox_SupportItem";
            this.comboBox_SupportItem.Size = new System.Drawing.Size(473, 21);
            this.comboBox_SupportItem.TabIndex = 7;
            this.comboBox_SupportItem.SelectedValueChanged += new System.EventHandler(this.comboBox_SupportItem_SelectedValueChanged);
            // 
            // Txt_ItemNO
            // 
            this.Txt_ItemNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_ItemNO.Location = new System.Drawing.Point(1011, 37);
            this.Txt_ItemNO.Name = "Txt_ItemNO";
            this.Txt_ItemNO.Size = new System.Drawing.Size(124, 20);
            this.Txt_ItemNO.TabIndex = 8;
            // 
            // Lbl_SupportItem
            // 
            this.Lbl_SupportItem.AutoSize = true;
            this.Lbl_SupportItem.Location = new System.Drawing.Point(385, 32);
            this.Lbl_SupportItem.Name = "Lbl_SupportItem";
            this.Lbl_SupportItem.Size = new System.Drawing.Size(64, 13);
            this.Lbl_SupportItem.TabIndex = 12;
            this.Lbl_SupportItem.Text = "SupportItem";
            // 
            // comboBox_CatCode
            // 
            this.comboBox_CatCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_CatCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_CatCode.FormattingEnabled = true;
            this.comboBox_CatCode.Location = new System.Drawing.Point(69, 29);
            this.comboBox_CatCode.Name = "comboBox_CatCode";
            this.comboBox_CatCode.Size = new System.Drawing.Size(67, 21);
            this.comboBox_CatCode.TabIndex = 5;
            this.comboBox_CatCode.Text = "Select Code";
            this.comboBox_CatCode.SelectedValueChanged += new System.EventHandler(this.comboBox_CatCode_SelectedValueChanged);
            // 
            // Txt_Budget
            // 
            this.Txt_Budget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Budget.Location = new System.Drawing.Point(49, 107);
            this.Txt_Budget.Name = "Txt_Budget";
            this.Txt_Budget.Size = new System.Drawing.Size(83, 20);
            this.Txt_Budget.TabIndex = 10;
            this.Txt_Budget.TextChanged += new System.EventHandler(this.Txt_Budget_TextChanged);
            // 
            // Txt_SupportPurpose
            // 
            this.Txt_SupportPurpose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_SupportPurpose.Location = new System.Drawing.Point(217, 32);
            this.Txt_SupportPurpose.Name = "Txt_SupportPurpose";
            this.Txt_SupportPurpose.Size = new System.Drawing.Size(162, 20);
            this.Txt_SupportPurpose.TabIndex = 6;
            // 
            // Lbl_ParticipantAddress2
            // 
            this.Lbl_ParticipantAddress2.AutoSize = true;
            this.Lbl_ParticipantAddress2.Location = new System.Drawing.Point(137, 32);
            this.Lbl_ParticipantAddress2.Name = "Lbl_ParticipantAddress2";
            this.Lbl_ParticipantAddress2.Size = new System.Drawing.Size(83, 13);
            this.Lbl_ParticipantAddress2.TabIndex = 1;
            this.Lbl_ParticipantAddress2.Text = "SupportPurpose";
            // 
            // Lbl_ParticipantsAddress1
            // 
            this.Lbl_ParticipantsAddress1.AutoSize = true;
            this.Lbl_ParticipantsAddress1.Location = new System.Drawing.Point(8, 32);
            this.Lbl_ParticipantsAddress1.Name = "Lbl_ParticipantsAddress1";
            this.Lbl_ParticipantsAddress1.Size = new System.Drawing.Size(61, 13);
            this.Lbl_ParticipantsAddress1.TabIndex = 0;
            this.Lbl_ParticipantsAddress1.Text = "CAT CODE";
            // 
            // GrpboxParticipants
            // 
            this.GrpboxParticipants.Controls.Add(this.Txt_CostCentre);
            this.GrpboxParticipants.Controls.Add(this.Txt_NDISNo);
            this.GrpboxParticipants.Controls.Add(this.Lbl_CostCentre);
            this.GrpboxParticipants.Controls.Add(this.Txt_FirstName);
            this.GrpboxParticipants.Controls.Add(this.Txt_SurName);
            this.GrpboxParticipants.Controls.Add(this.Lbl_FirstName);
            this.GrpboxParticipants.Controls.Add(this.Lbl_NdisNo);
            this.GrpboxParticipants.Controls.Add(this.Btn_SearchAddPlan);
            this.GrpboxParticipants.Controls.Add(this.Lbl_Surname);
            this.GrpboxParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpboxParticipants.Location = new System.Drawing.Point(26, 45);
            this.GrpboxParticipants.Name = "GrpboxParticipants";
            this.GrpboxParticipants.Size = new System.Drawing.Size(548, 211);
            this.GrpboxParticipants.TabIndex = 19;
            this.GrpboxParticipants.TabStop = false;
            this.GrpboxParticipants.Text = "Participants";
            // 
            // Txt_CostCentre
            // 
            this.Txt_CostCentre.BackColor = System.Drawing.Color.White;
            this.Txt_CostCentre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_CostCentre.Location = new System.Drawing.Point(198, 172);
            this.Txt_CostCentre.Name = "Txt_CostCentre";
            this.Txt_CostCentre.ReadOnly = true;
            this.Txt_CostCentre.Size = new System.Drawing.Size(219, 26);
            this.Txt_CostCentre.TabIndex = 15;
            // 
            // Txt_NDISNo
            // 
            this.Txt_NDISNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_NDISNo.Location = new System.Drawing.Point(196, 132);
            this.Txt_NDISNo.Name = "Txt_NDISNo";
            this.Txt_NDISNo.Size = new System.Drawing.Size(219, 26);
            this.Txt_NDISNo.TabIndex = 3;
            // 
            // Txt_FirstName
            // 
            this.Txt_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_FirstName.Location = new System.Drawing.Point(196, 95);
            this.Txt_FirstName.Name = "Txt_FirstName";
            this.Txt_FirstName.Size = new System.Drawing.Size(219, 26);
            this.Txt_FirstName.TabIndex = 2;
            // 
            // Txt_SurName
            // 
            this.Txt_SurName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_SurName.Location = new System.Drawing.Point(196, 53);
            this.Txt_SurName.Name = "Txt_SurName";
            this.Txt_SurName.Size = new System.Drawing.Size(219, 26);
            this.Txt_SurName.TabIndex = 1;
            // 
            // Lbl_FirstName
            // 
            this.Lbl_FirstName.AutoSize = true;
            this.Lbl_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FirstName.Location = new System.Drawing.Point(6, 95);
            this.Lbl_FirstName.Name = "Lbl_FirstName";
            this.Lbl_FirstName.Size = new System.Drawing.Size(184, 17);
            this.Lbl_FirstName.TabIndex = 2;
            this.Lbl_FirstName.Text = "Participant Given Name:";
            // 
            // Lbl_NdisNo
            // 
            this.Lbl_NdisNo.AutoSize = true;
            this.Lbl_NdisNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NdisNo.Location = new System.Drawing.Point(6, 137);
            this.Lbl_NdisNo.Name = "Lbl_NdisNo";
            this.Lbl_NdisNo.Size = new System.Drawing.Size(193, 17);
            this.Lbl_NdisNo.TabIndex = 1;
            this.Lbl_NdisNo.Text = "Participant NDIS Number:";
            // 
            // Btn_SearchAddPlan
            // 
            this.Btn_SearchAddPlan.BackColor = System.Drawing.Color.Thistle;
            this.Btn_SearchAddPlan.Image = global::ClientQuoting.Properties.Resources.Search;
            this.Btn_SearchAddPlan.Location = new System.Drawing.Point(455, 95);
            this.Btn_SearchAddPlan.Name = "Btn_SearchAddPlan";
            this.Btn_SearchAddPlan.Size = new System.Drawing.Size(76, 109);
            this.Btn_SearchAddPlan.TabIndex = 18;
            this.Btn_SearchAddPlan.Text = "Search Client Plan";
            this.Btn_SearchAddPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_SearchAddPlan.UseVisualStyleBackColor = false;
            this.Btn_SearchAddPlan.Click += new System.EventHandler(this.Btn_SearchAddPlan_Click);
            // 
            // Lbl_Surname
            // 
            this.Lbl_Surname.AutoSize = true;
            this.Lbl_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Surname.Location = new System.Drawing.Point(6, 50);
            this.Lbl_Surname.Name = "Lbl_Surname";
            this.Lbl_Surname.Size = new System.Drawing.Size(160, 17);
            this.Lbl_Surname.TabIndex = 0;
            this.Lbl_Surname.Text = "Participant Surname:";
            // 
            // Lbl_Banner_Name
            // 
            this.Lbl_Banner_Name.AutoSize = true;
            this.Lbl_Banner_Name.BackColor = System.Drawing.Color.White;
            this.Lbl_Banner_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_Banner_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Banner_Name.ForeColor = System.Drawing.Color.Blue;
            this.Lbl_Banner_Name.Location = new System.Drawing.Point(429, 9);
            this.Lbl_Banner_Name.Name = "Lbl_Banner_Name";
            this.Lbl_Banner_Name.Size = new System.Drawing.Size(417, 33);
            this.Lbl_Banner_Name.TabIndex = 24;
            this.Lbl_Banner_Name.Text = "Greenacres Disability Services";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupportItemDescription,
            this.SupportItemNumber,
            this.Budget,
            this.HoursPerDay,
            this.NumberOfDaysPerWeek,
            this.HoursPerWeek,
            this.CostPerHour,
            this.WeeksPerYear,
            this.TotalCost,
            this.DiffToBudget,
            this.NDISNumber,
            this.NDISBillable});
            this.dataGridView1.Location = new System.Drawing.Point(26, 486);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1140, 161);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // SupportItemDescription
            // 
            this.SupportItemDescription.HeaderText = "Support Item ";
            this.SupportItemDescription.Name = "SupportItemDescription";
            this.SupportItemDescription.ReadOnly = true;
            this.SupportItemDescription.Width = 560;
            // 
            // SupportItemNumber
            // 
            this.SupportItemNumber.FillWeight = 120F;
            this.SupportItemNumber.HeaderText = "Support Item Number";
            this.SupportItemNumber.Name = "SupportItemNumber";
            this.SupportItemNumber.ReadOnly = true;
            this.SupportItemNumber.Width = 170;
            // 
            // Budget
            // 
            this.Budget.HeaderText = "Budget";
            this.Budget.Name = "Budget";
            this.Budget.ReadOnly = true;
            this.Budget.Width = 120;
            // 
            // HoursPerDay
            // 
            this.HoursPerDay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HoursPerDay.HeaderText = "Hours Per Day";
            this.HoursPerDay.Name = "HoursPerDay";
            this.HoursPerDay.ReadOnly = true;
            this.HoursPerDay.Width = 70;
            // 
            // NumberOfDaysPerWeek
            // 
            this.NumberOfDaysPerWeek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NumberOfDaysPerWeek.HeaderText = "Days Per Week";
            this.NumberOfDaysPerWeek.Name = "NumberOfDaysPerWeek";
            this.NumberOfDaysPerWeek.ReadOnly = true;
            this.NumberOfDaysPerWeek.Width = 70;
            // 
            // HoursPerWeek
            // 
            this.HoursPerWeek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HoursPerWeek.HeaderText = "Hours Per Week";
            this.HoursPerWeek.Name = "HoursPerWeek";
            this.HoursPerWeek.ReadOnly = true;
            this.HoursPerWeek.Width = 70;
            // 
            // CostPerHour
            // 
            this.CostPerHour.HeaderText = "Cost Per Hour";
            this.CostPerHour.Name = "CostPerHour";
            this.CostPerHour.ReadOnly = true;
            this.CostPerHour.Width = 70;
            // 
            // WeeksPerYear
            // 
            this.WeeksPerYear.HeaderText = "Weeks Per Year";
            this.WeeksPerYear.Name = "WeeksPerYear";
            this.WeeksPerYear.ReadOnly = true;
            this.WeeksPerYear.Width = 70;
            // 
            // TotalCost
            // 
            this.TotalCost.HeaderText = "Total Cost";
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            this.TotalCost.Width = 120;
            // 
            // DiffToBudget
            // 
            this.DiffToBudget.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DiffToBudget.HeaderText = "DiffToBudget";
            this.DiffToBudget.Name = "DiffToBudget";
            this.DiffToBudget.ReadOnly = true;
            this.DiffToBudget.Width = 120;
            // 
            // NDISNumber
            // 
            this.NDISNumber.HeaderText = "NDIS Number";
            this.NDISNumber.Name = "NDISNumber";
            this.NDISNumber.ReadOnly = true;
            this.NDISNumber.Width = 150;
            // 
            // NDISBillable
            // 
            this.NDISBillable.HeaderText = "NDIS Billable";
            this.NDISBillable.Name = "NDISBillable";
            this.NDISBillable.ReadOnly = true;
            this.NDISBillable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NDISBillable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NDISBillable.Width = 70;
            // 
            // Lbl_update
            // 
            this.Lbl_update.AutoSize = true;
            this.Lbl_update.Location = new System.Drawing.Point(579, 454);
            this.Lbl_update.Name = "Lbl_update";
            this.Lbl_update.Size = new System.Drawing.Size(246, 13);
            this.Lbl_update.TabIndex = 29;
            this.Lbl_update.Text = "You must select row from grid to update and delete";
            // 
            // GrpBoxUnitNote
            // 
            this.GrpBoxUnitNote.Controls.Add(this.label1);
            this.GrpBoxUnitNote.Controls.Add(this.Lbl_UnitNote);
            this.GrpBoxUnitNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBoxUnitNote.Location = new System.Drawing.Point(616, 52);
            this.GrpBoxUnitNote.Name = "GrpBoxUnitNote";
            this.GrpBoxUnitNote.Size = new System.Drawing.Size(323, 191);
            this.GrpBoxUnitNote.TabIndex = 30;
            this.GrpBoxUnitNote.TabStop = false;
            this.GrpBoxUnitNote.Text = "Unit\'s Note";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Week ; UnitperDay and UnitPerWeek  = 1*1";
            // 
            // Lbl_UnitNote
            // 
            this.Lbl_UnitNote.AutoSize = true;
            this.Lbl_UnitNote.Location = new System.Drawing.Point(7, 43);
            this.Lbl_UnitNote.Name = "Lbl_UnitNote";
            this.Lbl_UnitNote.Size = new System.Drawing.Size(179, 15);
            this.Lbl_UnitNote.TabIndex = 0;
            this.Lbl_UnitNote.Text = "Day ; Unit per day always 1";
            // 
            // Btn_ExitQuote
            // 
            this.Btn_ExitQuote.BackColor = System.Drawing.Color.Thistle;
            this.Btn_ExitQuote.Image = global::ClientQuoting.Properties.Resources.Exit;
            this.Btn_ExitQuote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ExitQuote.Location = new System.Drawing.Point(386, 440);
            this.Btn_ExitQuote.Name = "Btn_ExitQuote";
            this.Btn_ExitQuote.Size = new System.Drawing.Size(87, 40);
            this.Btn_ExitQuote.TabIndex = 28;
            this.Btn_ExitQuote.Text = "Exit Quote";
            this.Btn_ExitQuote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ExitQuote.UseVisualStyleBackColor = false;
            this.Btn_ExitQuote.Click += new System.EventHandler(this.Btn_ExitQuote_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.Thistle;
            this.Btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Delete.Image")));
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Delete.Location = new System.Drawing.Point(279, 440);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(101, 40);
            this.Btn_Delete.TabIndex = 21;
            this.Btn_Delete.Text = "Delete Line In Plan";
            this.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Insert
            // 
            this.Btn_Insert.BackColor = System.Drawing.Color.Thistle;
            this.Btn_Insert.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Insert.Image")));
            this.Btn_Insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Insert.Location = new System.Drawing.Point(26, 440);
            this.Btn_Insert.Name = "Btn_Insert";
            this.Btn_Insert.Size = new System.Drawing.Size(117, 40);
            this.Btn_Insert.TabIndex = 19;
            this.Btn_Insert.Text = "Insert New Line In Plan";
            this.Btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Insert.UseVisualStyleBackColor = false;
            this.Btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.Thistle;
            this.Btn_Update.Image = global::ClientQuoting.Properties.Resources.Updatedata;
            this.Btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Update.Location = new System.Drawing.Point(149, 440);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(124, 40);
            this.Btn_Update.TabIndex = 20;
            this.Btn_Update.Text = "Update Line In Plan";
            this.Btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // FormClientPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1201, 814);
            this.ControlBox = false;
            this.Controls.Add(this.GrpBoxUnitNote);
            this.Controls.Add(this.Lbl_update);
            this.Controls.Add(this.Btn_ExitQuote);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Lbl_Banner_Name);
            this.Controls.Add(this.Grpbox_ParticipantPlanInfo);
            this.Controls.Add(this.GrpboxParticipants);
            this.Name = "FormClientPlan";
            this.Text = "FormClientPlan";
            this.Load += new System.EventHandler(this.FormClientPlan_Load);
            this.Grpbox_ParticipantPlanInfo.ResumeLayout(false);
            this.Grpbox_ParticipantPlanInfo.PerformLayout();
            this.GrpboxParticipants.ResumeLayout(false);
            this.GrpboxParticipants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GrpBoxUnitNote.ResumeLayout(false);
            this.GrpBoxUnitNote.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_SearchAddPlan;
        private System.Windows.Forms.Label Lbl_CostCentre;
        private System.Windows.Forms.GroupBox Grpbox_ParticipantPlanInfo;
        private System.Windows.Forms.TextBox Txt_Budget;
        private System.Windows.Forms.TextBox Txt_SupportPurpose;
        private System.Windows.Forms.Label Lbl_ParticipantAddress2;
        private System.Windows.Forms.Label Lbl_ParticipantsAddress1;
        private System.Windows.Forms.GroupBox GrpboxParticipants;
        private System.Windows.Forms.TextBox Txt_NDISNo;
        private System.Windows.Forms.TextBox Txt_FirstName;
        private System.Windows.Forms.TextBox Txt_SurName;
        private System.Windows.Forms.Label Lbl_FirstName;
        private System.Windows.Forms.Label Lbl_NdisNo;
        private System.Windows.Forms.Label Lbl_Surname;
        private System.Windows.Forms.Label Lbl_Banner_Name;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.ComboBox comboBox_CatCode;
        private System.Windows.Forms.Label Lbl_SupportItemNo;
        private System.Windows.Forms.ComboBox comboBox_SupportItem;
        private System.Windows.Forms.TextBox Txt_ItemNO;
        private System.Windows.Forms.Label Lbl_SupportItem;
        private System.Windows.Forms.ComboBox comboBox_NDISBillablre;
        private System.Windows.Forms.Label Lbl_NDISBillable;
        private System.Windows.Forms.Label Lbl_budget;
        private System.Windows.Forms.Label Lbl_CostPerHr;
        private System.Windows.Forms.TextBox Txt_CostPerHr;
        private System.Windows.Forms.Label Lbl_HrPerWeek;
        private System.Windows.Forms.TextBox Txt_HrPerWeek;
        private System.Windows.Forms.Label Lbl_DaysPerWeek;
        private System.Windows.Forms.TextBox Txt_DaysPerWeek;
        private System.Windows.Forms.Label HrpDay;
        private System.Windows.Forms.TextBox Txt_HrPerDay;
        private System.Windows.Forms.Label Lbl_weeksPerYr;
        private System.Windows.Forms.TextBox Txt_WeeksPerYr;
        private System.Windows.Forms.Label Lbl_DiffToBudget;
        private System.Windows.Forms.TextBox Txt_DiffToBudget;
        private System.Windows.Forms.Label Lbl_TotalCost;
        private System.Windows.Forms.TextBox Txt_TotalCost;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Insert;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.TextBox Txt_CostCentre;
        private System.Windows.Forms.Button Btn_ExitQuote;
        private System.Windows.Forms.Label Lbl_update;
        private System.Windows.Forms.Label LblUnitType;
        private System.Windows.Forms.TextBox Txt_UnitType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupportItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupportItemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Budget;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursPerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfDaysPerWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursPerWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPerHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeeksPerYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiffToBudget;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDISNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NDISBillable;
        private System.Windows.Forms.GroupBox GrpBoxUnitNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_UnitNote;
    }
}