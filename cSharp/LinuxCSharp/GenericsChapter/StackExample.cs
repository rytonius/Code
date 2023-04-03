using System.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace GenericsChapter
{
    class MyStack<T>
    {
        T[] StackArray;
        int StackPointer = 0;
        const int MaxStack = 10;
        bool IsStackFull { get => StackPointer >= MaxStack; }
        bool IsStackEmpty { get => StackPointer <= 0; }

        public void Push(T x)
        {
            if (!IsStackFull)
                StackArray[StackPointer++] = x;
        }

        public T Pop()
        {
            return (!IsStackEmpty)
                ? StackArray[--StackPointer]
                : StackArray[0];
        }

        public MyStack()
        {
            StackArray = new T[MaxStack];
        }
        public void Print()
        {
            for (int i = StackPointer - 1; i >= 0; i--)
                WriteLine($"    Value: {StackArray[i]}");
        }
    }
    public static class StackExample
    {
        public static void Main()
        {
            MyStack<int> StackInt = new MyStack<int>();
            MyStack<string> StackString = new MyStack<string>();

            StackInt.Push(3);
            StackInt.Push(5);
            StackInt.Push(7);
            StackInt.Push(9);
            StackInt.Push(11);
            StackInt.Print();
            Console.WriteLine("\nPopping a value from StackInt\n");
            StackInt.Pop();
            StackInt.Print();

            StackString.Push("This is fun");
            StackString.Push("Hi There! ");
            StackString.Print();
        }
    }

}

