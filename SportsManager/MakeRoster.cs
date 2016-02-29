using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManager
{
    public class MakeRoster
    {
        FileWritter fw = new FileWritter();
        Player player = new Player(null,0,null,null,0);
        FileReader fr = new FileReader();
        UserControls usercontrols = new UserControls();

        public void MakePlayerRoster()
        {
            Console.WriteLine(" Choose 1 to add players to the roster \n Choose 2 to display your Roster\n Choose 3 to end program\n Choose 4 to go to Menu\n");

            do
            {
                switch (Console.ReadKey().KeyChar.ToString())
                {

                    case "1":
                        Console.WriteLine(" Add:");
                        GenerateRoster();
                        continue;

                    case "2":
                        Console.WriteLine(" View Roster:");
                        fr.ReadFromFile("../../Roster.txt");
                        continue;

                    case "3":
                        break;
                    case "4":
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


        public void GenerateRoster()
        {
            
            List<Player> TeamRoster = new List<Player>();
            List<string> list = new List<string>();

            Console.WriteLine("Enter the Players name");
            this.player.Name = Console.ReadLine();
            Console.WriteLine("Enter the Players number");
            this.player.Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Players Shot Direction (Right or Left)");
            this.player.ShotDirection = Console.ReadLine();
            Console.WriteLine("Enter the Players Position");
            this.player.PlayerPosition = Console.ReadLine();

            list.Add(player.ToString());
            fw.WriteToFile("../../Roster.txt", list);
            TeamRoster.Add(player);
            Console.WriteLine(player);

        }
    }
}
