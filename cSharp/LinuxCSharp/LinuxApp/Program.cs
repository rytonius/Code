﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


void metoo() {
    Console.WriteLine("What is your name?");
    var name = Console.ReadLine();
    
    var currentDate = DateTime.Now;
    Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
    Console.Write($"{Environment.NewLine}Press any key to exit...");
    test.happy.test2();
}

metoo();

namespace test {
    public class happy {
        public static void test2(){
            Console.WriteLine("happy");
        }
    }
}


