using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static List<GameItem> _standardGameItems;

        static ItemFactory()
        {
            _standardGameItems= new List<GameItem>();

            _standardGameItems.Add(new Weapon(itemTypeID: 1001, name: "Pointy Stick", 
                                              dice: 1, roll: 4, description: "are you happy to see me?", quality: 0, price: 2));
            _standardGameItems.Add(new Weapon(itemTypeID: 1002, name: "Rusty Sword",
                                              dice: 1, roll: 8, description: "Nothing a lil wd40 wouldn't fix", quality: 0, price: 8));
        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);
            if (standardItem != null)
            {
                return standardItem.CLone();
            }
            return null;
        }
    }
}
