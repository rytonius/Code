using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Structs_Enums
{
    [Flags]
    enum CardDeckSettings : uint {
        SingleDeck      = 0x01,//0001
        LargePictures   = 0x02,//0010
        FancyNumbers    = 0x04,//0100
        Animation       = 0x08 //1000
    }
    class BitFlagClass {
        bool useSingleDeck      = false,
             useBigPics         = false,
             useFancyNumbers    = false,
             useAnimation       = false,
             useAnimationAndFancy  = false;

        internal void SetOptions( CardDeckSettings ops) {
            useSingleDeck       = ops.HasFlag( CardDeckSettings.SingleDeck);
            useBigPics          = ops.HasFlag( CardDeckSettings.LargePictures);
            useFancyNumbers     = ops.HasFlag( CardDeckSettings.FancyNumbers);
            useAnimation        = ops.HasFlag( CardDeckSettings.Animation);
            
            CardDeckSettings testFlags = CardDeckSettings.Animation | CardDeckSettings.FancyNumbers;
            useAnimationAndFancy = ops.HasFlag ( testFlags);
        }

        internal void PrintOptions() {
            Console.WriteLine( "Option settings:");
            Console.WriteLine($" Use Single Deck                 - { useSingleDeck}");
            Console.WriteLine($" Use Large Pictures              - { useBigPics}");
            Console.WriteLine($" Use Fancy Numbers               - { useFancyNumbers}");
            Console.WriteLine($" Show Animation                  - { useAnimation }");
            Console.WriteLine( " Show Animation and FancyNumbers - {0}", useAnimationAndFancy);

            Console.WriteLine("\nAll enum constants from CardDeckSettings:");
            foreach (var name in Enum.GetNames( typeof(CardDeckSettings)))
                Console.WriteLine($" {name}");

        }
    }

    public class BitFlagsExample
    {
        public static void RunIt() {
            BitFlagClass BFC = new BitFlagClass();
            CardDeckSettings ops =  CardDeckSettings.SingleDeck 
                                  | CardDeckSettings.FancyNumbers 
                                  | CardDeckSettings.Animation;
            BFC.SetOptions( ops );
            BFC.PrintOptions();
        }
    }
}