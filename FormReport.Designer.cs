namespace ClientQuoting
{
    partial class FormReport
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
            this.components = new System.ComponentModel.Container();
            this.uspReportClientPlanByNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientQuotationDataSetReportByNo = new ClientQuoting.ClientQuotationDataSetReportByNo();
            this.uspNameBaseSearchClientPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportClientPlanDataSet = new ClientQuoting.ReportClientPlanDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uspNameBaseSearchClientPlanTableAdapter = new ClientQuoting.ReportClientPlanDataSetTableAdapters.uspNameBaseSearchClientPlanTableAdapter();
            this.GrpboxParticipants = new System.Windows.Forms.GroupBox();
            this.combobox_NdisNo = new System.Windows.Forms.ComboBox();
            this.combobox_FirstName = new System.Windows.Forms.ComboBox();
            this.combobox_SurName = new System.Windows.Forms.ComboBox();
            this.Lbl_FirstName = new System.Windows.Forms.Label();
            this.Lbl_NdisNo = new System.Windows.Forms.Label();
            this.Btn_SearchPlan = new System.Windows.Forms.Button();
            this.Lbl_Surname = new System.Windows.Forms.Label();
            this.uspReportClientPlanByNoTableAdapter = new ClientQuoting.ClientQuotationDataSetReportByNoTableAdapters.uspReportClientPlanByNoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uspReportClientPlanByNoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientQuotationDataSetReportByNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspNameBaseSearchClientPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportClientPlanDataSet)).BeginInit();
            this.GrpboxParticipants.SuspendLayout();
            this.SuspendLayout();
            // 
            // uspReportClientPlanByNoBindingSource
            // 
            this.uspReportClientPlanByNoBindingSource.DataMember = "uspReportClientPlanByNo";
            this.uspReportClientPlanByNoBindingSource.DataSource = this.clientQuotationDataSetReportByNo;
            // 
            // clientQuotationDataSetReportByNo
            // 
            this.clientQuotationDataSetReportByNo.DataSetName = "ClientQuotationDataSetReportByNo";
            this.clientQuotationDataSetReportByNo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspNameBaseSearchClientPlanBindingSource
            // 
            this.uspNameBaseSearchClientPlanBindingSource.DataMember = "uspNameBaseSearchClientPlan";
            this.uspNameBaseSearchClientPlanBindingSource.DataSource = this.ReportClientPlanDataSet;
            // 
            // ReportClientPlanDataSet
            // 
            this.ReportClientPlanDataSet.DataSetName = "ReportClientPlanDataSet";
            this.ReportClientPlanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ClientQuoting.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 251);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(821, 492);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // uspNameBaseSearchClientPlanTableAdapter
            // 
            this.uspNameBaseSearchClientPlanTableAdapter.ClearBeforeFill = true;
            // 
            // GrpboxParticipants
            // 
            this.GrpboxParticipants.Controls.Add(this.combobox_NdisNo);
            this.GrpboxParticipants.Controls.Add(this.combobox_FirstName);
            this.GrpboxParticipants.Controls.Add(this.combobox_SurName);
            this.GrpboxParticipants.Controls.Add(this.Lbl_FirstName);
            this.GrpboxParticipants.Controls.Add(this.Lbl_NdisNo);
            this.GrpboxParticipants.Controls.Add(this.Btn_SearchPlan);
            this.GrpboxParticipants.Controls.Add(this.Lbl_Surname);
            this.GrpboxParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpboxParticipants.Location = new System.Drawing.Point(27, 34);
            this.GrpboxParticipants.Name = "GrpboxParticipants";
            this.GrpboxParticipants.Size = new System.Drawing.Size(548, 211);
            this.GrpboxParticipants.TabIndex = 20;
            this.GrpboxParticipants.TabStop = false;
            this.GrpboxParticipants.Text = "Participants";
            // 
            // combobox_NdisNo
            // 
            this.combobox_NdisNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combobox_NdisNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_NdisNo.FormattingEnabled = true;
            this.combobox_NdisNo.Location = new System.Drawing.Point(196, 131);
            this.combobox_NdisNo.Name = "combobox_NdisNo";
            this.combobox_NdisNo.Size = new System.Drawing.Size(165, 28);
            this.combobox_NdisNo.TabIndex = 21;
            // 
            // combobox_FirstName
            // 
            this.combobox_FirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combobox_FirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_FirstName.FormattingEnabled = true;
            this.combobox_FirstName.Location = new System.Drawing.Point(196, 89);
            this.combobox_FirstName.Name = "combobox_FirstName";
            this.combobox_FirstName.Size = new System.Drawing.Size(165, 28);
            this.combobox_FirstName.TabIndex = 20;
            // 
            // combobox_SurName
            // 
            this.combobox_SurName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combobox_SurName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_SurName.FormattingEnabled = true;
            this.combobox_SurName.Location = new System.Drawing.Point(196, 50);
            this.combobox_SurName.Name = "combobox_SurName";
            this.combobox_SurName.Size = new System.Drawing.Size(165, 28);
            this.combobox_SurName.TabIndex = 19;
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
            // Btn_SearchPlan
            // 
            this.Btn_SearchPlan.BackColor = System.Drawing.Color.Thistle;
            this.Btn_SearchPlan.Location = new System.Drawing.Point(455, 132);
            this.Btn_SearchPlan.Name = "Btn_SearchPlan";
            this.Btn_SearchPlan.Size = new System.Drawing.Size(76, 72);
            this.Btn_SearchPlan.TabIndex = 18;
            this.Btn_SearchPlan.Text = "Search Client Plan";
            this.Btn_SearchPlan.UseVisualStyleBackColor = false;
            this.Btn_SearchPlan.Click += new System.EventHandler(this.Btn_SearchPlan_Click);
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
            // uspReportClientPlanByNoTableAdapter
            // 
            this.uspReportClientPlanByNoTableAdapter.ClearBeforeFill = true;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1289, 814);
            this.ControlBox = false;
            this.Controls.Add(this.GrpboxParticipants);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uspReportClientPlanByNoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientQuotationDataSetReportByNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspNameBaseSearchClientPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportClientPlanDataSet)).EndInit();
            this.GrpboxParticipants.ResumeLayout(false);
            this.GrpboxParticipants.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uspNameBaseSearchClientPlanBindingSource;
        private ReportClientPlanDataSet ReportClientPlanDataSet;
        private ReportClientPlanDataSetTableAdapters.uspNameBaseSearchClientPlanTableAdapter uspNameBaseSearchClientPlanTableAdapter;
        private System.Windows.Forms.GroupBox GrpboxParticipants;
        private System.Windows.Forms.Label Lbl_FirstName;
        private System.Windows.Forms.Label Lbl_NdisNo;
        private System.Windows.Forms.Button Btn_SearchPlan;
        private System.Windows.Forms.Label Lbl_Surname;
        private System.Windows.Forms.BindingSource uspReportClientPlanByNoBindingSource;
        private ClientQuotationDataSetReportByNo clientQuotationDataSetReportByNo;
        private ClientQuotationDataSetReportByNoTableAdapters.uspReportClientPlanByNoTableAdapter uspReportClientPlanByNoTableAdapter;
        private System.Windows.Forms.ComboBox combobox_NdisNo;
        private System.Windows.Forms.ComboBox combobox_FirstName;
        private System.Windows.Forms.ComboBox combobox_SurName;

    }
}