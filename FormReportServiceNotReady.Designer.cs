namespace ClientQuoting
{
    partial class FormReportServiceNotReady
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GrpboxServiceProvided = new System.Windows.Forms.GroupBox();
            this.Btn_SearchService = new System.Windows.Forms.Button();
            this.DateTimerPicker_CreatedDate = new System.Windows.Forms.DateTimePicker();
            this.Lbl_InputDate = new System.Windows.Forms.Label();
            this.reportViewerServiceNotReady = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetReportServiceNotReady = new ClientQuoting.DataSetReportServiceNotReady();
            this.uspReportNotReadyToPostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspReportNotReadyToPostTableAdapter = new ClientQuoting.DataSetReportServiceNotReadyTableAdapters.uspReportNotReadyToPostTableAdapter();
            this.GrpboxServiceProvided.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportServiceNotReady)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspReportNotReadyToPostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpboxServiceProvided
            // 
            this.GrpboxServiceProvided.Controls.Add(this.Btn_SearchService);
            this.GrpboxServiceProvided.Controls.Add(this.DateTimerPicker_CreatedDate);
            this.GrpboxServiceProvided.Controls.Add(this.Lbl_InputDate);
            this.GrpboxServiceProvided.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpboxServiceProvided.Location = new System.Drawing.Point(12, 12);
            this.GrpboxServiceProvided.Name = "GrpboxServiceProvided";
            this.GrpboxServiceProvided.Size = new System.Drawing.Size(337, 146);
            this.GrpboxServiceProvided.TabIndex = 27;
            this.GrpboxServiceProvided.TabStop = false;
            this.GrpboxServiceProvided.Text = "Service Provider";
            // 
            // Btn_SearchService
            // 
            this.Btn_SearchService.BackColor = System.Drawing.Color.Thistle;
            this.Btn_SearchService.Location = new System.Drawing.Point(105, 62);
            this.Btn_SearchService.Name = "Btn_SearchService";
            this.Btn_SearchService.Size = new System.Drawing.Size(217, 72);
            this.Btn_SearchService.TabIndex = 19;
            this.Btn_SearchService.Text = "Search Service Not Posted";
            this.Btn_SearchService.UseVisualStyleBackColor = false;
            this.Btn_SearchService.Click += new System.EventHandler(this.Btn_SearchService_Click);
            // 
            // DateTimerPicker_CreatedDate
            // 
            this.DateTimerPicker_CreatedDate.CustomFormat = "yyyy-MM-dd";
            this.DateTimerPicker_CreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimerPicker_CreatedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimerPicker_CreatedDate.Location = new System.Drawing.Point(105, 30);
            this.DateTimerPicker_CreatedDate.Name = "DateTimerPicker_CreatedDate";
            this.DateTimerPicker_CreatedDate.Size = new System.Drawing.Size(217, 26);
            this.DateTimerPicker_CreatedDate.TabIndex = 3;
            this.DateTimerPicker_CreatedDate.ValueChanged += new System.EventHandler(this.DateTimerPicker_CreatedDate_ValueChanged);
            // 
            // Lbl_InputDate
            // 
            this.Lbl_InputDate.AutoSize = true;
            this.Lbl_InputDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InputDate.Location = new System.Drawing.Point(6, 32);
            this.Lbl_InputDate.Name = "Lbl_InputDate";
            this.Lbl_InputDate.Size = new System.Drawing.Size(156, 17);
            this.Lbl_InputDate.TabIndex = 1;
            this.Lbl_InputDate.Text = "Delivery Week Date:";
            // 
            // reportViewerServiceNotReady
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.uspReportNotReadyToPostBindingSource;
            this.reportViewerServiceNotReady.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewerServiceNotReady.LocalReport.ReportEmbeddedResource = "ClientQuoting.Report3.rdlc";
            this.reportViewerServiceNotReady.Location = new System.Drawing.Point(13, 194);
            this.reportViewerServiceNotReady.Name = "reportViewerServiceNotReady";
            this.reportViewerServiceNotReady.Size = new System.Drawing.Size(845, 492);
            this.reportViewerServiceNotReady.TabIndex = 28;
            // 
            // DataSetReportServiceNotReady
            // 
            this.DataSetReportServiceNotReady.DataSetName = "DataSetReportServiceNotReady";
            this.DataSetReportServiceNotReady.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspReportNotReadyToPostBindingSource
            // 
            this.uspReportNotReadyToPostBindingSource.DataMember = "uspReportNotReadyToPost";
            this.uspReportNotReadyToPostBindingSource.DataSource = this.DataSetReportServiceNotReady;
            // 
            // uspReportNotReadyToPostTableAdapter
            // 
            this.uspReportNotReadyToPostTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportServiceNotReady
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1289, 814);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewerServiceNotReady);
            this.Controls.Add(this.GrpboxServiceProvided);
            this.Name = "FormReportServiceNotReady";
            this.Text = "FormReportService";
            this.Load += new System.EventHandler(this.FormReportServiceNotReady_Load);
            this.GrpboxServiceProvided.ResumeLayout(false);
            this.GrpboxServiceProvided.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportServiceNotReady)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspReportNotReadyToPostBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpboxServiceProvided;
        private System.Windows.Forms.DateTimePicker DateTimerPicker_CreatedDate;
        private System.Windows.Forms.Label Lbl_InputDate;
        private System.Windows.Forms.Button Btn_SearchService;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerServiceNotReady;
        private System.Windows.Forms.BindingSource uspReportNotReadyToPostBindingSource;
        private DataSetReportServiceNotReady DataSetReportServiceNotReady;
        private DataSetReportServiceNotReadyTableAdapters.uspReportNotReadyToPostTableAdapter uspReportNotReadyToPostTableAdapter;
    }
}