using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMemesTextQuestCreator
{
    enum questCondition { Deliver, Kill, Gather, Goto };

    enum creatureType { Beast, Humanoid, Undead, Elemental };

    public class Quest
    {
        public string mName;
        public string mDescription;

        public int mXPReward;
        public int mGoldReward;

        public int mItemIDReward;

        public int mAmountToKill;



        questCondition mCond;

        creatureType mCreatureToKill;

        

        //Coords placeToKill;

        public Quest(string name, string description, int XPReward = 0, int goldReward = 0, int itemIDReward = 0)
        {
            mName = name;
            mDescription = description;
            mXPReward = XPReward;
            mGoldReward = goldReward;
            mItemIDReward = itemIDReward;
        }
    }
}
