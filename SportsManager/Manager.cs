using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SportsManager
{
    public class Manager
    {
        UserControls usercontrols = new UserControls();
        FileReader fr = new FileReader();

        public void CallPlay()
        {
            Console.WriteLine("------------To use a custom play please go to the CustomPlay.txt and enter the play there------------\n");

            Console.WriteLine("1 = Protect Net\n 2 = Back Check\n 3 = Charge the net\n 4 = Counter Attack\n 5 = Call CustomPlay\n 6 = Call TimeOut\n 7 = End Program\n 8 = Menu\n");
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
                        break;

                    case "8":
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
        public void ReadCustomPlay()
        {
            StreamReader file = new StreamReader("../../CustomPlay.txt");
            string inPut = file.ReadToEnd();
            Console.WriteLine(inPut);
            file.Close();
            Console.ReadLine();
        }
    }
}
