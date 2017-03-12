using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NoMemesText
{
    static class SaveSystem
    {
        public static void savePlayers()
        {
            Dictionary<string, User> tmp = UserHandler.getInstance().getUsers();

            //FileStream fs = File.Create("../media/saves.sav");

            string tmpStringToWrite = "";


            foreach (KeyValuePair<string, User> u in tmp)
            {
                tmpStringToWrite += u.Key + '\t' + u.Value.ToString();
                tmpStringToWrite += '\n';
            }

            System.IO.File.WriteAllText("../media/saves.sav", tmpStringToWrite);
            
        }

        public static void loadPlayers()
        {
            string[] lines = File.ReadAllLines("../media/saves.sav");

            Console.WriteLine(lines.Length);

            foreach (string s in lines)
            {
                string[] tmp = s.Split('\t');
                Console.WriteLine(tmp.Length);
                UserHandler.getInstance().addUser(tmp[0], new User(tmp.ToList().GetRange(1, tmp.Length-1)));
            }
        }
        
    }
}
