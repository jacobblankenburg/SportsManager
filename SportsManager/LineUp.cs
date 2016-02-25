using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManager
{
    public class LineUp
    {
        UserControls usercontrols = new UserControls();
        FileWritter fw = new FileWritter();
        FileReader fr = new FileReader();
        List<string> GameLineUp = new List<string>();

        public void ManagerSelectsPlayer()
        {
            Console.WriteLine(" Choose 1 for adding players to the lineup \n Choose 2 to remove players from lineup\n Choose 3 to display your Lineup\n Choose 4 to save Lineup\n Choose 5 to display roster\n Choose 6 to end program\n Choose 7 to go to Menu");

            do
            {
                switch (Console.ReadKey().KeyChar.ToString())
                {

                    case "1":
                        Console.WriteLine(" Add:");
                        AddPlayers();
                        continue;

                    case "2":
                        Console.WriteLine(" Remove:");
                        RemovePlayers();
                        continue;

                    case "3":
                        Console.WriteLine(" LineUp:");
                        foreach (string s in GameLineUp)
                        {
                            Console.WriteLine(s);
                        }
                        continue;
                    case "4":
                        Console.WriteLine(" Save Lineup:");
                        SavelineUp();
                        continue;

                    case "5":
                        Console.WriteLine(" Roster:");
                        fr.ReadFromFile("../../Roster.txt");
                        continue;

                    case "6":
                         break;

                    case "7":
                        Console.WriteLine(" Menu:   ");
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

        public void AddPlayers()
        {
            string input = Console.ReadLine();
            GameLineUp.Add(input);
        }
        public void RemovePlayers()
        {
            string input = Console.ReadLine();
            GameLineUp.Remove(input);
        }
        public void DisplayPlayers()
        {
            Console.WriteLine(GameLineUp);
        }
        public void SavelineUp()
        {
            fw.WriteToFile("../../LineUp.txt", GameLineUp);
        }
        public override string ToString()
        {
            return (GameLineUp + " ");
        }
    }
}
