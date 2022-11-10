using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructorsIndexers
{
    // simple class without indexers
    class Employee
    {
        public string LastName = "Targaryen";
        public string FirstName = "Rhaenyra";
        public string JobTitle = "Princess";
    }
    // same class as above but as with a declared indexer
    class EmployeeIndexer {
        public string LastName = "unknown"; //field 0
        public string FirstName = "unknown"; // field 1
        public string JobTitle = "unknown"; // field 2

        public string this[int index] { // Indexer declaration
            set {   // Set accessor declaration
                switch (index) {
                    case 0: LastName = value;
                        break;
                    case 1: FirstName = value;
                        break;
                    case 2: JobTitle = value;
                        break;

                    default:
                        throw new ArgumentOutOfRangeException("index");  // exception
                }
            }

            get { // get accessor declaration
                switch (index) {
                    case 0: return LastName;
                    case 1: return FirstName;
                    case 2: return JobTitle;

                    default:
                        throw new ArgumentOutOfRangeException("index");
                }
            }
        }
    }

    // another indexer example
    class IndexerExample {
        int Temp0; // private field
        int Temp1;
        public int this [ int index ] { // The indexer
            get {
                return ( 0 == index ) ? Temp0 : Temp1; // return value of either Temp0 or Temp1
            }

            set {
                if( 0 == index)
                    Temp0 = value;
                else
                    Temp1 = value;
            }

        }
    }

    public static class DoStuff {
        public static void NewEmployees() {
            // we are using Dot-syntax and accessing through fields. 
            Employee emp1 = new Employee();

            Console.WriteLine("\nEmployee Example\n");
            Console.WriteLine("Default Employee:\t {2}:\t {0} {1}", emp1.FirstName, emp1.LastName, emp1.JobTitle);

            emp1.LastName =     "Baxter";
            emp1.FirstName =    "James";
            emp1.JobTitle =     "Marine";

            Console.WriteLine("New Employee:\t\t {2}:\t {0} {1}", emp1.FirstName 
                                                                , emp1.LastName
                                                                , emp1.JobTitle);

            // instead of using Dot-syntax notation, we can use index notation
            EmployeeIndexer ei = new EmployeeIndexer();
            ei[0] = "Streisland"; ei[1] = "Barbara"; ei[2] = "Construction";
            Console.WriteLine($"Indexer Employee:\t {ei[2]}:\t {ei[0]} {ei[1]}");

            Console.WriteLine("\n Another indexer Exmample \n");
            IndexerExample ie = new IndexerExample();

            Console.WriteLine("Values -- T0: {0}, T1: {1}", ie[0], ie[1]);
            ie[0] = 15;
            ie[1] = 9000;
            Console.WriteLine("Values -- T0: {0}, T1: {1}", ie[0], ie[1]);
            

        }
    }
}