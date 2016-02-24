using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManager
{
    public class UserControls
    {
        public void GetUserControl()
        {
            LineUp lineup = new LineUp();
            Roster roster = new Roster();
            Schedule schedule = new Schedule();
            Manager manager = new Manager();
            
            Console.WriteLine("View Roster, Schedule, Line Up, Manager Moves, Team Stats\n");
            string Userselect = Console.ReadLine();

            switch (Userselect)
            {
                case "view roster":
                case "View Roster":
                    Console.WriteLine("Roster:\n");
                    roster.displayRoster();
                    break;

                case "schedule":
                case "Schedule":
                    Console.WriteLine("Schedule:\n");
                    schedule.ScheduleforTeam();
                    break;

                case "line up":
                case "Line Up":
                    Console.WriteLine("Line Up:\n");
                    lineup.ManagerSelectsPlayer();
                    break;

                case "Manager Moves":
                case "manager moves":
                    Console.WriteLine("Manager moves:\n");
                    manager.CustomPlaySelect();
                    break;

                case "team stats":
                case "Team Stats":
                    Console.WriteLine("Team Stats:\n");
                    break;
                
            }
        }
    }
}

