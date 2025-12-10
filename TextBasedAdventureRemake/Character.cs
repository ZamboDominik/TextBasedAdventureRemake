using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureRemake
{
    public class Character
    {
        public string name { get; protected set; }
        public int hp { get; protected set; }

        public List<Item> inventory = new List<Item>();

        public Item[] items = new Item[3];//fegyver, páncél,gyűrű/buff

        public Character(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
        }

        public virtual void Attack(Character target, int damage = 10)
        {
            Console.WriteLine($"{name} támadja {target.name}!");
            target.TakeDamage(damage); // Alap sebzés

        }
        public virtual void TakeDamage(int damage)
        {
            hp -= damage;
            Console.WriteLine($"{name} kap {damage} sebzést! HP: {hp}");
        }

        public virtual void UseItem(Item item)
        {
            Console.WriteLine($"{name} uses {item.itemName}.");
            // További logika az item használatához(majd később)
        }

        public virtual void ChangeItem()
        {
            Console.WriteLine("Az Inventoryd");
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {inventory[i]}");
            }

            Console.WriteLine("Válaszd ki a cserélni kívánt tárgy számát:");
            int itemIndex = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Melyik tárgyat akarod ide rakni?");
            for (int i = 0; i < items.Length; i++)
            {
                string itemName = items[i] != null ? items[i].itemName : "Üres";
                Console.WriteLine($"{i + 1}. {itemName}");
            }
            int slotIndex = int.Parse(Console.ReadLine()) - 1;
            Item temp = items[slotIndex];
            items[slotIndex] = inventory[itemIndex];

        }
    }
}
