using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsNameSpace2
{
    public class EHPublisher
    {
        public event EventHandler? OnCountedADozen;

        public void DoCount(int HowManyLicksToTheCenterOfATootsiePop) {
            for (int i = 1; i < HowManyLicksToTheCenterOfATootsiePop; i++)
            {
                if(i % 12 == 0 && OnCountedADozen != null)
                    OnCountedADozen(this, null);  // Use EventHandler's parameters when raising the event
            }
        }
    }
}