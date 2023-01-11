using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfacesChapter
{
    interface IInfo {
        string GetName();
        string GetAge();
    }

    class CA : IInfo {
        public string Name;
        public int Age;
        public CA(string name, int age) {
            Name = name;
            Age = age;
        }
        public string GetName() {return Name;}
        public string GetAge() {return Age.ToString();}
    }

    class CB : IInfo {
        public string First = "First";
        public string Last = "Last";
        public int PersonsAge = 18;
        public string GetName() {return First + " " + Last;}
        public string GetAge() {return PersonsAge.ToString();}
    }
    public class WhatIsInterface
    {
        static void PrintInfo(IInfo item) {
            Console.WriteLine("Name: {0}, Age{1}", item.GetName(), item.GetAge());
        }

        public void RunIt() {
            CA a = new CA("Billy Greddy", 22); 
            CB b = new CB() {First = "Jane", Last = "Doe", PersonsAge = 33 };

            PrintInfo(a);
            PrintInfo(b);
        }
    }
}