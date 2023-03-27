using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace LearnFileSystems
{
    public static class FileSystems
    {
        public static void GetDirectory()
        {
            string pathFile = "./test/text.txt";
            if (!File.Exists(pathFile))
                File.Create("./test/text.txt");
            WriteLine(Directory.GetCurrentDirectory());
           foreach (string file in Directory.EnumerateFiles("./"))
            {
                WriteLine(file);
            }

            WriteLine("Directories");
            

            List<string> StoreDirectories = new List<string>();
            
            foreach (string Directory in Directory.GetDirectories("./"))
            {
                WriteLine(Directory);
                StoreDirectories.Add(Directory);
            }

            StoreDirectories.ForEach(delegate (string pathToDir)
            {
                foreach (string file in Directory.GetFiles(pathToDir))
                {
                    WriteLine(file);
                }
            });
            
            


        }
    }
}
