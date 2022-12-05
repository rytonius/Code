using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Statements
{
    public static class UsingStatement
    {
        public static void Method() {
            // using statement
            if (!File.Exists("Lincoln.txt")) {
                using (TextWriter tw = File.CreateText("Lincoln.txt")) {
                tw.WriteLine("Four score and seven years ago, ...\n... We fought a war and then...");
                tw.WriteLine("... we Battled Giant dragons ...");
            }
            }
            else {
                using (TextWriter tw = File.AppendText("Lincoln.txt")) {
                    tw.WriteLine("I write that Gandolf should become president...");
                    tw.WriteLine("... or lady of the lake ...");
                }
            }
                
            //using statement
            using (TextReader tr = File.OpenText("Lincoln.txt")) {
                string InputString;
                while( null != (InputString = tr.ReadLine())) {
                    Console.WriteLine(InputString);
                }
            }
        }

    }
}