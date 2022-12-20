// What are structs? are programmer-defined data types, similar to classes.
// They have data members and fucntion members.  Although structs are similar to classes
// there are a number of important differnces.  The most important ones are the following:

// classes are reference types, and structs are value types
// structs are implicity sealed, which means they cannot be derived from
using static System.Console;

namespace Structs_Enums
{
    struct Point {
    public int X;
    public int Y;
    }

    class Nice {
        public int X;
    }

    struct CPoint {
        public int X, Y;

        public CPoint(int a, int b) {
            X = a;
            Y = b;
        }
    }

    class Program 
    {
        static void Main() {
            Point first, second, third;

            first.X = 10; first.Y = 10;
            second.X = 22; second.Y = 22;
            third.X = 39;    third.Y = 39;

           

            WriteLine("\nfirst x: {0} - third y: {1}\n Checking memory usage with struct alone", first.X, third.Y);
            WriteLine("Total Allocated Bytes: {0:N2} KB", (GC.GetTotalAllocatedBytes() * 0.001));
            WriteLine("total commited bytes: {0}", GC.GetGCMemoryInfo().TotalCommittedBytes );
            WriteLine("total Heap bytes: {0}", GC.GetGCMemoryInfo().HeapSizeBytes);

            WriteLine("Total Memory {0}\n Allocating a Class now which will be in heap\n", GC.GetTotalMemory(true));

            Nice x = new Nice();
            x.X = 3;
            int y = x.X;

            WriteLine("Total Allocated KBytes: {0:N2} KB", (GC.GetTotalAllocatedBytes() * 0.001));
            WriteLine("total commited Kbytes: {0:N2} KB", (GC.GetGCMemoryInfo().TotalCommittedBytes * 0.001));
            WriteLine("total Heap Kbytes: {0:N2} KB", (GC.GetGCMemoryInfo().HeapSizeBytes * 0.001));

            WriteLine("Total Memory {0:N2} KB", (GC.GetTotalMemory(true) * 0.001));
            
            Point fourth = first;
            WriteLine("\nAdded another structure\n");
            WriteLine("Total Allocated KBytes: {0:N2} KB", (GC.GetTotalAllocatedBytes() * 0.001));
            WriteLine("total commited Kbytes: {0:N2} KB", (GC.GetGCMemoryInfo().TotalCommittedBytes * 0.001));
            WriteLine("total Heap Kbytes: {0:N2} KB", (GC.GetGCMemoryInfo().HeapSizeBytes * 0.001));

            WriteLine("Total Memory {0:N2} KB", (GC.GetTotalMemory(true) * 0.001));
            WriteLine("\nstruct with constructor\n");

            CPoint Fifth= new CPoint(3, 5);
            WriteLine($"Fifth.x: {Fifth.X}, Fifth.y: {Fifth.Y}\n");

            WriteLine("\nEnums\n");
            EnumerationsClass.RunMethod();

            WriteLine("\nEnum Stuff\n");
            WriteLine("Total Allocated KBytes: {0:N2} KB", (GC.GetTotalAllocatedBytes() * 0.001));
            WriteLine("total commited Kbytes: {0:N2} KB", (GC.GetGCMemoryInfo().TotalCommittedBytes * 0.001));
            WriteLine("total Heap Kbytes: {0:N2} KB", (GC.GetGCMemoryInfo().HeapSizeBytes * 0.001));

            WriteLine("Total Memory {0:N2} KB", (GC.GetTotalMemory(true) * 0.001));
            
            WriteLine("\nBitFlagsExample\n");
            BitFlagsExample.RunIt();
        }
    }
}
