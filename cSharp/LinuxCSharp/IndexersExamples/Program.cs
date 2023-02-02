using System;
using System.Collections;

class SampleCollection<T> 
{
   // Declare an array to store the data elements.
   private T[] arr = new T[100];
   int nextIndex = 0;

   // Define the indexer to allow client code to use [] notation.
   public T this[int i] => arr[i];

   public void Add(T value)
   {
      if (nextIndex >= arr.Length)
         throw new IndexOutOfRangeException($"The collection can hold only {arr.Length} elements.");
      arr[nextIndex++] = value;
   }

    public IEnumerator<T> GetEnumerator()
    {
        return arrty(); 
    }

    public IEnumerator<T> arrty() 
    {
        T[] a = arr;

        for (int x = 0; x < a.Length; x++ ) {
            if (a[x] is not null)
                yield return a[x];
        }
            
    }
}

class Program
{
   static void Main()
   {
      var stringCollection = new SampleCollection<string>();
      stringCollection.Add("Hello, World");
      stringCollection.Add("Bye, World");
      System.Console.WriteLine(stringCollection[0]);
      System.Console.WriteLine(stringCollection[1]);

      foreach (string s in stringCollection) 
        Console.WriteLine(s);
   }
}
