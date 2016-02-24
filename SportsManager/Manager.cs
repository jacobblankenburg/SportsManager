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
        Random random = new Random();
        public void CustomPlaySelect()
        {
            Console.WriteLine("Would you like to use a random play or a custom play?\n");
            Console.WriteLine("To use a custom play please go to the CustomPlay.txt and enter the play there\n");
            string ManagerSelect = Console.ReadLine();

            switch (ManagerSelect)
            {
                case "random play":
                case "random":
                    RandomPlay();
                    break;
                case "custom play":
                case "custom":
                    ReadCustomPlay();
                    break;
            }

        }
        public void RandomPlay()
        {
            var number = random.Next(1, 4);

            if (number == 1)
            {
                Console.WriteLine("Overload the net");
            }
            if (number == 2)
            {
                Console.WriteLine("Crash the net");
            }
            if (number == 3)
            {
                Console.WriteLine("BackCheck");
            }
            if (number == 4)
            {
                Console.WriteLine("protect the net");
            }
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
