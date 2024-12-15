using CIS2225_Assignment4_Ashton_Sherri.BusinessObject;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

// ******************************************************************************************
// Name: Sherri Ashton
// Date: 2024-11-5
// Description: Main form allows the user to create new space missions by entering details such as
//              the mission name, launch month, destination planet, and mission status.
//              The form provides options to view and edit existing missions through a menu strip.
//              It includes functionality to track unsaved changes, preventing accidental closure without saving data.
//              The form also includes validation to ensure all fields are filled before creating a mission.
// Image Source:https://www.pngkit.com/png/full/41-414396_rocket-rocket-emoji-png.png
// ******************************************************************************************
namespace CIS2225_Assignment4_Ashton_Sherri.PresentationLayer
{
    public partial class frmMain : Form
    {
        // Boolean to track if form has unsaved changes
        private bool formChanged = false;

        public frmMain()
        {
            InitializeComponent();

            // Hooks up change events to track changes
            txtMissionName.TextChanged += InputChanged;
            cmbLaunchMonth.SelectedIndexChanged += InputChanged;
            cmbDestinationPlanet.SelectedIndexChanged += InputChanged;
            cmbStatusMission.SelectedIndexChanged += InputChanged;

            // Hooks up the FormClosing event to confirm unsaved changes
            this.FormClosing += frmMain_FormClosing;
        }
        // Event handler to set formChanged to true when input is changed
        private void InputChanged(object sender, EventArgs e)
        {
            formChanged = true;
        }
        // Event handler for form load to populate combo boxes with values
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Populates combo boxes
            cmbDestinationPlanet.Items.AddRange(SpaceMission.destinationChoices);
            cmbLaunchMonth.Items.AddRange(DateTimeFormatInfo.CurrentInfo.MonthNames.Where(month => !string.IsNullOrEmpty(month)).ToArray());
            // Only "Planned" missions in the main form
            cmbStatusMission.Items.Clear();
            cmbStatusMission.Items.Add("Planned");
        }
        // Event handler for "Create Mission" button click. Validates input and creates a new space mission.
        private void btnCreateMission_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                // Creates mission object and adds it to the static list
                SpaceMission spaceTrip = new SpaceMission
                {
                    MissionName = txtMissionName.Text,
                    LaunchMonth = cmbLaunchMonth.Text,
                    DestinationPlanet = cmbDestinationPlanet.Text,
                    StatusOfMission = cmbStatusMission.Text
                };
                SpaceMission.missions.Add(spaceTrip);
                formChanged = false; // Resets formChanged after saving the mission
                ClearForm();
            }
        }
        // Validates the form fields and highlights missing/invalid fields in red
        private bool ValidateForm()
        {
            bool formOk = true;

            // Mission Name Validation
            if (String.IsNullOrEmpty(txtMissionName.Text))
            {
                formOk = false;
                lblMissionName.ForeColor = Color.Red;
            }
            else
            {
                lblMissionName.ForeColor = Color.Black;
            }

            // Launch Month Validation
            if (String.IsNullOrEmpty(cmbLaunchMonth.Text))
            {
                formOk = false;
                lblLaunchMonth.ForeColor = Color.Red;
            }
            else
            {
                lblLaunchMonth.ForeColor = Color.Black;
            }

            // Destination Planet Validation
            if (String.IsNullOrEmpty(cmbDestinationPlanet.Text))
            {
                formOk = false;
                lblDestinationPlanet.ForeColor = Color.Red;
            }
            else
            {
                lblDestinationPlanet.ForeColor = Color.Black;
            }

            // Status of Mission Validation
            if (String.IsNullOrEmpty(cmbStatusMission.Text))
            {
                formOk = false;
                lblStatusMission.ForeColor = Color.Red;
            }
            else
            {
                lblStatusMission.ForeColor = Color.Black;
            }

            return formOk;
        }
        // Clears all fields in the form after creating or updating a mission
        private void ClearForm()
        {
            txtMissionName.Clear();
            cmbStatusMission.SelectedIndex = -1;
            cmbLaunchMonth.SelectedIndex = -1;
            cmbDestinationPlanet.SelectedIndex = -1;
        }
        // Opens the Edit form to edit existing space missions
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEdit fEdit = new frmEdit();
            fEdit.Show();
        }
        // Opens the View form to view all existing space missions
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmView fView = new frmView();
            fView.Show();
        }
        // Handles the Exit option in the File menu to close the form.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Event handler for form closing
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show(
                    "There are unsaved changes. Are you sure you want to exit without saving?",
                    "Unsaved Changes",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Cancels the close operation
                }
            }
        }

       
    }
}