using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMemesText
{
    public struct choiceResult
    {
        public string text;
        public int xp;
        public int item;
    }
    
    public class choiceProcessor
    {
        

        public static string getText(params bool[] arguments)
        {
            Console.WriteLine(arguments.Length);

            if (arguments.Length == 0)
            {
                return "Choices will be in text as (X), where you reply with your choice as that character. | You find yourself in a forest. You can travel North (A) or South (B).";
            }
            else if (arguments.Length == 1)
            {
                if (!arguments[0])
                {
                    return "You find a small pond. You can fish (A) or forage from plants (B).";
                }
                else if (arguments[0])
                {
                    return "You find a cave. You can search it (A) or gather wood (B)";
                }
            }
            else if (arguments.Length == 2)
            {
                if (!arguments[0] && !arguments[1])
                {
                    return "END1 | Reply Clear to clear your progress.";
                }
                else if (!arguments[0] && arguments[1])
                {
                    return "END2 | Reply Clear to clear your progress.";
                }
                else if (arguments[0] && !arguments[1])
                {
                    return "END3 | Reply Clear to clear your progress.";
                }
                else if (arguments[0] && arguments[1])
                {
                    return "END4 | Reply Clear to clear your progress.";
                }
            }






            return "";
        }

        public static string getTextLocation(User u)
        {
            if (Map.getInstance().getCell(u.pos.x, u.pos.y).m_type == Cell.Type.Blank)
            {
                return "You are in a field.";
            } else if (Map.getInstance().getCell(u.pos.x, u.pos.y).m_type == Cell.Type.Road)
            {
                return "You are on a road.";
            } else if (Map.getInstance().getCell(u.pos.x, u.pos.y).m_type == Cell.Type.Trees)
            {
                return "You are in a forest.";
            }

            return "";
        }



        public static choiceResult tryHunt(User u)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            choiceResult cr = new choiceResult();

            if (Map.getInstance().getCell(u.pos.x, u.pos.y).m_type == Cell.Type.Blank)
            {

                cr.text = "You try and hunt boar.\n";

                if (r.Next(100) > 50)
                {
                    cr.text += "You successfully kill a boar!";
                    cr.xp = 5;
                } else
                {
                    cr.text += "The boar escapes!";
                    cr.xp = 0;
                }
            }
            else if (Map.getInstance().getCell(u.pos.x, u.pos.y).m_type == Cell.Type.Road)
            {
                cr.text = "You are on a road.";
            }
            else if (Map.getInstance().getCell(u.pos.x, u.pos.y).m_type == Cell.Type.Trees)
            {
                cr.text = "You are in a forest.";
            }

            return cr;
        }

        public static string checkQuest(User u)
        {
            return "";
        }

        public static choiceResult finishQuest(User u)
        {
            choiceResult cr = new choiceResult();

            cr.text = "Could not finish quest.";

            return cr;
        }
    }
}
