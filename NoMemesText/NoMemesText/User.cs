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

        public static Coords Parse(string s)
        {
            string[] tmpS = s.Split(',');

            Coords tmpCoords = new Coords();

            tmpCoords.x = int.Parse(tmpS[0]);
            tmpCoords.y = int.Parse(tmpS[1]);

            return tmpCoords;
        }
    }

<<<<<<< HEAD

    public struct equipedItems
    {
        public int eHead;
        public int eTorso;
        public int eLegs;
        public int eFeet;
        public int eMainHand;
        public int eOffHand;

        public override string ToString()
        {
            return "{" + eHead + ',' + eTorso + ',' + eLegs + ',' + eFeet + ',' + eMainHand + ',' + eOffHand + "}";
        }
    }

=======
    public enum direction { North, East, West, South };
>>>>>>> Lenyeto

    public class User
    {
        //The items the player has equiped.
        public equipedItems equiped;

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

        //Quests that have been completed
        public List<int> questsCompleted;

        //Sets whether the player has a message or not.
        public void setHasMessage(bool b) { hasMessage = b; }

        //Whether or not the player was just created.
        public bool isNew;

        public User()
        {
            isNew = true;
            items = new List<int>();
            visited = new List<Coords>();
            questsCompleted = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                int tmpIndex;
                Program.mItemDictionary.getRandomItemByType(ItemType.Weapon, out tmpIndex);
                items.Add(tmpIndex);
            }

            visited.Add(pos);
        }

        public User(List<string> list)
        {
            hasMessage = bool.Parse(list[0]);
            message = list[1];
            //string[] tmpPos = list[2].Split(',');
            pos = Coords.Parse(list[2]);
            //pos.x = int.Parse(tmpPos[0]);
            //pos.y = int.Parse(tmpPos[1]);
            xp = int.Parse(list[3]);
            level = int.Parse(list[4]);
            string[] itemsList = (list[5].Remove(0, 1)).Remove(list[5].Length - 1).Split(',');

            foreach (string s in itemsList)
            {
                items.Add(int.Parse(s));
            }
            quest = int.Parse(list[6]);

            string[] coordsList = (list[7].Remove(0, 1)).Remove(list[7].Length - 1).Split('.');
            foreach (string s in coordsList)
            {
                visited.Add(Coords.Parse(s));
            }
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
            tmp += '\t';
            tmp += "{";
            foreach (int i in questsCompleted)
            {
                tmp += i.ToString();
                tmp += ",";
            }
            tmp += "}";

            tmp += '\t';
            tmp += equiped.ToString();

            return tmp;
        }


        public bool move(direction d, uint distance)
        {
            switch (d)
            {
                case direction.North:
                    if (pos.y - (int) distance > 0)
                    {
                        pos.y = pos.y - (int) distance;
                        visited.Add(pos);
                        return true;
                    }
                    break;
                case direction.East:
                    if (pos.x + (int) distance < Map.getInstance().getMapWidth())
                    {
                        pos.x = pos.x + (int) distance;
                        visited.Add(pos);
                        return true;
                    }
                    break;
                case direction.West:
                    if (pos.x - (int)distance > 0)
                    {
                        pos.x = pos.x - (int)distance;
                        visited.Add(pos);
                        return true;
                    }
                    break;
                case direction.South:
                    if (pos.y + (int)distance < Map.getInstance().getMapHeight())
                    {
                        pos.y = pos.y + (int)distance;
                        visited.Add(pos);
                        return true;
                    }
                    break;
            }

            return false;
        }
    }

}
