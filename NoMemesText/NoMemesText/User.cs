using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMemesText
{
    public struct Coords
    {
        public int x;
        public int y;
    }



    public struct User
    {
        //Whether or not the player has a pending message.
        public bool hasMessage;

        //The next message that will be sent to the user.
        public string message;

        //The current position of the player.
        public Coords pos;

        //The XP the user currently has.
        public int xp;

        //The level of the user.
        public int level;

        //The items the user is currently holding.
        public int[] items;

        //The spots on the map that have been visited.
        public Coords[] visited;

        //Going to be deprecated, was just used for a choose your own adventure type of structure.
        public bool[] choices;

        //Sets whether the player has a message or not.
        public void setHasMessage(bool b) { hasMessage = b; }

        //Going to be deprecated, was just used for a choose your own adventure type of structure.
        public void makeChoice(bool b)
        {
            if (choices == null)
            {
                choices = new bool[1];
                choices[0] = b;
            }
            else
            {
                bool[] tmp = new bool[choices.Length];
                choices.CopyTo(tmp, 0);
                choices = new bool[tmp.Length + 1];
                tmp.CopyTo(choices, 0);
                choices[choices.Length - 1] = b;
            }
        }
    }
}
