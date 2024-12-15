using System.Collections.Generic;

// ******************************************************************************************
// Name: Sherri Ashton
// Date: 2024-11-5
// Description: The SpaceMission class represents a mission to space with attributes such as 
//              mission name, launch month, destination planet, and mission status.
//              It includes a static list to store all created missions, a static collection of
//              destination choices, and an overridden ToString method to display mission details.
// ******************************************************************************************
namespace CIS2225_Assignment4_Ashton_Sherri.BusinessObject
{
    public class SpaceMission
    {
        // Private attributes of the SpaceMission class
        private string missionName;
        private string launchMonth;
        private string destinationPlanet;
        private string statusOfMission;

        // Public properties to access and modify the private attributes
        public string MissionName { get => missionName; set => missionName = value; }
        public string LaunchMonth { get => launchMonth; set => launchMonth = value; }
        public string DestinationPlanet { get => destinationPlanet; set => destinationPlanet = value; }
        public string StatusOfMission { get => statusOfMission; set => statusOfMission = value; }

        // Static list to store all the missions created
        public static List<SpaceMission> missions = new List<SpaceMission>();

        // Static collection of destination choices for the missions
        public static string[] destinationChoices = { "Mars", "Venus", "Uranus", "Mercury", "Saturn", "Jupiter", "Neptune" };

        // Overrides the ToString method to provide a readable representation of a mission
        public override string ToString()
        {
            return $"Mission Name: {missionName}, Launch Month: {launchMonth}, Destination Planet: {destinationPlanet}, Status of Mission: {statusOfMission}";
        }

    }

}