namespace CIS2225_Assignment4_Ashton_Sherri.PresentationLayer
{
    partial class frmMain
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
            this.btnCreateMission = new System.Windows.Forms.Button();
            this.cmbDestinationPlanet = new System.Windows.Forms.ComboBox();
            this.cmbLaunchMonth = new System.Windows.Forms.ComboBox();
            this.cmbStatusMission = new System.Windows.Forms.ComboBox();
            this.txtMissionName = new System.Windows.Forms.TextBox();
            this.lblMissionName = new System.Windows.Forms.Label();
            this.lblLaunchMonth = new System.Windows.Forms.Label();
            this.lblDestinationPlanet = new System.Windows.Forms.Label();
            this.lblStatusMission = new System.Windows.Forms.Label();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picRocket = new System.Windows.Forms.PictureBox();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRocket)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateMission
            // 
            this.btnCreateMission.Location = new System.Drawing.Point(478, 339);
            this.btnCreateMission.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateMission.Name = "btnCreateMission";
            this.btnCreateMission.Size = new System.Drawing.Size(182, 34);
            this.btnCreateMission.TabIndex = 4;
            this.btnCreateMission.Text = "Create Mission";
            this.btnCreateMission.UseVisualStyleBackColor = true;
            this.btnCreateMission.Click += new System.EventHandler(this.btnCreateMission_Click);
            // 
            // cmbDestinationPlanet
            // 
            this.cmbDestinationPlanet.FormattingEnabled = true;
            this.cmbDestinationPlanet.Location = new System.Drawing.Point(478, 192);
            this.cmbDestinationPlanet.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDestinationPlanet.Name = "cmbDestinationPlanet";
            this.cmbDestinationPlanet.Size = new System.Drawing.Size(180, 27);
            this.cmbDestinationPlanet.TabIndex = 2;
            // 
            // cmbLaunchMonth
            // 
            this.cmbLaunchMonth.FormattingEnabled = true;
            this.cmbLaunchMonth.Location = new System.Drawing.Point(478, 129);
            this.cmbLaunchMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLaunchMonth.Name = "cmbLaunchMonth";
            this.cmbLaunchMonth.Size = new System.Drawing.Size(180, 27);
            this.cmbLaunchMonth.TabIndex = 1;
            // 
            // cmbStatusMission
            // 
            this.cmbStatusMission.FormattingEnabled = true;
            this.cmbStatusMission.Location = new System.Drawing.Point(478, 261);
            this.cmbStatusMission.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatusMission.Name = "cmbStatusMission";
            this.cmbStatusMission.Size = new System.Drawing.Size(180, 27);
            this.cmbStatusMission.TabIndex = 3;
            // 
            // txtMissionName
            // 
            this.txtMissionName.Location = new System.Drawing.Point(478, 62);
            this.txtMissionName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMissionName.Name = "txtMissionName";
            this.txtMissionName.Size = new System.Drawing.Size(180, 26);
            this.txtMissionName.TabIndex = 0;
            // 
            // lblMissionName
            // 
            this.lblMissionName.AutoSize = true;
            this.lblMissionName.Location = new System.Drawing.Point(323, 69);
            this.lblMissionName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMissionName.Name = "lblMissionName";
            this.lblMissionName.Size = new System.Drawing.Size(116, 19);
            this.lblMissionName.TabIndex = 5;
            this.lblMissionName.Text = "Mission Name:";
            // 
            // lblLaunchMonth
            // 
            this.lblLaunchMonth.AutoSize = true;
            this.lblLaunchMonth.Location = new System.Drawing.Point(317, 137);
            this.lblLaunchMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLaunchMonth.Name = "lblLaunchMonth";
            this.lblLaunchMonth.Size = new System.Drawing.Size(122, 19);
            this.lblLaunchMonth.TabIndex = 6;
            this.lblLaunchMonth.Text = "Launch Month:";
            // 
            // lblDestinationPlanet
            // 
            this.lblDestinationPlanet.AutoSize = true;
            this.lblDestinationPlanet.Location = new System.Drawing.Point(288, 200);
            this.lblDestinationPlanet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestinationPlanet.Name = "lblDestinationPlanet";
            this.lblDestinationPlanet.Size = new System.Drawing.Size(151, 19);
            this.lblDestinationPlanet.TabIndex = 7;
            this.lblDestinationPlanet.Text = "Destination Planet:";
            // 
            // lblStatusMission
            // 
            this.lblStatusMission.AutoSize = true;
            this.lblStatusMission.Location = new System.Drawing.Point(380, 269);
            this.lblStatusMission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusMission.Name = "lblStatusMission";
            this.lblStatusMission.Size = new System.Drawing.Size(59, 19);
            this.lblStatusMission.TabIndex = 8;
            this.lblStatusMission.Text = "Status:";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mnuMain.Size = new System.Drawing.Size(870, 29);
            this.mnuMain.TabIndex = 9;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // picRocket
            // 
            this.picRocket.Image = global::CIS2225_Assignment4_Ashton_Sherri_Space.Properties.Resources.rocket;
            this.picRocket.InitialImage = global::CIS2225_Assignment4_Ashton_Sherri_Space.Properties.Resources.rocket;
            this.picRocket.Location = new System.Drawing.Point(63, 367);
            this.picRocket.Name = "picRocket";
            this.picRocket.Size = new System.Drawing.Size(124, 93);
            this.picRocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRocket.TabIndex = 10;
            this.picRocket.TabStop = false;
           
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(870, 506);
            this.Controls.Add(this.picRocket);
            this.Controls.Add(this.lblStatusMission);
            this.Controls.Add(this.lblDestinationPlanet);
            this.Controls.Add(this.lblLaunchMonth);
            this.Controls.Add(this.lblMissionName);
            this.Controls.Add(this.txtMissionName);
            this.Controls.Add(this.cmbStatusMission);
            this.Controls.Add(this.cmbLaunchMonth);
            this.Controls.Add(this.cmbDestinationPlanet);
            this.Controls.Add(this.btnCreateMission);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Space Mission Hub";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRocket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateMission;
        private System.Windows.Forms.ComboBox cmbDestinationPlanet;
        private System.Windows.Forms.ComboBox cmbLaunchMonth;
        private System.Windows.Forms.ComboBox cmbStatusMission;
        private System.Windows.Forms.TextBox txtMissionName;
        private System.Windows.Forms.Label lblMissionName;
        private System.Windows.Forms.Label lblLaunchMonth;
        private System.Windows.Forms.Label lblDestinationPlanet;
        private System.Windows.Forms.Label lblStatusMission;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.PictureBox picRocket;
    }
}

