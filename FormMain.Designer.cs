namespace ClientQuoting
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.MenuItems = new System.Windows.Forms.MenuStrip();
            this.MenuItemParticipants = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemServiceQuote = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceProvidedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportClientPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportServiceProvidedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportServiceNotReadyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lb_Footer = new System.Windows.Forms.Label();
            this.Lbl_footercopywrite = new System.Windows.Forms.Label();
            this.linkLabelGDS = new System.Windows.Forms.LinkLabel();
            this.pictureBoxGdsLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxGds = new System.Windows.Forms.PictureBox();
            this.MenuItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGdsLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGds)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuItems
            // 
            this.MenuItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MenuItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemParticipants,
            this.MenuItemServiceQuote,
            this.serviceProvidedMenuItem,
            this.reportsToolStripMenuItem,
            this.ExportToCSVToolStripMenuItem});
            this.MenuItems.Location = new System.Drawing.Point(0, 0);
            this.MenuItems.Name = "MenuItems";
            this.MenuItems.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.MenuItems.Size = new System.Drawing.Size(1904, 29);
            this.MenuItems.TabIndex = 0;
            this.MenuItems.Text = "Client Quoting Menus";
            // 
            // MenuItemParticipants
            // 
            this.MenuItemParticipants.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemParticipants.Image")));
            this.MenuItemParticipants.Name = "MenuItemParticipants";
            this.MenuItemParticipants.Size = new System.Drawing.Size(160, 25);
            this.MenuItemParticipants.Text = "Participant Plan";
            this.MenuItemParticipants.Click += new System.EventHandler(this.MenuItemParticipants_Click);
            // 
            // MenuItemServiceQuote
            // 
            this.MenuItemServiceQuote.Image = global::ClientQuoting.Properties.Resources.Quote;
            this.MenuItemServiceQuote.Name = "MenuItemServiceQuote";
            this.MenuItemServiceQuote.Size = new System.Drawing.Size(160, 25);
            this.MenuItemServiceQuote.Text = "Quote Accepted";
            this.MenuItemServiceQuote.Click += new System.EventHandler(this.MenuItemServiceQuote_Click);
            // 
            // serviceProvidedMenuItem
            // 
            this.serviceProvidedMenuItem.Image = global::ClientQuoting.Properties.Resources.Services;
            this.serviceProvidedMenuItem.Name = "serviceProvidedMenuItem";
            this.serviceProvidedMenuItem.Size = new System.Drawing.Size(167, 25);
            this.serviceProvidedMenuItem.Text = "Service Provided";
            this.serviceProvidedMenuItem.Click += new System.EventHandler(this.serviceProvidedMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportClientPlanToolStripMenuItem,
            this.reportServiceProvidedToolStripMenuItem,
            this.reportServiceNotReadyToolStripMenuItem});
            this.reportsToolStripMenuItem.Image = global::ClientQuoting.Properties.Resources.Report;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // reportClientPlanToolStripMenuItem
            // 
            this.reportClientPlanToolStripMenuItem.Image = global::ClientQuoting.Properties.Resources.ClientPlanReportsvg;
            this.reportClientPlanToolStripMenuItem.Name = "reportClientPlanToolStripMenuItem";
            this.reportClientPlanToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.reportClientPlanToolStripMenuItem.Text = "Report Client Plan";
            this.reportClientPlanToolStripMenuItem.Click += new System.EventHandler(this.reportClientPlanToolStripMenuItem_Click);
            // 
            // reportServiceProvidedToolStripMenuItem
            // 
            this.reportServiceProvidedToolStripMenuItem.Image = global::ClientQuoting.Properties.Resources.ServiceReport;
            this.reportServiceProvidedToolStripMenuItem.Name = "reportServiceProvidedToolStripMenuItem";
            this.reportServiceProvidedToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.reportServiceProvidedToolStripMenuItem.Text = "Report Service Provided";
            this.reportServiceProvidedToolStripMenuItem.Click += new System.EventHandler(this.reportServiceProvidedToolStripMenuItem_Click);
            // 
            // reportServiceNotReadyToolStripMenuItem
            // 
            this.reportServiceNotReadyToolStripMenuItem.Image = global::ClientQuoting.Properties.Resources.Notready;
            this.reportServiceNotReadyToolStripMenuItem.Name = "reportServiceNotReadyToolStripMenuItem";
            this.reportServiceNotReadyToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.reportServiceNotReadyToolStripMenuItem.Text = "Report Service Not Ready";
            this.reportServiceNotReadyToolStripMenuItem.Click += new System.EventHandler(this.reportServiceNotReadyToolStripMenuItem_Click);
            // 
            // ExportToCSVToolStripMenuItem
            // 
            this.ExportToCSVToolStripMenuItem.Image = global::ClientQuoting.Properties.Resources.Exportcsvfile;
            this.ExportToCSVToolStripMenuItem.Name = "ExportToCSVToolStripMenuItem";
            this.ExportToCSVToolStripMenuItem.Size = new System.Drawing.Size(235, 25);
            this.ExportToCSVToolStripMenuItem.Text = "Export Service To CSV File";
            this.ExportToCSVToolStripMenuItem.Click += new System.EventHandler(this.ExportToCSVToolStripMenuItem_Click);
            // 
            // Lb_Footer
            // 
            this.Lb_Footer.Location = new System.Drawing.Point(12, 725);
            this.Lb_Footer.Name = "Lb_Footer";
            this.Lb_Footer.Size = new System.Drawing.Size(180, 81);
            this.Lb_Footer.TabIndex = 4;
            this.Lb_Footer.Text = "2/4 Ralph Black Drive, North Wollongong, NSW 2500";
            // 
            // Lbl_footercopywrite
            // 
            this.Lbl_footercopywrite.Location = new System.Drawing.Point(407, 745);
            this.Lbl_footercopywrite.Name = "Lbl_footercopywrite";
            this.Lbl_footercopywrite.Size = new System.Drawing.Size(244, 24);
            this.Lbl_footercopywrite.TabIndex = 5;
            this.Lbl_footercopywrite.Text = "Copywrite © 2017 Greenacres";
            // 
            // linkLabelGDS
            // 
            this.linkLabelGDS.AutoSize = true;
            this.linkLabelGDS.Location = new System.Drawing.Point(410, 766);
            this.linkLabelGDS.Name = "linkLabelGDS";
            this.linkLabelGDS.Size = new System.Drawing.Size(176, 17);
            this.linkLabelGDS.TabIndex = 6;
            this.linkLabelGDS.TabStop = true;
            this.linkLabelGDS.Text = "www.greenacres.net.au";
            this.linkLabelGDS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGDS_LinkClicked);
            // 
            // pictureBoxGdsLogo
            // 
            this.pictureBoxGdsLogo.Image = global::ClientQuoting.Properties.Resources.Gdsfooterlogo;
            this.pictureBoxGdsLogo.Location = new System.Drawing.Point(12, 609);
            this.pictureBoxGdsLogo.Name = "pictureBoxGdsLogo";
            this.pictureBoxGdsLogo.Size = new System.Drawing.Size(204, 150);
            this.pictureBoxGdsLogo.TabIndex = 3;
            this.pictureBoxGdsLogo.TabStop = false;
            // 
            // pictureBoxGds
            // 
            this.pictureBoxGds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxGds.Image = global::ClientQuoting.Properties.Resources.Gds;
            this.pictureBoxGds.Location = new System.Drawing.Point(0, 29);
            this.pictureBoxGds.Name = "pictureBoxGds";
            this.pictureBoxGds.Size = new System.Drawing.Size(1904, 762);
            this.pictureBoxGds.TabIndex = 2;
            this.pictureBoxGds.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1904, 791);
            this.Controls.Add(this.linkLabelGDS);
            this.Controls.Add(this.Lbl_footercopywrite);
            this.Controls.Add(this.Lb_Footer);
            this.Controls.Add(this.pictureBoxGdsLogo);
            this.Controls.Add(this.pictureBoxGds);
            this.Controls.Add(this.MenuItems);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuItems;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "CLIENT QUOTING TOOL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MenuItems.ResumeLayout(false);
            this.MenuItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGdsLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuItems;
        private System.Windows.Forms.ToolStripMenuItem MenuItemParticipants;
        private System.Windows.Forms.ToolStripMenuItem MenuItemServiceQuote;
        private System.Windows.Forms.ToolStripMenuItem serviceProvidedMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportClientPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportServiceProvidedToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxGds;
        private System.Windows.Forms.PictureBox pictureBoxGdsLogo;
        private System.Windows.Forms.Label Lb_Footer;
        private System.Windows.Forms.Label Lbl_footercopywrite;
        private System.Windows.Forms.LinkLabel linkLabelGDS;
        private System.Windows.Forms.ToolStripMenuItem reportServiceNotReadyToolStripMenuItem;
    }
}