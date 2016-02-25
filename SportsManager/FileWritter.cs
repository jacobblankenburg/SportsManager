using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManager
{
    public class FileWritter
    {
        public void WriteToFile(string path, List<string> message)
        {
            File.AppendAllLines(path, message);
        }
    }
}