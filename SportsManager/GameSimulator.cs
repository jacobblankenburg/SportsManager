using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManager
{
    public class GameSimulator
    {
        FileWritter fw = new FileWritter();
        FileReader fr = new FileReader();
        UserControls usercontrols = new UserControls();
        Manager manager = new Manager();

        int goal = 0;
        int opponentGoal = 0;

        public void SimulateGame()
        {
            Console.WriteLine("Game Simulator\n");

            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine("The Game clock is at {0} minutes\n", i);
                Console.WriteLine("The Score is {0} to {1}\n", goal, opponentGoal);
                Console.WriteLine("Please select a play\n");
                Console.WriteLine("1 = Protect Net\n 2 = Back Check\n 3 = Charge the net\n 4 = Counter Attack\n 5 = Call CustomPlay\n 6 = Call TimeOut\n 7 = Score Goal\n 8 = Give up Goal\n 9 = New play Clock\n 0 = Menu\n");
                do
                {
                    switch (Console.ReadKey().KeyChar.ToString())
                    {

                        case "1":
                            Console.WriteLine(" Team is now protecting your net");
                            continue;

                        case "2":
                            Console.WriteLine(" Team is now back checking");
                            continue;

                        case "3":
                            Console.WriteLine(" Team is now charging the net");
                            continue;

                        case "4":
                            Console.WriteLine(" Team is Counter attacking oppenent");
                            continue;

                        case "5":
                            fr.ReadFromFile("../../CustomPlay.txt");
                            continue;

                        case "6":
                            Console.WriteLine(" User called a timeout");
                            continue;

                        case "7":
                            Console.WriteLine(" User scored a goal");
                            ScoreGoal();
                            continue;

                        case "8":
                            Console.WriteLine(" Opponent scored a goal");
                            ScoredOn();
                            continue;

                        case "9":
                            break;

                        case "0":
                            Console.WriteLine(" Menu:   \n");
                            usercontrols.GetUserControl();
                            return;

                        default:
                            Console.WriteLine(" Not valid user input");
                            continue;
                    }

                    break;

                } while (true);

                Console.WriteLine(" ->\n");
            }
            Console.WriteLine("Menu: ");
            usercontrols.GetUserControl();
        }
        public void ReadCustomPlay()
        {
            StreamReader file = new StreamReader("../../CustomPlay.txt");
            string inPut = file.ReadToEnd();
            Console.WriteLine(inPut);
            file.Close();
            Console.ReadLine();
        }
        public void ScoreGoal()
        {
            goal++;
            Console.WriteLine(goal);
        }
        public void ScoredOn()
        {
            opponentGoal++;
            Console.WriteLine(opponentGoal);
        }
    }
}
    