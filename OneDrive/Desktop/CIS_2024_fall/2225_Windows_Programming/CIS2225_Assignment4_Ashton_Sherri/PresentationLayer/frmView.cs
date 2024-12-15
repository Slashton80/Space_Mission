using CIS2225_Assignment4_Ashton_Sherri.BusinessObject;

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
// ******************************************************************************************
// Name: Sherri Ashton
// Date: 2024-11-5
// Description: View form displays a list of all space missions that have been created so far.
// ******************************************************************************************
namespace CIS2225_Assignment4_Ashton_Sherri.PresentationLayer
{
    public partial class frmView : Form
    {
        public frmView()
        {
            InitializeComponent();
        }
        //Loads the event handler for frmView
        private void frmView_Load(object sender, EventArgs e)
        {
            // Clears any existing text in the RichTextBox
            rtbMissions.Clear();

            // Loops through each mission in the static list and adds formatted text
            foreach (SpaceMission mission in SpaceMission.missions)
            {
                // Appends the "Mission Name" in navy blue
                rtbMissions.SelectionStart = rtbMissions.TextLength;
                rtbMissions.SelectionFont = new Font(rtbMissions.Font, FontStyle.Bold);
                rtbMissions.SelectionColor = Color.Navy;
                rtbMissions.AppendText("Mission Name: " + mission.MissionName + Environment.NewLine);

                // Appends the "Launch Month" in regular style
                rtbMissions.SelectionStart = rtbMissions.TextLength;
                rtbMissions.SelectionFont = new Font(rtbMissions.Font, FontStyle.Bold);
                rtbMissions.SelectionColor = Color.Black;
                rtbMissions.AppendText("Launch Month: " + mission.LaunchMonth + Environment.NewLine);

                // Appends the "Destination Planet" in regular style
                rtbMissions.SelectionStart = rtbMissions.TextLength;
                rtbMissions.SelectionFont = new Font(rtbMissions.Font, FontStyle.Bold);
                rtbMissions.SelectionColor = Color.Black;
                rtbMissions.AppendText("Destination Planet: " + mission.DestinationPlanet + Environment.NewLine);

                // Appends the "Status of Mission" text
                rtbMissions.SelectionStart = rtbMissions.TextLength;
                rtbMissions.SelectionFont = new Font(rtbMissions.Font, FontStyle.Bold);
                rtbMissions.SelectionColor = Color.Black;
                rtbMissions.AppendText("Status of Mission: ");

                // Sets the color based on the mission status
                rtbMissions.SelectionStart = rtbMissions.TextLength;
                rtbMissions.SelectionFont = new Font(rtbMissions.Font, FontStyle.Bold);

                switch (mission.StatusOfMission.ToLower())
                {
                    case "completed":
                        rtbMissions.SelectionColor = Color.Red;
                        break;
                    case "launched":
                        rtbMissions.SelectionColor = Color.Green;
                        break;
                    case "planned":
                        rtbMissions.SelectionColor = Color.Yellow;
                        break;
                    default:
                        rtbMissions.SelectionColor = Color.Black; 
                        break;
                }
                rtbMissions.AppendText(mission.StatusOfMission + Environment.NewLine);

                // Appends a new line for spacing between missions
                rtbMissions.AppendText(Environment.NewLine);
            }
        }
    }
}
