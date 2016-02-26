using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManager
{
    public class TeamStats
    {
        FileReader fr = new FileReader();
        UserControls usercontrols = new UserControls();
        public void ViewStats()
        {
            Console.WriteLine(" 1 = View Stats\n 2 = End Program\n 3 = Menu\n");

            do
            {
                switch (Console.ReadKey().KeyChar.ToString())
                {

                    case "1":
                        Console.WriteLine(" Stats:");
                        fr.ReadFromFile("../../TeamStats.txt");
                        continue;

                    case "2":
                        break;

                    case "3":
                        Console.WriteLine(" Menu:   \n");
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
    }
}
