using Limilabs.Client.POP3;
using Limilabs.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NoMemesText
{

    public class emailChecker
    {
        public bool shouldRun;
        string password;

        public emailChecker(string pass)
        {
            password = pass;
            shouldRun = true;
        }

        public void checkMailLoop()
        {
            while (shouldRun)
            {
                checkMail(password);
                Thread.Sleep(10);
            }
        }

        static void checkMail(string password)
        {
            using (Pop3 pop3 = new Pop3())
            {
                pop3.ConnectSSL("pop.gmail.com");
                pop3.Login("no.memes.text", password);

                MailBuilder builder = new MailBuilder();
                foreach (var uid in pop3.GetAll())
                {
                    IMail email = builder.CreateFromEml(pop3.GetMessageByUID(uid));
                    


                    User tmp = UserHandler.getInstance().getUser(email.Sender.Address);
                    //tmp.message = "test";

                    string command = email.GetBodyAsText().ToLower();
                    
                    if (tmp.isNew)
                    {
                        tmp.message = choiceProcessor.getWelcomMessage();
                        tmp.setHasMessage(true);
                        tmp.isNew = false;
                    }
                    else
                    {
                        if (command.ToLower().Contains("clear"))
                        {
                            tmp = new User();

                            tmp.setHasMessage(true);
                            //tmp.message = choiceProcessor.getText();
                            tmp.message = choiceProcessor.getWelcomMessage();

                        }
                        else if (command.ToLower().Contains("help"))
                        {
                            tmp.setHasMessage(true);

                            tmp.message = "map\nclear";
                        }
                        else if (command.ToLower().Contains("map"))
                        {
                        
                            Map.getInstance().createImage();
                            Program.sendMessageWithAttachment("", email.Sender.Address, "../media/tmpMap.png");
                            //Program.sendMessageWithAttachment("", email.Sender.Address, "../media/tmpMap.jpeg");
                            continue;
                        }
                        else if (command.ToLower().Contains("look"))
                        {
                            tmp.message = choiceProcessor.getTextLocation(tmp);
                        }
                        else
                        {
                            tmp.setHasMessage(true);

                            //tmp.message = choiceProcessor.getText();
                        }
                    }

                    UserHandler.getInstance().addUser(email.Sender.Address, tmp);

                    //sendMessage("Got your message!", email.Sender.Address);
                }

                pop3.Close();
            }

        }

        public static void sendMessage(string msg, string email, string password)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("nomemestext", password);

            mail.To.Add(email);

            mail.From = new MailAddress("NoMemesText@gmail.com");

            mail.Body = msg;

            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

            Console.WriteLine("Sent message to " + email);
        }
    }

}
