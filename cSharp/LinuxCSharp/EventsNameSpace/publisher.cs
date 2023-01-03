using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public delegate void Handler();

namespace EventsNameSpace
{
    public class publisher
    {
        public event Handler? CountedADozen; // Create and publish an event.

        public void doCount(int count)
        {
            for (int i = 1; i < count; i++)
            {
                if ( i % 12 == 0 && CountedADozen != null) // Check the event to make sure it's not null
                {
                    Console.WriteLine("Counting from a Called Event");
                    CountedADozen();
                }
                    
            }
        }

    }
}