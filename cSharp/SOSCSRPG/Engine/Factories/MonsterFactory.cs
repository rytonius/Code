﻿using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster rat = new Monster(name: "this isn't a rat", imageName: "Enemy1.jpg", maxHitPoints: 5, rewardExperiencePoints: 4, rewardGold: 1);
                    AddLootItem(rat, 9001, 75);
                    AddLootItem(rat, 9002, 25);
                    return rat;
                case 2:
                    Monster snake = new Monster(name: "Solid Snake", imageName: "Snake.jpg", maxHitPoints: 8, rewardExperiencePoints: 8, rewardGold: 2);
                    AddLootItem(snake, 9003, 75);
                    AddLootItem(snake, 9004, 25);
                    return snake;
                case 3:
                    Monster CultistLeader = new Monster(name: "Cultist Leader", imageName: "Cultist_leader.png", maxHitPoints: 16, rewardExperiencePoints: 14, rewardGold: 5);
                    AddLootItem(CultistLeader, 9005, 75);
                    AddLootItem(CultistLeader, 9006, 25);
                    return CultistLeader;
                case 4:
                    Monster CultistAbomination = new Monster(name: "Cultist Abomination", imageName: "Cult_Abomination1.png", maxHitPoints: 30, rewardExperiencePoints: 30, rewardGold: 15);
                    AddLootItem(CultistAbomination, 9005, 90);
                    AddLootItem(CultistAbomination, 9006, 50);
                    return CultistAbomination;

                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }

            return null;
        }

        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGen.NumberBetween(1, 100) <= percentage)
            {
                Console.WriteLine("percentage: " + percentage);
                monster.Inventory.Add(new ItemQuantity(itemID, 1));
            }
        }
    }
}
