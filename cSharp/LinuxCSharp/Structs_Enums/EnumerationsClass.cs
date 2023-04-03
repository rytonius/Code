using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace Structs_Enums
{
    // every enum has an underlying integer type, which by default is int.
    enum TrafficLights : int {
        Green = 0,
        Yellow = 10,
        Red = 11
        
    }

    enum BitFlags : uint {
        SingleDeck = 0x01, // Bit 0
        LargePictures = 0x02, // Bit 1
        FancyNumbers = 0x04, // Bit 2
        Animation = 0x08, // Bit 3
        funny = 0x042069 // Bit 270441
    }
    static public class EnumerationsClass
    {
        static public void RunMethod() {
            TrafficLights Light = TrafficLights.Green;

            if (Light == TrafficLights.Green) {
                WriteLine($"Light: {Light}\t{(int)Light}");

            }

            Light = TrafficLights.Red;

            BitFlags ops = BitFlags.SingleDeck | BitFlags.FancyNumbers
                            | BitFlags.LargePictures | BitFlags.Animation;

            bool useSingleDeck = ops.HasFlag(BitFlags.SingleDeck);
            
            if (Light == TrafficLights.Red) {
                WriteLine($"Light: {Light}\t\t{(int)Light}");
                WriteLine($"0x01 {(uint)BitFlags.SingleDeck}");
                WriteLine($"0x02 {(uint)BitFlags.FancyNumbers}");
                WriteLine($"0x04 {(uint)BitFlags.LargePictures}");
                WriteLine($"0x08 {(uint)BitFlags.Animation}");
                WriteLine($"combined enum ops {ops}");


                WriteLine($"0x042069 {(uint)BitFlags.funny}");
            }
        }
    }
}