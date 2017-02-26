using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMemesText
{
    public enum ItemType { Weapon, Armor }
    public enum ItemSlot { Head, Torso, Legs, Feet, MainHand, OffHand }

    public class Item
    {
        public string mName;
        public string mDescription;
        public ItemType mType;
        public ItemSlot mSlot;

        public int mDMG;
        public int mArmor;
        public int mValue;

        public bool isQuestItem;

        public Item(string name, string description, ItemType type, ItemSlot slot, int damage, int armor, int value, bool quest)
        {
            mName = name;
            mDescription = description;
            mType = type;
            mSlot = slot;
            mDMG = damage;
            mValue = value;
            isQuestItem = quest;
        }
    }
}
