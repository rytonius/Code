// See https://aka.ms/new-console-template for more information
using FightClub.Models;
using FightClub.Factory;
Console.WriteLine("Hello, World!");

Player ourPlayer = new Player(ID: 1, NAME: "Rygar");
ourPlayer.GetStats();

MonsterFactory MF = new MonsterFactory();


NPCEnemy Slime = MF.CreateNPC(1);

Slime.GetStats();