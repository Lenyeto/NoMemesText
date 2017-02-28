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

        public override string ToString()
        {
            return x.ToString() + "," + y.ToString();
        }
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
        public List<int> items;

        //The current quest the user is on.
        public int quest;

        //The spots on the map that have been visited.
        public List<Coords> visited;

        //Sets whether the player has a message or not.
        public void setHasMessage(bool b) { hasMessage = b; }

        //Whether or not the player was just created.
        public bool isNew;

        public User()
        {
            isNew = true;
            items = new List<int>();
            visited = new List<Coords>();
        }

        public override string ToString()
        {
            string tmp;

            tmp = hasMessage.ToString();
            tmp += '\t';
            tmp += message;
            tmp += '\t';
            tmp += pos.ToString();
            tmp += '\t';
            tmp += xp.ToString();
            tmp += '\t';
            tmp += level.ToString();
            tmp += '\t';
            tmp += "{";
            foreach (int i in items)
            {
                tmp += i.ToString();
                tmp += ",";
            }
            tmp += "}";
            tmp += '\t';
            tmp += quest.ToString();
            tmp += '\t';
            tmp += "{";
            foreach (Coords c in visited)
            {
                tmp += c.ToString();
                tmp += ".";
            }
            tmp += "}";


            return tmp;
        }

    }
}
