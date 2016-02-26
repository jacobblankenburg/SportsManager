
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManager
{
    public class Schedule
    {
        UserInput ui = new UserInput();
        FileWritter fw = new FileWritter();
        UserControls usercontrols = new UserControls();

        public void ScheduleforTeam()
        {
            //make a ui for the scedule 

            Console.WriteLine(" Choose 1 to edit Practice Schedule\n Choose 2 to edit Weight Training Schedule\n Choose 3 to edit One on One Schedule\n Choose 4 to edit Game Schedule\n Choose 5 to end program\n Choose 6 to go to Menu\n");

            do
            {
                switch (Console.ReadKey().KeyChar.ToString())
                {

                    case "1":
                        Console.WriteLine(" Practice:");
                        EditPracticeSchedule();
                        continue;

                    case "2":
                        Console.WriteLine(" Weight Training:");
                        EditWeightTrainingSchedule();
                        continue;

                    case "3":
                        Console.WriteLine(" One on One:");
                        EditOneOnOneSchedule();
                        continue;

                    case "4":
                        Console.WriteLine(" Game:");
                        EditGameSchedule();
                        continue;

                    case "5":
                        break;

                    case "6":
                        Console.WriteLine(" Menu:  \n");
                        usercontrols.GetUserControl();
                        return;

                    default:
                        Console.WriteLine(" Not Valid User Input");
                        continue;
                }

                break;

            } while (true);

            Console.WriteLine("Exited");
        }

        public void EditPracticeSchedule()
        {
            List<string> Practice = new List<string>();
            Console.WriteLine("Enter your Practice schedule");
            string practice = Console.ReadLine();
            Practice.Add(practice);
            Console.WriteLine("Practice is on");
            foreach (string s in Practice)
            {
                Console.WriteLine(s);
            }

            fw.WriteToFile("../../PracticeSchedule.txt", Practice);
            Practice.Add(practice);

        }
        public void EditWeightTrainingSchedule()
        {
            List<string> WeightTraining = new List<string>();
            Console.WriteLine("Enter your Weight Training schedule");
            string training = Console.ReadLine();
            WeightTraining.Add(training);
            Console.WriteLine("Weight Training is on");
            foreach (string s in WeightTraining)
            {
                Console.WriteLine(s);
            }
            fw.WriteToFile("../../TrainingSchedule.txt", WeightTraining);
            WeightTraining.Add(training);

        }
        public void EditOneOnOneSchedule()
        {
            List<string> OneOnOne = new List<string>();
            Console.WriteLine("Enter your One on One schedule");
            string oneonone = Console.ReadLine();
            OneOnOne.Add(oneonone);
            Console.WriteLine("You have One on One meetings on");
            foreach (string s in OneOnOne)
            {
                Console.WriteLine(s);
            }
            fw.WriteToFile("../../OneonOneSchedule.txt", OneOnOne);
            OneOnOne.Add(oneonone);

        }
        public void EditGameSchedule()
        {
            List<string> GameSchedule = new List<string>();
            Console.WriteLine("Enter your Game schedule");
            string game = Console.ReadLine();
            GameSchedule.Add(game);
            Console.WriteLine("Games are on");
            foreach (string s in GameSchedule)
            {
                Console.WriteLine(s);
            }
            fw.WriteToFile("../../GameSchedule.txt", GameSchedule);
            GameSchedule.Add(game);

        }
    }
}
