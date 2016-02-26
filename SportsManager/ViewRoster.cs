using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManager
{
    public class ViewRoster
    {
        FileReader fr = new FileReader();
        UserControls usercontrols = new UserControls();

        public void ViewPlayerRoster()
        {
            Console.WriteLine(" Choose 1 to view the roster \n Choose 2 end program\n Choose 3 to go to Menu\n");

            do
            {
                switch (Console.ReadKey().KeyChar.ToString())
                {

                    case "1":
                        Console.WriteLine(" Roster:");
                        fr.ReadFromFile("../../Roster.txt");
                        continue;

                    case "2":
                        break;

                    case "3":
                        Console.WriteLine(" Menu:   \n");
                        usercontrols.GetUserControl();
                        return;

                    default:
                        Console.WriteLine(" Not valid user input");
                        continue;
                }

                break;

            } while (true);

            Console.WriteLine("Exited");
        }
    }
}
