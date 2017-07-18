namespace ClientQuoting
{
    partial class FormQuoteAccepted
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
            this.Btn_ExitQuote = new System.Windows.Forms.Button();
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.DateTimePicker_QuoteAcceptDate = new System.Windows.Forms.DateTimePicker();
            this.combobox_NdisNo = new System.Windows.Forms.ComboBox();
            this.combobox_CostCentre = new System.Windows.Forms.ComboBox();
            this.combobox_FirstName = new System.Windows.Forms.ComboBox();
            this.combobox_SurName = new System.Windows.Forms.ComboBox();
            this.Txt_PlanId = new System.Windows.Forms.TextBox();
            this.Lbl_PlanId = new System.Windows.Forms.Label();
            this.Lbl_QuoteAcceptedDate = new System.Windows.Forms.Label();
            this.Txt_BookingBy = new System.Windows.Forms.TextBox();
            this.Lbl_BookingBy = new System.Windows.Forms.Label();
            this.Lbl_CostCentre = new System.Windows.Forms.Label();
            this.Lbl_FirstName = new System.Windows.Forms.Label();
            this.Lbl_NdisNo = new System.Windows.Forms.Label();
            this.Lbl_Surname = new System.Windows.Forms.Label();
            this.Lbl_Banner_Name = new System.Windows.Forms.Label();
            this.dataGridView_QuoteAccepted = new System.Windows.Forms.DataGridView();
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
            this.Btn_QuoteAccepted = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_SearchAddPlan = new System.Windows.Forms.Button();
            this.Grpbox_ParticipantPlanInfo.SuspendLayout();
            this.GrpboxParticipants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QuoteAccepted)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_ExitQuote
            // 
            this.Btn_ExitQuote.BackColor = System.Drawing.Color.Thistle;
            this.Btn_ExitQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExitQuote.Image = global::ClientQuoting.Properties.Resources.Exit;
            this.Btn_ExitQuote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ExitQuote.Location = new System.Drawing.Point(273, 476);
            this.Btn_ExitQuote.Name = "Btn_ExitQuote";
            this.Btn_ExitQuote.Size = new System.Drawing.Size(85, 40);
            this.Btn_ExitQuote.TabIndex = 35;
            this.Btn_ExitQuote.Text = "Exit Quote";
            this.Btn_ExitQuote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ExitQuote.UseVisualStyleBackColor = false;
            this.Btn_ExitQuote.Click += new System.EventHandler(this.Btn_ExitQuote_Click);
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
            this.Grpbox_ParticipantPlanInfo.Location = new System.Drawing.Point(12, 289);
            this.Grpbox_ParticipantPlanInfo.Name = "Grpbox_ParticipantPlanInfo";
            this.Grpbox_ParticipantPlanInfo.Size = new System.Drawing.Size(1140, 167);
            this.Grpbox_ParticipantPlanInfo.TabIndex = 33;
            this.Grpbox_ParticipantPlanInfo.TabStop = false;
            this.Grpbox_ParticipantPlanInfo.Text = "Participant Plan Info";
            // 
            // LblUnitType
            // 
            this.LblUnitType.AutoSize = true;
            this.LblUnitType.Location = new System.Drawing.Point(142, 78);
            this.LblUnitType.Name = "LblUnitType";
            this.LblUnitType.Size = new System.Drawing.Size(50, 13);
            this.LblUnitType.TabIndex = 36;
            this.LblUnitType.Text = "UnitType";
            // 
            // Txt_UnitType
            // 
            this.Txt_UnitType.BackColor = System.Drawing.Color.White;
            this.Txt_UnitType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_UnitType.Location = new System.Drawing.Point(200, 74);
            this.Txt_UnitType.Name = "Txt_UnitType";
            this.Txt_UnitType.ReadOnly = true;
            this.Txt_UnitType.Size = new System.Drawing.Size(70, 20);
            this.Txt_UnitType.TabIndex = 35;
            // 
            // Lbl_DiffToBudget
            // 
            this.Lbl_DiffToBudget.AutoSize = true;
            this.Lbl_DiffToBudget.Location = new System.Drawing.Point(976, 138);
            this.Lbl_DiffToBudget.Name = "Lbl_DiffToBudget";
            this.Lbl_DiffToBudget.Size = new System.Drawing.Size(70, 13);
            this.Lbl_DiffToBudget.TabIndex = 32;
            this.Lbl_DiffToBudget.Text = "DiffToBudget";
            // 
            // Txt_DiffToBudget
            // 
            this.Txt_DiffToBudget.BackColor = System.Drawing.Color.White;
            this.Txt_DiffToBudget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_DiffToBudget.Location = new System.Drawing.Point(1052, 136);
            this.Txt_DiffToBudget.Name = "Txt_DiffToBudget";
            this.Txt_DiffToBudget.ReadOnly = true;
            this.Txt_DiffToBudget.Size = new System.Drawing.Size(83, 20);
            this.Txt_DiffToBudget.TabIndex = 17;
            // 
            // Lbl_TotalCost
            // 
            this.Lbl_TotalCost.AutoSize = true;
            this.Lbl_TotalCost.Location = new System.Drawing.Point(807, 136);
            this.Lbl_TotalCost.Name = "Lbl_TotalCost";
            this.Lbl_TotalCost.Size = new System.Drawing.Size(52, 13);
            this.Lbl_TotalCost.TabIndex = 30;
            this.Lbl_TotalCost.Text = "TotalCost";
            // 
            // Txt_TotalCost
            // 
            this.Txt_TotalCost.BackColor = System.Drawing.Color.White;
            this.Txt_TotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_TotalCost.Location = new System.Drawing.Point(865, 131);
            this.Txt_TotalCost.Name = "Txt_TotalCost";
            this.Txt_TotalCost.ReadOnly = true;
            this.Txt_TotalCost.Size = new System.Drawing.Size(83, 20);
            this.Txt_TotalCost.TabIndex = 16;
            // 
            // Lbl_weeksPerYr
            // 
            this.Lbl_weeksPerYr.AutoSize = true;
            this.Lbl_weeksPerYr.Location = new System.Drawing.Point(664, 133);
            this.Lbl_weeksPerYr.Name = "Lbl_weeksPerYr";
            this.Lbl_weeksPerYr.Size = new System.Drawing.Size(67, 13);
            this.Lbl_weeksPerYr.TabIndex = 28;
            this.Lbl_weeksPerYr.Text = "WeeksPerYr";
            // 
            // Txt_WeeksPerYr
            // 
            this.Txt_WeeksPerYr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_WeeksPerYr.Location = new System.Drawing.Point(737, 129);
            this.Txt_WeeksPerYr.Name = "Txt_WeeksPerYr";
            this.Txt_WeeksPerYr.Size = new System.Drawing.Size(52, 20);
            this.Txt_WeeksPerYr.TabIndex = 15;
            this.Txt_WeeksPerYr.TextChanged += new System.EventHandler(this.Txt_WeeksPerYr_LostFocus);
            // 
            // Lbl_CostPerHr
            // 
            this.Lbl_CostPerHr.AutoSize = true;
            this.Lbl_CostPerHr.Location = new System.Drawing.Point(537, 131);
            this.Lbl_CostPerHr.Name = "Lbl_CostPerHr";
            this.Lbl_CostPerHr.Size = new System.Drawing.Size(63, 13);
            this.Lbl_CostPerHr.TabIndex = 26;
            this.Lbl_CostPerHr.Text = "CostPerUnit";
            // 
            // Txt_CostPerHr
            // 
            this.Txt_CostPerHr.BackColor = System.Drawing.Color.White;
            this.Txt_CostPerHr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_CostPerHr.Location = new System.Drawing.Point(606, 129);
            this.Txt_CostPerHr.Name = "Txt_CostPerHr";
            this.Txt_CostPerHr.Size = new System.Drawing.Size(52, 20);
            this.Txt_CostPerHr.TabIndex = 14;
            // 
            // Lbl_HrPerWeek
            // 
            this.Lbl_HrPerWeek.AutoSize = true;
            this.Lbl_HrPerWeek.Location = new System.Drawing.Point(410, 129);
            this.Lbl_HrPerWeek.Name = "Lbl_HrPerWeek";
            this.Lbl_HrPerWeek.Size = new System.Drawing.Size(50, 13);
            this.Lbl_HrPerWeek.TabIndex = 24;
            this.Lbl_HrPerWeek.Text = "TotalUnit";
            // 
            // Txt_HrPerWeek
            // 
            this.Txt_HrPerWeek.BackColor = System.Drawing.Color.White;
            this.Txt_HrPerWeek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_HrPerWeek.Location = new System.Drawing.Point(479, 124);
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
            this.Lbl_DaysPerWeek.Location = new System.Drawing.Point(270, 126);
            this.Lbl_DaysPerWeek.Name = "Lbl_DaysPerWeek";
            this.Lbl_DaysPerWeek.Size = new System.Drawing.Size(76, 13);
            this.Lbl_DaysPerWeek.TabIndex = 22;
            this.Lbl_DaysPerWeek.Text = "DaysPerWeek";
            // 
            // Txt_DaysPerWeek
            // 
            this.Txt_DaysPerWeek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_DaysPerWeek.Location = new System.Drawing.Point(352, 121);
            this.Txt_DaysPerWeek.Name = "Txt_DaysPerWeek";
            this.Txt_DaysPerWeek.Size = new System.Drawing.Size(52, 20);
            this.Txt_DaysPerWeek.TabIndex = 12;
            // 
            // HrpDay
            // 
            this.HrpDay.AutoSize = true;
            this.HrpDay.Location = new System.Drawing.Point(139, 123);
            this.HrpDay.Name = "HrpDay";
            this.HrpDay.Size = new System.Drawing.Size(61, 13);
            this.HrpDay.TabIndex = 20;
            this.HrpDay.Text = "UnitPerDay";
            // 
            // Txt_HrPerDay
            // 
            this.Txt_HrPerDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_HrPerDay.Location = new System.Drawing.Point(200, 121);
            this.Txt_HrPerDay.Name = "Txt_HrPerDay";
            this.Txt_HrPerDay.Size = new System.Drawing.Size(59, 20);
            this.Txt_HrPerDay.TabIndex = 11;
            // 
            // Lbl_budget
            // 
            this.Lbl_budget.AutoSize = true;
            this.Lbl_budget.Location = new System.Drawing.Point(8, 121);
            this.Lbl_budget.Name = "Lbl_budget";
            this.Lbl_budget.Size = new System.Drawing.Size(41, 13);
            this.Lbl_budget.TabIndex = 18;
            this.Lbl_budget.Text = "Budget";
            // 
            // comboBox_NDISBillablre
            // 
            this.comboBox_NDISBillablre.FormattingEnabled = true;
            this.comboBox_NDISBillablre.Location = new System.Drawing.Point(82, 75);
            this.comboBox_NDISBillablre.Name = "comboBox_NDISBillablre";
            this.comboBox_NDISBillablre.Size = new System.Drawing.Size(50, 21);
            this.comboBox_NDISBillablre.TabIndex = 9;
            // 
            // Lbl_NDISBillable
            // 
            this.Lbl_NDISBillable.AutoSize = true;
            this.Lbl_NDISBillable.Location = new System.Drawing.Point(4, 78);
            this.Lbl_NDISBillable.Name = "Lbl_NDISBillable";
            this.Lbl_NDISBillable.Size = new System.Drawing.Size(72, 13);
            this.Lbl_NDISBillable.TabIndex = 16;
            this.Lbl_NDISBillable.Text = "NDISBillable?";
            // 
            // Lbl_SupportItemNo
            // 
            this.Lbl_SupportItemNo.AutoSize = true;
            this.Lbl_SupportItemNo.Location = new System.Drawing.Point(928, 37);
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
            this.comboBox_SupportItem.Size = new System.Drawing.Size(474, 21);
            this.comboBox_SupportItem.TabIndex = 7;
            this.comboBox_SupportItem.SelectedValueChanged += new System.EventHandler(this.comboBox_SupportItem_SelectedValueChanged);
            // 
            // Txt_ItemNO
            // 
            this.Txt_ItemNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_ItemNO.Location = new System.Drawing.Point(1012, 34);
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
            this.comboBox_CatCode.Size = new System.Drawing.Size(50, 21);
            this.comboBox_CatCode.TabIndex = 5;
            this.comboBox_CatCode.Text = "Select Code";
            this.comboBox_CatCode.SelectedValueChanged += new System.EventHandler(this.comboBox_CatCode_SelectedValueChanged);
            // 
            // Txt_Budget
            // 
            this.Txt_Budget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Budget.Location = new System.Drawing.Point(50, 117);
            this.Txt_Budget.Name = "Txt_Budget";
            this.Txt_Budget.Size = new System.Drawing.Size(83, 20);
            this.Txt_Budget.TabIndex = 10;
            // 
            // Txt_SupportPurpose
            // 
            this.Txt_SupportPurpose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_SupportPurpose.Location = new System.Drawing.Point(205, 32);
            this.Txt_SupportPurpose.Name = "Txt_SupportPurpose";
            this.Txt_SupportPurpose.Size = new System.Drawing.Size(170, 20);
            this.Txt_SupportPurpose.TabIndex = 6;
            // 
            // Lbl_ParticipantAddress2
            // 
            this.Lbl_ParticipantAddress2.AutoSize = true;
            this.Lbl_ParticipantAddress2.Location = new System.Drawing.Point(125, 32);
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
            this.GrpboxParticipants.Controls.Add(this.linkLabel1);
            this.GrpboxParticipants.Controls.Add(this.DateTimePicker_QuoteAcceptDate);
            this.GrpboxParticipants.Controls.Add(this.combobox_NdisNo);
            this.GrpboxParticipants.Controls.Add(this.combobox_CostCentre);
            this.GrpboxParticipants.Controls.Add(this.combobox_FirstName);
            this.GrpboxParticipants.Controls.Add(this.combobox_SurName);
            this.GrpboxParticipants.Controls.Add(this.Txt_PlanId);
            this.GrpboxParticipants.Controls.Add(this.Lbl_PlanId);
            this.GrpboxParticipants.Controls.Add(this.Lbl_QuoteAcceptedDate);
            this.GrpboxParticipants.Controls.Add(this.Txt_BookingBy);
            this.GrpboxParticipants.Controls.Add(this.Lbl_BookingBy);
            this.GrpboxParticipants.Controls.Add(this.Lbl_CostCentre);
            this.GrpboxParticipants.Controls.Add(this.Lbl_FirstName);
            this.GrpboxParticipants.Controls.Add(this.Lbl_NdisNo);
            this.GrpboxParticipants.Controls.Add(this.Lbl_Surname);
            this.GrpboxParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpboxParticipants.Location = new System.Drawing.Point(12, 68);
            this.GrpboxParticipants.Name = "GrpboxParticipants";
            this.GrpboxParticipants.Size = new System.Drawing.Size(859, 211);
            this.GrpboxParticipants.TabIndex = 31;
            this.GrpboxParticipants.TabStop = false;
            this.GrpboxParticipants.Text = "Participants";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(465, 22);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(321, 20);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Complete After Booking In NDIS Portal";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // DateTimePicker_QuoteAcceptDate
            // 
            this.DateTimePicker_QuoteAcceptDate.CustomFormat = "yyyy-MM-dd";
            this.DateTimePicker_QuoteAcceptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker_QuoteAcceptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker_QuoteAcceptDate.Location = new System.Drawing.Point(557, 108);
            this.DateTimePicker_QuoteAcceptDate.Name = "DateTimePicker_QuoteAcceptDate";
            this.DateTimePicker_QuoteAcceptDate.Size = new System.Drawing.Size(219, 26);
            this.DateTimePicker_QuoteAcceptDate.TabIndex = 26;
            // 
            // combobox_NdisNo
            // 
            this.combobox_NdisNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combobox_NdisNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_NdisNo.BackColor = System.Drawing.Color.White;
            this.combobox_NdisNo.FormattingEnabled = true;
            this.combobox_NdisNo.Location = new System.Drawing.Point(164, 50);
            this.combobox_NdisNo.Name = "combobox_NdisNo";
            this.combobox_NdisNo.Size = new System.Drawing.Size(219, 28);
            this.combobox_NdisNo.TabIndex = 25;
            this.combobox_NdisNo.SelectedValueChanged += new System.EventHandler(this.combobox_NdisNo_SelectedValueChanged);
            // 
            // combobox_CostCentre
            // 
            this.combobox_CostCentre.BackColor = System.Drawing.Color.White;
            this.combobox_CostCentre.FormattingEnabled = true;
            this.combobox_CostCentre.Location = new System.Drawing.Point(164, 171);
            this.combobox_CostCentre.Name = "combobox_CostCentre";
            this.combobox_CostCentre.Size = new System.Drawing.Size(219, 28);
            this.combobox_CostCentre.TabIndex = 24;
            // 
            // combobox_FirstName
            // 
            this.combobox_FirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combobox_FirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_FirstName.BackColor = System.Drawing.Color.White;
            this.combobox_FirstName.FormattingEnabled = true;
            this.combobox_FirstName.Location = new System.Drawing.Point(164, 133);
            this.combobox_FirstName.Name = "combobox_FirstName";
            this.combobox_FirstName.Size = new System.Drawing.Size(219, 28);
            this.combobox_FirstName.TabIndex = 23;
            this.combobox_FirstName.SelectedValueChanged += new System.EventHandler(this.combobox_FirstName_SelectedValueChanged);
            // 
            // combobox_SurName
            // 
            this.combobox_SurName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combobox_SurName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_SurName.BackColor = System.Drawing.Color.White;
            this.combobox_SurName.FormattingEnabled = true;
            this.combobox_SurName.Location = new System.Drawing.Point(164, 94);
            this.combobox_SurName.Name = "combobox_SurName";
            this.combobox_SurName.Size = new System.Drawing.Size(219, 28);
            this.combobox_SurName.TabIndex = 22;
            this.combobox_SurName.SelectedValueChanged += new System.EventHandler(this.combobox_SurName_SelectedValueChanged);
            // 
            // Txt_PlanId
            // 
            this.Txt_PlanId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_PlanId.Location = new System.Drawing.Point(557, 152);
            this.Txt_PlanId.Name = "Txt_PlanId";
            this.Txt_PlanId.Size = new System.Drawing.Size(219, 26);
            this.Txt_PlanId.TabIndex = 21;
            this.Txt_PlanId.TextChanged += new System.EventHandler(this.Txt_PlanId_TextChanged);
            // 
            // Lbl_PlanId
            // 
            this.Lbl_PlanId.AutoSize = true;
            this.Lbl_PlanId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PlanId.Location = new System.Drawing.Point(466, 157);
            this.Lbl_PlanId.Name = "Lbl_PlanId";
            this.Lbl_PlanId.Size = new System.Drawing.Size(65, 17);
            this.Lbl_PlanId.TabIndex = 20;
            this.Lbl_PlanId.Text = "Plan ID:";
            this.Lbl_PlanId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_QuoteAcceptedDate
            // 
            this.Lbl_QuoteAcceptedDate.AutoSize = true;
            this.Lbl_QuoteAcceptedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_QuoteAcceptedDate.Location = new System.Drawing.Point(424, 116);
            this.Lbl_QuoteAcceptedDate.Name = "Lbl_QuoteAcceptedDate";
            this.Lbl_QuoteAcceptedDate.Size = new System.Drawing.Size(168, 17);
            this.Lbl_QuoteAcceptedDate.TabIndex = 18;
            this.Lbl_QuoteAcceptedDate.Text = "Quote Accepted Date:";
            // 
            // Txt_BookingBy
            // 
            this.Txt_BookingBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_BookingBy.Location = new System.Drawing.Point(557, 59);
            this.Txt_BookingBy.Name = "Txt_BookingBy";
            this.Txt_BookingBy.Size = new System.Drawing.Size(219, 26);
            this.Txt_BookingBy.TabIndex = 17;
            // 
            // Lbl_BookingBy
            // 
            this.Lbl_BookingBy.AutoSize = true;
            this.Lbl_BookingBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BookingBy.Location = new System.Drawing.Point(466, 64);
            this.Lbl_BookingBy.Name = "Lbl_BookingBy";
            this.Lbl_BookingBy.Size = new System.Drawing.Size(94, 17);
            this.Lbl_BookingBy.TabIndex = 16;
            this.Lbl_BookingBy.Text = "Booking By:";
            this.Lbl_BookingBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_CostCentre
            // 
            this.Lbl_CostCentre.AutoSize = true;
            this.Lbl_CostCentre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CostCentre.Location = new System.Drawing.Point(66, 177);
            this.Lbl_CostCentre.Name = "Lbl_CostCentre";
            this.Lbl_CostCentre.Size = new System.Drawing.Size(98, 17);
            this.Lbl_CostCentre.TabIndex = 14;
            this.Lbl_CostCentre.Text = "Cost Centre:";
            // 
            // Lbl_FirstName
            // 
            this.Lbl_FirstName.AutoSize = true;
            this.Lbl_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FirstName.Location = new System.Drawing.Point(8, 139);
            this.Lbl_FirstName.Name = "Lbl_FirstName";
            this.Lbl_FirstName.Size = new System.Drawing.Size(184, 17);
            this.Lbl_FirstName.TabIndex = 2;
            this.Lbl_FirstName.Text = "Participant Given Name:";
            // 
            // Lbl_NdisNo
            // 
            this.Lbl_NdisNo.AutoSize = true;
            this.Lbl_NdisNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NdisNo.Location = new System.Drawing.Point(8, 50);
            this.Lbl_NdisNo.Name = "Lbl_NdisNo";
            this.Lbl_NdisNo.Size = new System.Drawing.Size(193, 17);
            this.Lbl_NdisNo.TabIndex = 1;
            this.Lbl_NdisNo.Text = "Participant NDIS Number:";
            // 
            // Lbl_Surname
            // 
            this.Lbl_Surname.AutoSize = true;
            this.Lbl_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Surname.Location = new System.Drawing.Point(8, 94);
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
            this.Lbl_Banner_Name.Location = new System.Drawing.Point(402, 19);
            this.Lbl_Banner_Name.Name = "Lbl_Banner_Name";
            this.Lbl_Banner_Name.Size = new System.Drawing.Size(417, 33);
            this.Lbl_Banner_Name.TabIndex = 36;
            this.Lbl_Banner_Name.Text = "Greenacres Disability Services";
            // 
            // dataGridView_QuoteAccepted
            // 
            this.dataGridView_QuoteAccepted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_QuoteAccepted.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView_QuoteAccepted.Location = new System.Drawing.Point(12, 522);
            this.dataGridView_QuoteAccepted.Name = "dataGridView_QuoteAccepted";
            this.dataGridView_QuoteAccepted.ReadOnly = true;
            this.dataGridView_QuoteAccepted.Size = new System.Drawing.Size(1140, 150);
            this.dataGridView_QuoteAccepted.TabIndex = 37;
            this.dataGridView_QuoteAccepted.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_QuoteAccepted_RowHeaderMouseClick);
            // 
            // SupportItemDescription
            // 
            this.SupportItemDescription.HeaderText = "Support Item";
            this.SupportItemDescription.Name = "SupportItemDescription";
            this.SupportItemDescription.ReadOnly = true;
            this.SupportItemDescription.Width = 560;
            // 
            // SupportItemNumber
            // 
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
            this.HoursPerDay.HeaderText = "Hours Per Day";
            this.HoursPerDay.Name = "HoursPerDay";
            this.HoursPerDay.ReadOnly = true;
            this.HoursPerDay.Width = 70;
            // 
            // NumberOfDaysPerWeek
            // 
            this.NumberOfDaysPerWeek.HeaderText = "Days Per Week";
            this.NumberOfDaysPerWeek.Name = "NumberOfDaysPerWeek";
            this.NumberOfDaysPerWeek.ReadOnly = true;
            this.NumberOfDaysPerWeek.Width = 70;
            // 
            // HoursPerWeek
            // 
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
            this.Lbl_update.Location = new System.Drawing.Point(436, 489);
            this.Lbl_update.Name = "Lbl_update";
            this.Lbl_update.Size = new System.Drawing.Size(260, 13);
            this.Lbl_update.TabIndex = 39;
            this.Lbl_update.Text = "You need to select row from grid to update and delete";
            // 
            // Btn_QuoteAccepted
            // 
            this.Btn_QuoteAccepted.BackColor = System.Drawing.Color.Thistle;
            this.Btn_QuoteAccepted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_QuoteAccepted.Image = global::ClientQuoting.Properties.Resources.Accept;
            this.Btn_QuoteAccepted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_QuoteAccepted.Location = new System.Drawing.Point(182, 476);
            this.Btn_QuoteAccepted.Name = "Btn_QuoteAccepted";
            this.Btn_QuoteAccepted.Size = new System.Drawing.Size(85, 40);
            this.Btn_QuoteAccepted.TabIndex = 38;
            this.Btn_QuoteAccepted.Text = "Accept Quote";
            this.Btn_QuoteAccepted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_QuoteAccepted.UseVisualStyleBackColor = false;
            this.Btn_QuoteAccepted.Click += new System.EventHandler(this.Btn_QuoteAccepted_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.Thistle;
            this.Btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.Image = global::ClientQuoting.Properties.Resources.Updatedata;
            this.Btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Update.Location = new System.Drawing.Point(94, 476);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(82, 40);
            this.Btn_Update.TabIndex = 32;
            this.Btn_Update.Text = "Update Plan";
            this.Btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_SearchAddPlan
            // 
            this.Btn_SearchAddPlan.BackColor = System.Drawing.Color.Thistle;
            this.Btn_SearchAddPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SearchAddPlan.Image = global::ClientQuoting.Properties.Resources.Search;
            this.Btn_SearchAddPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_SearchAddPlan.Location = new System.Drawing.Point(12, 475);
            this.Btn_SearchAddPlan.Name = "Btn_SearchAddPlan";
            this.Btn_SearchAddPlan.Size = new System.Drawing.Size(76, 40);
            this.Btn_SearchAddPlan.TabIndex = 29;
            this.Btn_SearchAddPlan.Text = "Search Plan";
            this.Btn_SearchAddPlan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_SearchAddPlan.UseVisualStyleBackColor = false;
            this.Btn_SearchAddPlan.Click += new System.EventHandler(this.Btn_SearchAddPlan_Click);
            // 
            // FormQuoteAccepted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1201, 814);
            this.ControlBox = false;
            this.Controls.Add(this.Lbl_update);
            this.Controls.Add(this.Btn_QuoteAccepted);
            this.Controls.Add(this.dataGridView_QuoteAccepted);
            this.Controls.Add(this.Lbl_Banner_Name);
            this.Controls.Add(this.Btn_ExitQuote);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_SearchAddPlan);
            this.Controls.Add(this.Grpbox_ParticipantPlanInfo);
            this.Controls.Add(this.GrpboxParticipants);
            this.Name = "FormQuoteAccepted";
            this.Text = "FormQuoteAccepted";
            this.Load += new System.EventHandler(this.FormQuoteAccepted_Load);
            this.Grpbox_ParticipantPlanInfo.ResumeLayout(false);
            this.Grpbox_ParticipantPlanInfo.PerformLayout();
            this.GrpboxParticipants.ResumeLayout(false);
            this.GrpboxParticipants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QuoteAccepted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ExitQuote;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_SearchAddPlan;
        private System.Windows.Forms.GroupBox Grpbox_ParticipantPlanInfo;
        private System.Windows.Forms.Label Lbl_DiffToBudget;
        private System.Windows.Forms.TextBox Txt_DiffToBudget;
        private System.Windows.Forms.Label Lbl_TotalCost;
        private System.Windows.Forms.TextBox Txt_TotalCost;
        private System.Windows.Forms.Label Lbl_weeksPerYr;
        private System.Windows.Forms.TextBox Txt_WeeksPerYr;
        private System.Windows.Forms.Label Lbl_CostPerHr;
        private System.Windows.Forms.TextBox Txt_CostPerHr;
        private System.Windows.Forms.Label Lbl_HrPerWeek;
        private System.Windows.Forms.TextBox Txt_HrPerWeek;
        private System.Windows.Forms.Label Lbl_DaysPerWeek;
        private System.Windows.Forms.TextBox Txt_DaysPerWeek;
        private System.Windows.Forms.Label HrpDay;
        private System.Windows.Forms.TextBox Txt_HrPerDay;
        private System.Windows.Forms.Label Lbl_budget;
        private System.Windows.Forms.ComboBox comboBox_NDISBillablre;
        private System.Windows.Forms.Label Lbl_NDISBillable;
        private System.Windows.Forms.Label Lbl_SupportItemNo;
        private System.Windows.Forms.ComboBox comboBox_SupportItem;
        private System.Windows.Forms.TextBox Txt_ItemNO;
        private System.Windows.Forms.Label Lbl_SupportItem;
        private System.Windows.Forms.ComboBox comboBox_CatCode;
        private System.Windows.Forms.TextBox Txt_Budget;
        private System.Windows.Forms.TextBox Txt_SupportPurpose;
        private System.Windows.Forms.Label Lbl_ParticipantAddress2;
        private System.Windows.Forms.Label Lbl_ParticipantsAddress1;
        private System.Windows.Forms.GroupBox GrpboxParticipants;
        private System.Windows.Forms.Label Lbl_CostCentre;
        private System.Windows.Forms.Label Lbl_FirstName;
        private System.Windows.Forms.Label Lbl_NdisNo;
        private System.Windows.Forms.Label Lbl_Surname;
        private System.Windows.Forms.Label Lbl_Banner_Name;
        private System.Windows.Forms.DataGridView dataGridView_QuoteAccepted;
        private System.Windows.Forms.Label Lbl_QuoteAcceptedDate;
        private System.Windows.Forms.TextBox Txt_BookingBy;
        private System.Windows.Forms.Label Lbl_BookingBy;
        private System.Windows.Forms.Label Lbl_PlanId;
        private System.Windows.Forms.ComboBox combobox_NdisNo;
        private System.Windows.Forms.ComboBox combobox_CostCentre;
        private System.Windows.Forms.ComboBox combobox_FirstName;
        private System.Windows.Forms.ComboBox combobox_SurName;
        private System.Windows.Forms.TextBox Txt_PlanId;
        private System.Windows.Forms.DateTimePicker DateTimePicker_QuoteAcceptDate;
        private System.Windows.Forms.Button Btn_QuoteAccepted;
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
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}