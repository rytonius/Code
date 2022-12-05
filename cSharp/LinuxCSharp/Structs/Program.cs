// What are structs? are programmer-defined data types, similar to classes.
// They have data members and fucntion members.  Although structs are similar to classes
// there are a number of important differnces.  The most important ones are the following:

// classes are reference types, and structs are value types
// structs are implicity sealed, which means they cannot be derived from


namespace Structs
{
    struct Point {
    public int X;
    public int Y;
    }

    class Nice {
        public int X;
    }

    class Program 
    {
        static void Main() {
            Point first, second, third;

            first.X = 10; first.Y = 10;
            second.X = 22; second.Y = 22;
            third.X = 39;    third.Y = 39;

           

            Console.WriteLine("\nfirst x: {0} - third y: {1}\n Checking memory usage with struct alone", first.X, third.Y);
            Console.WriteLine("Total Allocated Bytes: {0:N2} KB", (GC.GetTotalAllocatedBytes() * 0.001));
            Console.WriteLine("total commited bytes: {0}", GC.GetGCMemoryInfo().TotalCommittedBytes );
            Console.WriteLine("total Heap bytes: {0}", GC.GetGCMemoryInfo().HeapSizeBytes);

            Console.WriteLine("Total Memory {0}\n Allocating a Class now which will be in heap\n", GC.GetTotalMemory(true));

            Nice x = new Nice();
            int y = x.X;

            Console.WriteLine("Total Allocated KBytes: {0:N2} KB", (GC.GetTotalAllocatedBytes() * 0.001));
            Console.WriteLine("total commited Kbytes: {0:N2} KB", (GC.GetGCMemoryInfo().TotalCommittedBytes * 0.001));
            Console.WriteLine("total Heap Kbytes: {0:N2} KB", (GC.GetGCMemoryInfo().HeapSizeBytes * 0.001));

            Console.WriteLine("Total Memory {0:N2} KB", (GC.GetTotalMemory(true) * 0.001));

        }
    }
    
}
