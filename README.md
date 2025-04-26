                                     SELMAN MOHAMMED DBU1501463
🚓🚒🚑 Emergency Response Simulation
A C# console-based simulation game where emergency units respond to different incidents based on their specialization.
Built to practice OOP concepts like abstraction, inheritance, and polymorphism.

📋 Overview
In this project:

Police, Firefighters, and Ambulances respond to specific types of incidents.

Incidents occur randomly at different locations.

Correct responses earn points; unhandled incidents lose points.

The simulation runs for 5 rounds.

🛠️ Technologies Used
C# (.NET Core / .NET Framework)

Console Application

Visual Studio, Rider, or any C#-supported IDE

📂 Project Structure
plaintext
Copy
Edit
EmergencyResponseSimulation/
├── Program.cs
└── README.md
All classes are contained in Program.cs for simplicity:

EmergencyUnit (abstract base class)

Police, Firefighter, Ambulance (child classes)

Incident (incident information)

Program (main simulation loop)

🚨 Game Flow
At the start of each turn, a random incident is created.

The system checks which emergency unit can handle it.

If a unit responds:

✅ +10 points

If no unit can respond:

❌ -5 points

Score updates after each turn.

After 5 rounds, the final score is displayed.

✨ Example Console Output
pgsql
Copy
Edit
--- Turn 2 ---
Incident: Fire at Mall
Firefighter Unit 1 is extinguishing a fire at Mall.
+10 points
Current Score: 20

--- Turn 5 ---
Incident: Flood at Downtown
No unit available to handle the incident.
-5 points
Current Score: 35

--- Simulation Complete ---
Final Score: 35
📈 Scoring Rules

Event	Points
Correct unit responds	+10
No unit available	-5
🧠 Concepts Demonstrated
Abstraction: EmergencyUnit defines a common interface for all units.

Inheritance: Police, Firefighter, Ambulance inherit from EmergencyUnit.

Polymorphism: Units respond differently to incidents.

Encapsulation: Properties are exposed with controlled access.

Randomization: Incidents and locations are randomly generated.

Basic Game Loop: Turn-based logic handled inside a loop.

🧩 Text-Based Structure
EmergencyUnit (abstract class)
├── Properties:
│   ├── Name : string
│   ├── Speed : int
├── Methods:
│   ├── CanHandle(string incidentType) : bool (abstract)
│   └── RespondToIncident(Incident incident) : void (abstract)

Police (inherits EmergencyUnit)
├── CanHandle("Crime")
├── RespondToIncident(...)

Firefighter (inherits EmergencyUnit)
├── CanHandle("Fire")
├── RespondToIncident(...)

Ambulance (inherits EmergencyUnit)
├── CanHandle("Medical")
├── RespondToIncident(...)

Incident (class)
├── Properties:
│   ├── Type : string
│   └── Location : string

Program (class)
├── Main Method:
│   ├── Creates units
│   ├── Randomly generates incidents
│   ├── Units respond if able
│   ├── Tracks score over 5 rounds


📋 How to Run the Project
Clone or download the repository.

Open the project in Visual Studio (or any C# IDE).

Build and run the program.

Watch the simulation play out in the console!

bash
Copy
Edit
git clone https://github.com/yourusername/EmergencyResponseSimulation.git
cd EmergencyResponseSimulation
# Open and run Program.cs
🔥 Future Improvements (Optional)
Add new unit types (e.g., Flood Response Unit, Earthquake Rescue Team).

Allow players to manually select units instead of auto-selection.

Add unit availability cooldowns after each incident.

Display incident severity levels (minor, moderate, severe).

Visual improvements with colored text for different emergencies.

📜 License
This project is free for personal and educational use!

