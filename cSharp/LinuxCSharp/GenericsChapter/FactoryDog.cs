using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Covariance and Contravariance

namespace GenericsChapter
{
    class Animal       { public int Legs = 4;} // Base Class
    class Dog : Animal { }

    delegate T FactoryOut<out T>( );   // delegate declaration must be out keyword, out is specifying convariance
    // Assignment compatibility doesn't apply because the two delegates are unrelated by inheritance
    delegate void Action1<in T>( T a );
                // in is keyword for contravariance
    
    public static class FactoryDog
    {
        static Dog MakeDog( )
        {
            return new Dog( );
        }

        static void ActOnAnimal( Animal a) {Console.WriteLine("Animal has: ", a.Legs , " legs.");}

        public static void Main( )
        {
            FactoryOut<Dog>    dogMaker       = MakeDog;
            FactoryOut<Animal> animalMaker    = dogMaker;

            Action1<Animal> act1 = ActOnAnimal;
            Action1<Dog>    dog1 = act1;

            Console.WriteLine("dog has: " + animalMaker().Legs.ToString() + " legs.");
            dog1( new Dog() );
        }
        
        
    }
}