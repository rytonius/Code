using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsNameSpace2
{
    public class EHSuscriber
    {
        public int DozensCount { get; set;}

        public EHSuscriber(EHPublisher incrementer) {
            DozensCount = 0;
            incrementer.OnCountedADozen += (source, e) => {DozensCount++;};
        }

    }
}