namespace CIS2225_Assignment4_Ashton_Sherri.PresentationLayer
{
    partial class frmView
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
            this.lblMissionsInfo = new System.Windows.Forms.Label();
            this.rtbMissions = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblMissionsInfo
            // 
            this.lblMissionsInfo.AutoSize = true;
            this.lblMissionsInfo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissionsInfo.ForeColor = System.Drawing.Color.Navy;
            this.lblMissionsInfo.Location = new System.Drawing.Point(236, 40);
            this.lblMissionsInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMissionsInfo.Name = "lblMissionsInfo";
            this.lblMissionsInfo.Size = new System.Drawing.Size(296, 22);
            this.lblMissionsInfo.TabIndex = 1;
            this.lblMissionsInfo.Text = "Space Missions Created/Updated";
            // 
            // rtbMissions
            // 
            this.rtbMissions.BackColor = System.Drawing.Color.LightGray;
            this.rtbMissions.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMissions.Location = new System.Drawing.Point(26, 104);
            this.rtbMissions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtbMissions.Name = "rtbMissions";
            this.rtbMissions.ReadOnly = true;
            this.rtbMissions.Size = new System.Drawing.Size(811, 272);
            this.rtbMissions.TabIndex = 2;
            this.rtbMissions.Text = "";
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(870, 509);
            this.Controls.Add(this.rtbMissions);
            this.Controls.Add(this.lblMissionsInfo);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmView";
            this.Text = "View";
            this.Load += new System.EventHandler(this.frmView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMissionName;
        private System.Windows.Forms.ComboBox cmbLaunchMonth;
        private System.Windows.Forms.ComboBox cmbDestinationPlanet;
        private System.Windows.Forms.ComboBox cmbStatusMission;
        private System.Windows.Forms.Label lblMissionName;
        private System.Windows.Forms.Label lblLaunchMonth;
        private System.Windows.Forms.Label lblDestinationPlanet;
        private System.Windows.Forms.Label lblStatusMission;
        private System.Windows.Forms.Label lblMissionsInfo;
        private System.Windows.Forms.RichTextBox rtbMissions;
    }
}