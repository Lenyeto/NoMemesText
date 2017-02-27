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



    public class User
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

        //The current quest the user is on.
        public int quest;

        //The spots on the map that have been visited.
        public Coords[] visited;

        //Sets whether the player has a message or not.
        public void setHasMessage(bool b) { hasMessage = b; }

        //Whether or not the player was just created.
        public bool isNew;

        public User()
        {
            isNew = true;
        }
        
    }
}
