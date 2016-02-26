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
            MakeRoster makeroster = new MakeRoster();
            ViewRoster viewroster = new ViewRoster();
            Schedule schedule = new Schedule();
            ViewSchedules viewschedule = new ViewSchedules();
            LineUp lineup = new LineUp();
            Manager manager = new Manager();
            TeamStats teamstats = new TeamStats();


            Console.WriteLine("           -----------------------------------------------------------------------------------------------");
            Console.WriteLine("---------- Make Roster, View Roster, Edit Schedule, View Schedule, Line Up, Manager Moves, Team Stats, End -----------");
            Console.WriteLine("           -----------------------------------------------------------------------------------------------");
            string Userselect = Console.ReadLine();

            switch (Userselect)
            {
                case "make roster":
                case "Make Roster":
                    makeroster.MakePlayerRoster();
                    break;

                case "view roster":
                case "View Roster":
                    Console.WriteLine("Roster:\n");
                    viewroster.ViewPlayerRoster();
                    break;

                case "edit schedule":
                case "Edit Schedule":
                    schedule.ScheduleforTeam();
                    break;

                case "view schedule":
                case "View Schedule":
                    Console.WriteLine("Schedule:\n");
                    viewschedule.ScheduleSelect();
                    break;

                case "line up":
                case "Line Up":
                    Console.WriteLine("Line Up:\n");
                    lineup.ManagerSelectsPlayer();
                    break;

                case "Manager Moves":
                case "manager moves":
                    Console.WriteLine("Manager moves:\n");
                    manager.CallPlay();
                    break;

                case "team stats":
                case "Team Stats":
                    Console.WriteLine("Team Stats:\n");
                    teamstats.ViewStats();
                    break;

                case "end":
                case "End":
                    Console.WriteLine("---------------------------------Thank you for using TeamManager 1.0---------------------------------------------");
                    break;

                default:
                    Console.WriteLine("Not valid input");
                    break;

            }
        }
    }
}

