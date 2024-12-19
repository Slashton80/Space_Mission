## About the Project
This project was developed as part of my CIS coursework at Holland College PEI in 2024.

# Space Mission Management System

## Project Overview
The Space Mission Management System is a Windows Forms Application designed to create, view, and edit space missions. The system allows users to manage mission details such as name, launch month, destination planet, and mission status. It provides robust validation and status tracking to ensure accurate and meaningful data entry and editing workflows.

---

## Features
- **Mission Creation**: Create new space missions by specifying:
  - Mission Name
  - Launch Month
  - Destination Planet (selectable from predefined options)
  - Status (Planned, Launched, or Completed)
- **Mission Editing**: Edit existing missions with restrictions based on the current status:
  - Planned missions can transition to Launched.
  - Launched missions can transition to Completed.
  - Completed missions are locked from further editing.
- **Mission Viewing**: View a comprehensive list of all created missions with:
  - Details displayed in a rich-text format
  - Color-coded mission statuses (e.g., red for Completed, green for Launched, yellow for Planned)
- **Data Validation**: Ensures all fields are properly filled during mission creation and editing.
- **Unsaved Changes Protection**: Prompts users before exiting if there are unsaved changes.

---

## How It Works
1. **Mission Creation**:
   - Users enter the mission details in the main form.
   - Form validation ensures that all required fields are filled.
   - Once created, the mission is added to a static list for tracking.

2. **Mission Editing**:
   - Users can select an existing mission from a list in the edit form.
   - The form dynamically adjusts available status options based on the current mission status.
   - Missions marked as "Completed" are locked from further edits.

3. **Mission Viewing**:
   - Users can view all created missions in the view form.
   - Details include mission name, launch month, destination planet, and status.
   - Statuses are color-coded for quick identification.

---

## File Structure
- **BusinessObject**:
  - `SpaceMission`: Represents the mission entity with properties, static lists for missions, and predefined destination choices.
- **PresentationLayer**:
  - `frmMain`: Main form for creating new missions and navigating to other forms.
  - `frmEdit`: Allows users to edit existing missions.
  - `frmView`: Displays all missions in a formatted, color-coded list.

---

## Destination Choices
The following planets are supported as mission destinations:
- Mars
- Venus
- Uranus
- Mercury
- Saturn
- Jupiter
- Neptune

---

## Future Enhancements
- Add persistent data storage (e.g., database or file system).
- Integrate a search and filter feature for mission management.
- Include graphical representations of mission statuses.
- Add support for additional destination options and mission attributes.

