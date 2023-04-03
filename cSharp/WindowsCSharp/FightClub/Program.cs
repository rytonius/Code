// See https://aka.ms/new-console-template for more information
using FightClub.Models;

Console.WriteLine("Hello, World!");

Player ourPlayer = new Player(ID: 1, NAME: "Rygar");
ourPlayer.GetStats();
Console.ReadLine();