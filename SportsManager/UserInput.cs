using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManager
{
    public class UserInput
    {
        public string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }
    }
}
