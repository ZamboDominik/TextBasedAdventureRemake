using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureRemake
{
    public class Item
    {

        public string itemName { get; protected set; }
        public int itemValue { get; protected set; }

        public Item(string itemName, int itemValue)
        {
            this.itemName = itemName;
            this.itemValue = itemValue;
        }

        public override string ToString()
        {
            return $"{itemName} (Ertek: {itemValue})";
        }
    }
    }
