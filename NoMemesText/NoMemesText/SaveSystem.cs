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

            FileStream fs = File.Create("../media/saves.sav");

            foreach (KeyValuePair<string, User> u in tmp)
            {
                //Console.WriteLine(u.Key);
                //Console.WriteLine(u.Value.pos.ToString());
                //Console.WriteLine(u.Value.level);
                Console.WriteLine(u.Key);
                Console.WriteLine(u.Value.ToString());

                string tmp2 = u.Key + '\t' + u.Value.ToString();

                byte[] tmpBytes = Encoding.Unicode.GetBytes(tmp2.ToCharArray());

                fs.Write(tmpBytes, 0, tmpBytes.Length);
                
            }

            fs.Close();
        }

        public static void loadPlayers()
        {
            string[] lines = File.ReadAllLines("../media/saves.sav");

            foreach (string s in lines)
            {
                string[] tmp = s.Split('\t');
                UserHandler.getInstance().addUser(tmp[0], new User(tmp.ToList().GetRange(1, tmp.Length)));
            }
        }
        
    }
}
