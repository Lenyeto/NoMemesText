﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMemesTextQuestCreator
{
    public enum questType { Deliver, Kill, Gather, Goto };

    public enum creatureType { Beast, Humanoid, Undead, Elemental };

    public class Quest
    {
        public string mName;
        public string mDescription;


        public int mXPReward;
        public int mGoldReward;

        public int mItemIDReward;
        public int mAmountToKill;
       

        public bool mHasReward;


        questType mQuestType;

        creatureType mCreatureToKill;

        

        

        //Coords placeToKill;

        public Quest(string name, string description, string questType, bool hasReward, int XPReward = 0, int goldReward = 0, int itemIDReward = 0 )
        {
            Enum.TryParse(questType, out mQuestType);


            mName = name;
            mDescription = description;
                
            mXPReward = XPReward;
            mGoldReward = goldReward;
            mItemIDReward = itemIDReward;

            mHasReward = hasReward;



        }
    }
}
