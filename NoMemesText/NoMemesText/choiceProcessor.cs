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

        public static choiceResult getInventory(User u)
        {
            choiceResult cr = new choiceResult();



            return cr;
        }

        public static string getWelcomMessage()
        {
            return "Welcome to NoMemesText, an experiemental text based adventure game. Please type 'help' in order to receive a list of commands you can use!";
        }
    }
}
