
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManager
{
    public class Schedule
    {
        public void ScheduleforTeam()
        {
            Console.WriteLine("What day would you like to see?");
            string Userselect = Console.ReadLine();

            switch (Userselect)
            {
                case "monday":
                case "Monday":
                    Console.WriteLine("9:00 A.M - Weight training (Arms)\n 11:00 A.M - Morning Skate\n 1:30 P.M - Film\n 4:45 P.M Warmups for game \n 7:00 P.M - Game Against Detroit");
                    break;
                case "tuesday":
                case "Tuesday":
                    Console.WriteLine("8:30 A.M - Weight training (Legs)\n 10:00 A.M - Morning Skate\n 2:30 P.M - Film\n 6:00 P.M Practice");
                    break;
                case "wednesday":
                case "Wednesday":
                    Console.WriteLine("9:30 A.M - Weight training (Back)\n 11:15 A.M - Morning Skate\n 1:00 P.M - Film\n 4:45 P.M Warmups for game \n 7:30 P.M - Game Against St.Louis");
                    break;
                case "thursday":
                case "Thursday":
                    Console.WriteLine("9:00 A.M - Weight training (Chest)\n 11:00 A.M - Morning Skate\n 12:30 P.M - Film\n 6:30 P.M Pactice");
                    break;
                case "friday":
                case "Friday":
                    Console.WriteLine("9:15 A.M - Weight training (Cardio)\n 11:20 A.M - Morning Skate\n 12:45 P.M - Film\n 4:45 P.M Warmups for game \n 8:00 P.M - Game Against Tampa Bay");
                    break;

            }
        }
    }
}
