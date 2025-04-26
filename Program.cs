using System;
using System.Collections.Generic;

namespace EmergencyResponseSimulation
{
    // Abstract base class
    abstract class EmergencyUnit
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public EmergencyUnit(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public abstract bool CanHandle(string incidentType);
        public abstract void RespondToIncident(Incident incident);
    }

    // Subclasses for specific units
    class Police : EmergencyUnit
    {
        public Police(string name, int speed) : base(name, speed) { }

        public override bool CanHandle(string incidentType) => incidentType == "Crime";

        public override void RespondToIncident(Incident incident)
        {
            Console.WriteLine($"{Name} is handling a crime at {incident.Location}.");
        }
    }

    class Firefighter : EmergencyUnit
    {
        public Firefighter(string name, int speed) : base(name, speed) { }

        public override bool CanHandle(string incidentType) => incidentType == "Fire";

        public override void RespondToIncident(Incident incident)
        {
            Console.WriteLine($"{Name} is extinguishing a fire at {incident.Location}.");
        }
    }

    class Ambulance : EmergencyUnit
    {
        public Ambulance(string name, int speed) : base(name, speed) { }

        public override bool CanHandle(string incidentType) => incidentType == "Medical";

        public override void RespondToIncident(Incident incident)
        {
            Console.WriteLine($"{Name} is treating patients at {incident.Location}.");
        }
    }

    // Incident class
    class Incident
    {
        public string Type { get; set; }
        public string Location { get; set; }

        public Incident(string type, string location)
        {
            Type = type;
            Location = location;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<string> incidentTypes = new List<string> { "Crime", "Fire", "Medical","Flood", "Earthquake" };
            List<string> locations = new List<string> { "City Hall", "Downtown", "Airport", "Mall", "Park" };
            Random rand = new Random();

            List<EmergencyUnit> units = new List<EmergencyUnit>
            {
                new Police("Police Unit 1", 70),
                new Firefighter("Firefighter Unit 1",65 ), 
                new Ambulance("Ambulance Unit 1", 80)
               
               
            };

            int score = 0;

            for (int turn = 1; turn <= 5; turn++)
            {
                Console.WriteLine($"\n--- Turn {turn} ---");
                string incidentType = incidentTypes[rand.Next(incidentTypes.Count)];
                string location = locations[rand.Next(locations.Count)];
                Incident incident = new Incident(incidentType, location);

                Console.WriteLine($"Incident: {incident.Type} at {incident.Location}");

                bool handled = false;

                foreach (var unit in units)
                {
                    if (unit.CanHandle(incident.Type))
                    {
                        unit.RespondToIncident(incident);
                        score += 10;
                        Console.WriteLine("+10 points");
                        handled = true;
                        break;
                    }
                }

                if (!handled)
                {
                    Console.WriteLine("No unit available to handle the incident.");
                    score -= 5;
                    Console.WriteLine("-5 points");
                }

                Console.WriteLine($"Current Score: {score}");
            }

            Console.WriteLine("\n--- Simulation Complete ---");
            Console.WriteLine($"Final Score: {score}");
        }
    }
}
