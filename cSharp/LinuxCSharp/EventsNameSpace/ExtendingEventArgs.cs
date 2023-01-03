using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtendingEventArgs
{
    public class IncrementerEventArgs: EventArgs //Custom class derived from EventArgs
    {
        public int IterationCount {get;set;}    // Stores an integer
    }

    class Incrementer {
        public event EventHandler<IncrementerEventArgs>? CountedADozen; // Generic delegate using custom class
        public void DoCount() {
            IncrementerEventArgs args = new IncrementerEventArgs(); // object of custom class
            for( int i=1; i < 100; i++) 
                if (i % 12 == 0 && CountedADozen != null)
                {
                    args.IterationCount = i;
                    CountedADozen(this, args);  // pass parameters when raising class
                }
        }
    }

    class Dozens{
        public int DozensCount {get; private set;}
        public Dozens(Incrementer incrementer) {
            DozensCount = 0;
            incrementer.CountedADozen += IncrementDozensCount;
        }

        void IncrementDozensCount( object? source, IncrementerEventArgs e) {
            if (source != null)
                Console.WriteLine($"Incremented at iteration: {e.IterationCount} in {source.ToString() }");
            DozensCount++;
        }
    }

    public class Program{
        public void Main() {
            Incrementer incrementer = new Incrementer();
            Dozens dozensCounter     = new Dozens( incrementer );

            incrementer.DoCount();
            Console.WriteLine($"Number of dozens = {dozensCounter.DozensCount}");
        }
    }
}