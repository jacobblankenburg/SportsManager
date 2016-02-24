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

        List<string> GameLineUp = new List<string>();

        public void ManagerSelectsPlayer()
        {
            Console.WriteLine("Choose 1 for adding players to the lineup or 2 to remove players from lineup. 3 to exit and return to home page");
            int ManagerMove = 0;

            switch (ManagerMove)
            {
                case 1:
                    Console.WriteLine("Add:");
                    AddPlayers();
                    break;
                case 2:
                    Console.WriteLine("Remove:");
                    RemovePlayers();
                    break;
                
                //case 3:
                //    return ManagerMove();
            }
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
        public override string ToString()
        {
            return (GameLineUp + " ");
        }
    }
}
