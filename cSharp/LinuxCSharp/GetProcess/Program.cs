using System;
using System.Diagnostics;

Console.WriteLine("Hello, World!");

Process[] Processes = Process.GetProcesses();

foreach (Process P in Processes) {
    Console.WriteLine($"{P}");
}

