using CIS2225_Assignment4_Ashton_Sherri.BusinessObject;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

// ******************************************************************************************
// Name: Sherri Ashton
// Date: 2024-11-5
// Description: Edit form allows the user to select an existing space mission from a list
//              Users can change the status from "Planned" to "Launched," and subsequently from "Launched" to "Completed."
//              Once a mission is marked as "Completed," further edits are no longer allowed.
// ******************************************************************************************
namespace CIS2225_Assignment4_Ashton_Sherri.PresentationLayer
{
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
        }

        // Load event handler for frmEdit
        private void frmEdit_Load(object sender, EventArgs e)
        {
            // Populates missions in combo box for editing
            PopulateMissionsCmb();

            // Populates destination options
            cmbDestinationPlanet.Items.Clear();
            cmbDestinationPlanet.Items.AddRange(SpaceMission.destinationChoices);

            // Populates launch months and status options
            cmbLaunchMonth.Items.Clear();
            cmbLaunchMonth.Items.AddRange(DateTimeFormatInfo.CurrentInfo.MonthNames
                                          .Where(month => !string.IsNullOrEmpty(month)).ToArray());

            cmbStatusMission.Items.Clear();
            //cmbStatusMission.Items.AddRange(new string[] { "Planned", "Launched", "Completed" });
        }

        // Method to populate missions combo box with mission names
        private void PopulateMissionsCmb()
        {
            // Clears and adds all missions into the combo box
            cmbMissionsCreated.Items.Clear();
            foreach (SpaceMission mission in SpaceMission.missions)
            {
                cmbMissionsCreated.Items.Add(mission.MissionName);
            }
        }

        // Event handler for selecting a mission to edit
        private void cmbMissionsCreated_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Gets the selected index from the missions combo box
            int selectedIndex = cmbMissionsCreated.SelectedIndex;

            // Validate that a mission is selected
            if (selectedIndex != -1)
            {
                // Get the selected mission details
                SpaceMission selectedMission = SpaceMission.missions[selectedIndex];

                // Populate the fields in the edit form with the selected mission's data
                txtMissionName.Text = selectedMission.MissionName;
                cmbLaunchMonth.Text = selectedMission.LaunchMonth;
                cmbDestinationPlanet.Text = selectedMission.DestinationPlanet;

                // Clear and update the status combo box based on the current mission status
                cmbStatusMission.Items.Clear();

                switch (selectedMission.StatusOfMission)
                {
                    case "Planned":
                        // If mission is in 'Planned' state, allow all statuses to proceed to 'launched'
                        cmbStatusMission.Items.AddRange(new string[] { "Planned", "Launched" });
                        break;

                    case "Launched":
                        // If mission is already 'Launched', it cannot go back to 'Planned'
                        cmbStatusMission.Items.AddRange(new string[] { "Launched", "Completed" });
                        break;

                    case "Completed":
                        // If mission is 'Completed', it cannot go back to any previous status
                        cmbStatusMission.Items.Add("Completed");
                        break;
                }
                // Setscurrent status as the selected item
                cmbStatusMission.SelectedItem = selectedMission.StatusOfMission;

                // Disables fields if the mission is completed
                if (selectedMission.StatusOfMission == "Completed")
                {
                    SetFieldsEditable(false);
                }
                else
                {
                    SetFieldsEditable(true);
                }
            }
        }

        // Utility method to enable or disable editing fields based on the status
        private void SetFieldsEditable(bool editable)
        {
            txtMissionName.Enabled = editable;
            cmbLaunchMonth.Enabled = editable;
            cmbDestinationPlanet.Enabled = editable;
        }

        // Event handler for updating a mission
        private void btnUpdateMission_Click(object sender, EventArgs e)
        {
            int selectedIndex = cmbMissionsCreated.SelectedIndex;

            // Validates that a mission is selected for update
            if (selectedIndex != -1)
            {
                // Get the selected mission
                SpaceMission selectedMission = SpaceMission.missions[selectedIndex];

                // Checks if mission is completed, prevent updates if true
                if (selectedMission.StatusOfMission == "Completed")
                {
                    MessageBox.Show("Unable to update as mission is completed.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exits the method to prevent any further processing
                }

                // Only allow valid status transitions
                if (selectedMission.StatusOfMission == "Planned" && cmbStatusMission.Text == "Completed")
                {
                    MessageBox.Show("You cannot mark a planned mission as completed without it being launched first.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Prevents updating if attempting to skip status
                }

                // Update the mission attributes
                selectedMission.MissionName = txtMissionName.Text;
                selectedMission.LaunchMonth = cmbLaunchMonth.Text;
                selectedMission.DestinationPlanet = cmbDestinationPlanet.Text;
                selectedMission.StatusOfMission = cmbStatusMission.Text;

                // Confirmation message
                MessageBox.Show("Mission updated successfully!", "Update Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Repopulate the ComboBox with the updated list
                PopulateMissionsCmb();

                // Clear the form after updating
                ClearForm();
            }
            else
            {
                MessageBox.Show("Please select a mission to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clears the form fields after updating a mission
        private void ClearForm()
        {
            txtMissionName.Clear();
            cmbLaunchMonth.SelectedIndex = -1;
            cmbDestinationPlanet.SelectedIndex = -1;
            cmbStatusMission.SelectedIndex = -1;
        }
    }
}
