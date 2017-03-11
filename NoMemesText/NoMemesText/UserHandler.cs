using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMemesText
{
    class UserHandler
    {
        static UserHandler m_instance;
        Dictionary<string, User> users;

        public bool shouldRun = true;

        public Dictionary<string, User> getUsers()
        {
            return users;
        }

        string password;

        private UserHandler()
        {
            users = new Dictionary<string, User>();
        }

        public void setPassword(string pass)
        {
            password = pass;
        }

        public static UserHandler getInstance()
        {
            if (m_instance == null)
            {
                m_instance = new UserHandler();
            }

            return m_instance;
        }

        public void updateUsers()
        {
            while (shouldRun)
            {

                List<KeyValuePair<string, User>> tmp = new List<KeyValuePair<string, User>>();
                tmp = users.ToList();
                foreach (KeyValuePair<string, User> u in tmp)
                {
                    if (u.Value.hasMessage)
                    {
                        emailChecker.sendMessage(u.Value.message, u.Key, password);
                        u.Value.setHasMessage(false);

                        //user newU = new user();
                        //newU.hasMessage = false;
                        User tm = u.Value;
                        tm.hasMessage = false;
                        users[u.Key] = tm;
                    }
                }
            }
        }

        public void addUser(string email, User u)
        {
            users[email] = u;
        }

        public User getUser(string email)
        {
            if (users.ContainsKey(email))
            {
                return users[email];
            }
            else
            {
                Console.WriteLine("Added user : " + email);
                users[email] = new User();
                return users[email];
            }
        }
    }
}
