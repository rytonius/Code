using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsNameSpace
{
    public class Suscriber
    {
        public int DozensCount {get;private set;}

        public Suscriber(publisher incrementer) 
        {
            DozensCount = 0;
            incrementer.CountedADozen += IncrementDozensCount; // suscribe to the event
        }

        void IncrementDozensCount() {
            DozensCount++;  // Declare the event handler
        }
    }
}