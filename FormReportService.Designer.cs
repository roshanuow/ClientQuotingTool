namespace ClientQuoting
{
    partial class FormReportService
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GrpboxServiceProvided = new System.Windows.Forms.GroupBox();
            this.Btn_SearchService = new System.Windows.Forms.Button();
            this.DateTimerPicker_CreatedDate = new System.Windows.Forms.DateTimePicker();
            this.combobox_CostCentre = new System.Windows.Forms.ComboBox();
            this.Lbl_CostCentre = new System.Windows.Forms.Label();
            this.Lbl_InputDate = new System.Windows.Forms.Label();
            this.reportViewerService = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClientQuotationDataSetReportService = new ClientQuoting.ClientQuotationDataSetReportService();
            this.uspReportServiceProvidedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspReportServiceProvidedTableAdapter = new ClientQuoting.ClientQuotationDataSetReportServiceTableAdapters.uspReportServiceProvidedTableAdapter();
            this.GrpboxServiceProvided.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientQuotationDataSetReportService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspReportServiceProvidedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpboxServiceProvided
            // 
            this.GrpboxServiceProvided.Controls.Add(this.Btn_SearchService);
            this.GrpboxServiceProvided.Controls.Add(this.DateTimerPicker_CreatedDate);
            this.GrpboxServiceProvided.Controls.Add(this.combobox_CostCentre);
            this.GrpboxServiceProvided.Controls.Add(this.Lbl_CostCentre);
            this.GrpboxServiceProvided.Controls.Add(this.Lbl_InputDate);
            this.GrpboxServiceProvided.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpboxServiceProvided.Location = new System.Drawing.Point(12, 12);
            this.GrpboxServiceProvided.Name = "GrpboxServiceProvided";
            this.GrpboxServiceProvided.Size = new System.Drawing.Size(337, 183);
            this.GrpboxServiceProvided.TabIndex = 27;
            this.GrpboxServiceProvided.TabStop = false;
            this.GrpboxServiceProvided.Text = "Service Provider";
            // 
            // Btn_SearchService
            // 
            this.Btn_SearchService.BackColor = System.Drawing.Color.Thistle;
            this.Btn_SearchService.Location = new System.Drawing.Point(105, 104);
            this.Btn_SearchService.Name = "Btn_SearchService";
            this.Btn_SearchService.Size = new System.Drawing.Size(217, 72);
            this.Btn_SearchService.TabIndex = 19;
            this.Btn_SearchService.Text = "Search Service Provided";
            this.Btn_SearchService.UseVisualStyleBackColor = false;
            this.Btn_SearchService.Click += new System.EventHandler(this.Btn_SearchService_Click);
            // 
            // DateTimerPicker_CreatedDate
            // 
            this.DateTimerPicker_CreatedDate.CustomFormat = "yyyy-MM-dd";
            this.DateTimerPicker_CreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimerPicker_CreatedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimerPicker_CreatedDate.Location = new System.Drawing.Point(105, 72);
            this.DateTimerPicker_CreatedDate.Name = "DateTimerPicker_CreatedDate";
            this.DateTimerPicker_CreatedDate.Size = new System.Drawing.Size(217, 26);
            this.DateTimerPicker_CreatedDate.TabIndex = 3;
            this.DateTimerPicker_CreatedDate.ValueChanged += new System.EventHandler(this.DateTimerPicker_CreatedDate_ValueChanged);
            // 
            // combobox_CostCentre
            // 
            this.combobox_CostCentre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combobox_CostCentre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_CostCentre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_CostCentre.FormattingEnabled = true;
            this.combobox_CostCentre.Location = new System.Drawing.Point(105, 35);
            this.combobox_CostCentre.Name = "combobox_CostCentre";
            this.combobox_CostCentre.Size = new System.Drawing.Size(219, 24);
            this.combobox_CostCentre.TabIndex = 2;
            // 
            // Lbl_CostCentre
            // 
            this.Lbl_CostCentre.AutoSize = true;
            this.Lbl_CostCentre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CostCentre.Location = new System.Drawing.Point(6, 35);
            this.Lbl_CostCentre.Name = "Lbl_CostCentre";
            this.Lbl_CostCentre.Size = new System.Drawing.Size(98, 17);
            this.Lbl_CostCentre.TabIndex = 14;
            this.Lbl_CostCentre.Text = "Cost Centre:";
            // 
            // Lbl_InputDate
            // 
            this.Lbl_InputDate.AutoSize = true;
            this.Lbl_InputDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InputDate.Location = new System.Drawing.Point(6, 74);
            this.Lbl_InputDate.Name = "Lbl_InputDate";
            this.Lbl_InputDate.Size = new System.Drawing.Size(132, 17);
            this.Lbl_InputDate.TabIndex = 1;
            this.Lbl_InputDate.Text = "Start Week Date:";
            // 
            // reportViewerService
            // 
            this.reportViewerService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSetReportService";
            reportDataSource1.Value = this.uspReportServiceProvidedBindingSource;
            this.reportViewerService.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerService.LocalReport.ReportEmbeddedResource = "ClientQuoting.Report2.rdlc";
            this.reportViewerService.Location = new System.Drawing.Point(12, 212);
            this.reportViewerService.Name = "reportViewerService";
            this.reportViewerService.Size = new System.Drawing.Size(1033, 492);
            this.reportViewerService.TabIndex = 28;
            // 
            // ClientQuotationDataSetReportService
            // 
            this.ClientQuotationDataSetReportService.DataSetName = "ClientQuotationDataSetReportService";
            this.ClientQuotationDataSetReportService.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspReportServiceProvidedBindingSource
            // 
            this.uspReportServiceProvidedBindingSource.DataMember = "uspReportServiceProvided";
            this.uspReportServiceProvidedBindingSource.DataSource = this.ClientQuotationDataSetReportService;
            // 
            // uspReportServiceProvidedTableAdapter
            // 
            this.uspReportServiceProvidedTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1289, 814);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewerService);
            this.Controls.Add(this.GrpboxServiceProvided);
            this.Name = "FormReportService";
            this.Text = "FormReportService";
            this.Load += new System.EventHandler(this.FormReportService_Load);
            this.GrpboxServiceProvided.ResumeLayout(false);
            this.GrpboxServiceProvided.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientQuotationDataSetReportService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspReportServiceProvidedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpboxServiceProvided;
        private System.Windows.Forms.DateTimePicker DateTimerPicker_CreatedDate;
        private System.Windows.Forms.ComboBox combobox_CostCentre;
        private System.Windows.Forms.Label Lbl_CostCentre;
        private System.Windows.Forms.Label Lbl_InputDate;
        private System.Windows.Forms.Button Btn_SearchService;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerService;
        private System.Windows.Forms.BindingSource uspReportServiceProvidedBindingSource;
        private ClientQuotationDataSetReportService ClientQuotationDataSetReportService;
        private ClientQuotationDataSetReportServiceTableAdapters.uspReportServiceProvidedTableAdapter uspReportServiceProvidedTableAdapter;
    }
}