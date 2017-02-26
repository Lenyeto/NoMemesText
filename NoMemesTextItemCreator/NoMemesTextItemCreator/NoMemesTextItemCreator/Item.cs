using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMemesTextItemCreator
{
    public enum ItemType { Weapon, Armor, Consumable, Trinket }
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

        public Item()
        {

        }

        public Item(Item i)
        {
            mName = i.mName;
            mDescription = i.mDescription;
            mType = i.mType;
            mSlot = i.mSlot;
            mDMG = i.mDMG;
            mArmor = i.mArmor;
            mValue = i.mValue;
            isQuestItem = i.isQuestItem;
        }

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

        public override string ToString()
        {
            return mName;
        }

        public string getFullInfo()
        {
            return mName + '\n' + mDescription + '\n' + mType + '\n' + mSlot + '\n' + mDMG + '\n' + mArmor + '\n' + mValue + '\n' + isQuestItem;
        }
    }
}
