using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

namespace EnumeratorsAndIterators
{
    class ColorEnumerator : IEnumerator
    {
        string[] Colors;
        int      Position = -1;
        public ColorEnumerator( string[] theColors) // Constructor
        {
            Colors = new string[theColors.Length];
            for ( int i = 0; i < theColors.Length; i++ )
                Colors[i] = theColors[i];
        }

        public object Current                           // Implement current.
        {
            get
            {
                if ( Position == -1 )
                    throw new InvalidOperationException();
                if ( Position >= Colors.Length )
                    throw new InvalidOperationException();
                return Colors[Position];
            }
        }

        public bool MoveNext()
        {
            if (Position < Colors.Length - 1)
            {
                Position++;
                return true;
            }
            else 
                return false;
        }

        public void Reset() => Position--;
        

    }

    class Spectrum : IEnumerable
    {
        string[] Colors = {"violet", "blue", "cyan", "green", "yellow", "red", "blue", "orange", "duck" };
        public IEnumerator GetEnumerator() => new ColorEnumerator( Colors );
    }

    public static class ExampleIEnumerableIenumerator
    {
        public static void RunIt()
        {
            Spectrum spectrum = new Spectrum();
            foreach (string color in spectrum )
                WriteLine(char.ToUpper(color[0]) + color.Substring(1));
        }
    }
}