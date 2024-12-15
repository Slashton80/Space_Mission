namespace CIS2225_Assignment4_Ashton_Sherri.PresentationLayer
{
    partial class frmEdit
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
            this.lblStatusMission = new System.Windows.Forms.Label();
            this.lblDestinationPlanet = new System.Windows.Forms.Label();
            this.lblLaunchMonth = new System.Windows.Forms.Label();
            this.lblMissionName = new System.Windows.Forms.Label();
            this.txtMissionName = new System.Windows.Forms.TextBox();
            this.cmbStatusMission = new System.Windows.Forms.ComboBox();
            this.cmbLaunchMonth = new System.Windows.Forms.ComboBox();
            this.cmbDestinationPlanet = new System.Windows.Forms.ComboBox();
            this.lblSelectDestination = new System.Windows.Forms.Label();
            this.cmbMissionsCreated = new System.Windows.Forms.ComboBox();
            this.btnUpdateMission = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStatusMission
            // 
            this.lblStatusMission.AutoSize = true;
            this.lblStatusMission.Location = new System.Drawing.Point(230, 375);
            this.lblStatusMission.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStatusMission.Name = "lblStatusMission";
            this.lblStatusMission.Size = new System.Drawing.Size(59, 19);
            this.lblStatusMission.TabIndex = 10;
            this.lblStatusMission.Text = "Status:";
            // 
            // lblDestinationPlanet
            // 
            this.lblDestinationPlanet.AutoSize = true;
            this.lblDestinationPlanet.Location = new System.Drawing.Point(230, 301);
            this.lblDestinationPlanet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDestinationPlanet.Name = "lblDestinationPlanet";
            this.lblDestinationPlanet.Size = new System.Drawing.Size(151, 19);
            this.lblDestinationPlanet.TabIndex = 9;
            this.lblDestinationPlanet.Text = "Destination Planet:";
            // 
            // lblLaunchMonth
            // 
            this.lblLaunchMonth.AutoSize = true;
            this.lblLaunchMonth.Location = new System.Drawing.Point(230, 230);
            this.lblLaunchMonth.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLaunchMonth.Name = "lblLaunchMonth";
            this.lblLaunchMonth.Size = new System.Drawing.Size(122, 19);
            this.lblLaunchMonth.TabIndex = 8;
            this.lblLaunchMonth.Text = "Launch Month:";
            // 
            // lblMissionName
            // 
            this.lblMissionName.AutoSize = true;
            this.lblMissionName.Location = new System.Drawing.Point(230, 155);
            this.lblMissionName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMissionName.Name = "lblMissionName";
            this.lblMissionName.Size = new System.Drawing.Size(116, 19);
            this.lblMissionName.TabIndex = 7;
            this.lblMissionName.Text = "Mission Name:";
            // 
            // txtMissionName
            // 
            this.txtMissionName.Location = new System.Drawing.Point(462, 148);
            this.txtMissionName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMissionName.Name = "txtMissionName";
            this.txtMissionName.Size = new System.Drawing.Size(179, 26);
            this.txtMissionName.TabIndex = 1;
            // 
            // cmbStatusMission
            // 
            this.cmbStatusMission.FormattingEnabled = true;
            this.cmbStatusMission.Location = new System.Drawing.Point(462, 367);
            this.cmbStatusMission.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbStatusMission.Name = "cmbStatusMission";
            this.cmbStatusMission.Size = new System.Drawing.Size(179, 27);
            this.cmbStatusMission.TabIndex = 4;
            // 
            // cmbLaunchMonth
            // 
            this.cmbLaunchMonth.FormattingEnabled = true;
            this.cmbLaunchMonth.Location = new System.Drawing.Point(462, 222);
            this.cmbLaunchMonth.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbLaunchMonth.Name = "cmbLaunchMonth";
            this.cmbLaunchMonth.Size = new System.Drawing.Size(179, 27);
            this.cmbLaunchMonth.TabIndex = 2;
            // 
            // cmbDestinationPlanet
            // 
            this.cmbDestinationPlanet.FormattingEnabled = true;
            this.cmbDestinationPlanet.Location = new System.Drawing.Point(462, 293);
            this.cmbDestinationPlanet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbDestinationPlanet.Name = "cmbDestinationPlanet";
            this.cmbDestinationPlanet.Size = new System.Drawing.Size(179, 27);
            this.cmbDestinationPlanet.TabIndex = 3;
            // 
            // lblSelectDestination
            // 
            this.lblSelectDestination.AutoSize = true;
            this.lblSelectDestination.Location = new System.Drawing.Point(230, 68);
            this.lblSelectDestination.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSelectDestination.Name = "lblSelectDestination";
            this.lblSelectDestination.Size = new System.Drawing.Size(216, 19);
            this.lblSelectDestination.TabIndex = 6;
            this.lblSelectDestination.Text = "Choose Mission Destination:";
            // 
            // cmbMissionsCreated
            // 
            this.cmbMissionsCreated.Location = new System.Drawing.Point(462, 57);
            this.cmbMissionsCreated.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbMissionsCreated.Name = "cmbMissionsCreated";
            this.cmbMissionsCreated.Size = new System.Drawing.Size(179, 27);
            this.cmbMissionsCreated.TabIndex = 0;
            this.cmbMissionsCreated.SelectedIndexChanged += new System.EventHandler(this.cmbMissionsCreated_SelectedIndexChanged);
            // 
            // btnUpdateMission
            // 
            this.btnUpdateMission.Location = new System.Drawing.Point(468, 440);
            this.btnUpdateMission.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnUpdateMission.Name = "btnUpdateMission";
            this.btnUpdateMission.Size = new System.Drawing.Size(173, 34);
            this.btnUpdateMission.TabIndex = 5;
            this.btnUpdateMission.Text = "Update Mission";
            this.btnUpdateMission.UseVisualStyleBackColor = true;
            this.btnUpdateMission.Click += new System.EventHandler(this.btnUpdateMission_Click);
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(870, 509);
            this.Controls.Add(this.btnUpdateMission);
            this.Controls.Add(this.cmbMissionsCreated);
            this.Controls.Add(this.lblSelectDestination);
            this.Controls.Add(this.lblStatusMission);
            this.Controls.Add(this.lblDestinationPlanet);
            this.Controls.Add(this.lblLaunchMonth);
            this.Controls.Add(this.lblMissionName);
            this.Controls.Add(this.txtMissionName);
            this.Controls.Add(this.cmbStatusMission);
            this.Controls.Add(this.cmbLaunchMonth);
            this.Controls.Add(this.cmbDestinationPlanet);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmEdit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatusMission;
        private System.Windows.Forms.Label lblDestinationPlanet;
        private System.Windows.Forms.Label lblLaunchMonth;
        private System.Windows.Forms.Label lblMissionName;
        private System.Windows.Forms.TextBox txtMissionName;
        private System.Windows.Forms.ComboBox cmbStatusMission;
        private System.Windows.Forms.ComboBox cmbLaunchMonth;
        private System.Windows.Forms.ComboBox cmbDestinationPlanet;
        private System.Windows.Forms.Label lblSelectDestination;
        private System.Windows.Forms.ComboBox cmbMissionsCreated;
        
        private System.Windows.Forms.Button btnUpdateMission;
    }
}