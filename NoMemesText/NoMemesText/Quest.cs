using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMemesText
{
    enum questCondition { Deliver, Kill, Gather, Goto };

    enum creatureType { Beast, Humanoid, Undead, Elemental };

    public class Quest
    {
        int prereqQuest;

        string mName;
        string mDescription;

        int mXPReward;
        int mGoldReward;

        int mItemIDReward;

        questCondition mCond;

        creatureType mCreatureToKill;

        int mAmountToKill;

        Coords placeToKill;

        public Quest(string name, string description, int XPReward = 0, int goldReward = 0, int itemIDReward = -1, int prereq = -1)
        {
            mName = name;
            mDescription = description;
            mXPReward = XPReward;
            mGoldReward = goldReward;
            mItemIDReward = itemIDReward;
            prereqQuest = prereq;
        }
    }
}
