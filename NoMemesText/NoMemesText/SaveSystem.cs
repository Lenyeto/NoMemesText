using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMemesText
{
    static class SaveSystem
    {
        public static void saveData()
        {
            Dictionary<string, User> tmp = UserHandler.getInstance().getUsers();

            foreach (KeyValuePair<string, User> u in tmp)
            {
                //Console.WriteLine(u.Key);
                //Console.WriteLine(u.Value.pos.ToString());
                //Console.WriteLine(u.Value.level);
                Console.WriteLine(u.Key);
                Console.WriteLine(u.Value.ToString());
            }
        }

        
    }
}
