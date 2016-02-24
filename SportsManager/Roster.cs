using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManager
{
    public class Roster
    {
        List<string> Forwards = new List<string>();
        List<string> Defence = new List<string>();
        List<string> Goalies = new List<string>();

        public Roster()
        {

            Forwards.Add("Jonathon Towes #19");
            Forwards.Add("Andrew Shaw #65");
            Forwards.Add("Artemi Panarin #72");
            Forwards.Add("Marian Hossa #81");
            Forwards.Add("Teuvo Teravainen #86");
            Forwards.Add("Patrick Kane #88");

            Defence.Add("Duncan Kieth #2");
            Defence.Add("Niklas Hjalmarsson #4");
            Defence.Add("Brent Seabrook #7");
            Defence.Add("Michal Rozsival #32");

            Goalies.Add("Corey Crawford #30");
            Goalies.Add("Scott Darling #33");

        }
        public void displayRoster()
        {
            Console.WriteLine("Forwards:");
            Forwards.ForEach(Console.WriteLine);
            Console.ReadLine();
            Console.WriteLine("Defence:");
            Defence.ForEach(Console.WriteLine);
            Console.ReadLine();
            Console.WriteLine("Goalies:");
            Goalies.ForEach(Console.WriteLine);
            //foreach (string forward in Forwards)
            //{
            //    Console.WriteLine("Forwards:");
            //    Console.WriteLine(forward);
            //    Console.ReadLine();
            //}
            //foreach (string defence in Defence)
            //{
            //    Console.WriteLine("Defence:");
            //    Console.WriteLine(defence);
            //    Console.ReadLine();
            //}
            //foreach (string goalie in Goalies)
            //{
            //    Console.WriteLine("Goalies:");
            //    Console.WriteLine(goalie);
            //    Console.ReadLine();
            //}
        }


    }
}
