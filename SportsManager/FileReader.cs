using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManager
{
    public class FileReader
    {
        public string fileName;

        public string ReadFromFile(string fileName)
        {
            StreamReader file = new StreamReader(fileName);
            string inPut = file.ReadToEnd();
            Console.WriteLine(inPut);
            file.Close();
            Console.ReadLine();
            return inPut;
            
        }
    }
}