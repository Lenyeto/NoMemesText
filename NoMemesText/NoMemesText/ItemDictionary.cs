using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NoMemesText
{
    public class ItemDictionary
    {
         List<Item> mItemArray;

        public ItemDictionary()
        {
            mItemArray = new List<Item>();


        }


        public void addItem(Item item)
        {
            mItemArray.Add(item);
        }

        public Item getItemByName(string name)
        {
            foreach (Item i in mItemArray)
            {
                if (i.mName.ToLower().Equals(name.ToLower()))
                {
                    return i;
                }
            }
            return null;
        }

        public Item[] getItemsByType(ItemType it)
        {
            List<Item> tmpItems = new List<Item>();
            foreach (Item i in mItemArray)
            {
                if (i.mType == it)
                {
                    tmpItems.Add(i);
                }
            }

            return (Item[]) tmpItems.ToArray();
        }

        public Item getRandomItemByType(ItemType it, out int index)
        {
            Item[] itemPool = getItemsByType(it);

            int tmpLength = itemPool.Length;
            Random r = new Random();
            
            index = r.Next(tmpLength);

            return itemPool[index];
        }

        public void loadItemsFromFile(string fileName)
        {
            string[] textLines = File.ReadAllLines(fileName);

            Item tmp;
            foreach (string s in textLines)
            {
                string[] tmpS = s.Split(',');

                if (tmpS.Length < 7)
                {
                    continue;
                }

                ItemType tmpType;
                ItemSlot tmpSlot;
                int tmpDamage;
                int tmpArmor;
                int tmpValue;
                bool tmpQuest = false;
                
                tmpType = (ItemType) Enum.Parse(typeof(ItemType), tmpS[2]);
                tmpSlot = (ItemSlot) Enum.Parse(typeof(ItemSlot), tmpS[3]);
                tmpDamage = int.Parse(tmpS[4]);
                tmpArmor = int.Parse(tmpS[5]);
                tmpValue = int.Parse(tmpS[6]);
                tmpQuest = bool.Parse(tmpS[7]);

                tmp = new Item(tmpS[0], tmpS[1], tmpType, tmpSlot, tmpDamage, tmpArmor, tmpValue, tmpQuest);

                addItem(tmp);
            }
        }

        public string getInventory(List<int> i)
        {
            string tmp = "";

            foreach (int i2 in i)
            {
                tmp += mItemArray[i2].ToString();
                tmp += '\n';
            }

            return tmp;
        }

        public Item getItem(int i)
        {
            return mItemArray[i];
        }
    }
}
