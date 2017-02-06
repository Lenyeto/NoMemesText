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

        public emailChecker()
        {
            shouldRun = true;
        }

        public void checkMailLoop()
        {
            while (shouldRun)
            {
                checkMail();
                Thread.Sleep(10);
            }
        }

        static void checkMail()
        {
            using (Pop3 pop3 = new Pop3())
            {
                pop3.ConnectSSL("pop.gmail.com");
                pop3.Login("no.memes.text", "NoMemesPassword");

                MailBuilder builder = new MailBuilder();
                foreach (var uid in pop3.GetAll())
                {
                    //Console.Write(uid);
                    IMail email = builder.CreateFromEml(pop3.GetMessageByUID(uid));

                    //Console.WriteLine(email.Subject);
                    //Console.WriteLine(email.Text);
                    //Console.Write(email.Sender.Address);
                    ///Console.Write(" : ");
                    ///Console.WriteLine(email.GetBodyAsText());


                    User tmp = UserHandler.getInstance().getUser(email.Sender.Address);
                    //tmp.message = "test";

                    string command = email.GetBodyAsText().ToLower();
                    
                    

                    if (command.Contains("clear"))
                    {
                        tmp = new User();

                        tmp.setHasMessage(true);
                        //tmp.message = choiceProcessor.getText(tmp.choices.ToArray());
                        tmp.message = choiceProcessor.getText();

                    }
                    else if (command.Contains("help"))
                    {
                        tmp.setHasMessage(true);

                        tmp.message = "map\nclear";
                    }
                    else if (command.Contains("map"))
                    {
                        Map.getInstance().createImage();
                        Program.sendMessageWithAttachment("", email.Sender.Address, "tmpMap.png");
                        Program.sendMessageWithAttachment("", email.Sender.Address, "tmpMap.jpeg");
                        continue;
                    }
                    else if (command.Contains("a"))
                    {

                        tmp.setHasMessage(true);
                        tmp.makeChoice(false);

                        tmp.message = choiceProcessor.getText(tmp.choices.ToArray());
                    }
                    else if (command.Contains("b"))
                    {
                        tmp.setHasMessage(true);
                        tmp.makeChoice(true);

                        tmp.message = choiceProcessor.getText(tmp.choices.ToArray());

                    }
                    else
                    {
                        tmp.setHasMessage(true);

                        tmp.message = choiceProcessor.getText();
                    }

                    if (tmp.choices != null)
                    {
                        foreach (bool b in tmp.choices.ToArray())
                        {
                            Console.WriteLine(b);
                        }
                    }

                    UserHandler.getInstance().addUser(email.Sender.Address, tmp);

                    //sendMessage("Got your message!", email.Sender.Address);
                }

                pop3.Close();
            }

        }

        public static void sendMessage(string msg, string email)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("nomemestext", "NoMemesPassword");

            mail.To.Add(email);

            mail.From = new MailAddress("NoMemesText@gmail.com");

            mail.Body = msg;

            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

            Console.WriteLine("Sent message to " + email);
        }
    }

}
