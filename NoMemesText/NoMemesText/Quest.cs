using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMemesText
{
    public class Quest
    {
        string mName;
        string mDescription;

        int mXPReward;
        int mGoldReward;

        int mItemIDReward;

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
