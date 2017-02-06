using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Limilabs.Mail;
using Limilabs.Client.POP3;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing;



namespace NoMemesText
{
    class Program
    {
        
        
        

        static void Main(string[] args)
        {

            //List<string> s;

            
            //stuff();

            emailChecker ec = new emailChecker();
            Thread t = new Thread(new ThreadStart(ec.checkMailLoop));
            t.Start();

            Thread t2 = new Thread(new ThreadStart(UserHandler.getInstance().updateUsers));
            t2.Start();

            while (true)
            {
                

                string s = Console.In.ReadLine();

                Console.Out.WriteLine(s);



                try
                {
                    //sendMessage(s, "patg.lenyeto@gmail.com");
                    //Map.getInstance().createImage();
                    //sendMessageWithAttachment(s, "5137671027@mms.att.net", "tmpMap.png");
                }
                catch (Exception e)
                {
                    Console.Write(e);
                }

                //Console.Clear();
            }




        }

        static void sendMessage(string msg, string email)
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

        public static void sendMessageWithAttachment(string msg, string email, string attachmentFileName)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("nomemestext", "NoMemesPassword");

            mail.To.Add(email);

            mail.From = new MailAddress("NoMemesText@gmail.com");

            mail.Body = msg;
            


            SmtpServer.EnableSsl = true;


            Attachment attachment;
            attachment = new Attachment(attachmentFileName);
            attachment.TransferEncoding = System.Net.Mime.TransferEncoding.Base64;
            mail.Attachments.Add(attachment);

            //SmtpServer.DeliveryFormat = SmtpDeliveryFormat.SevenBit;



            SmtpServer.Send(mail);

            Console.WriteLine("Sent message to " + email);
        }

        static void initializeEmail()
        {
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("nomemestext", "NoMemesPassword");
        }
        
        
        static int checkMail()
        {
            using (Pop3 pop3 = new Pop3())
            {
                pop3.ConnectSSL("pop.gmail.com");
                pop3.Login("no.memes.text", "NoMemesPassword");

                MailBuilder builder = new MailBuilder();
                foreach (var uid in pop3.GetAll())
                {
                    Console.Write(uid);
                    IMail email = builder.CreateFromEml(pop3.GetMessageByUID(uid));

                    Console.WriteLine(email.Subject);
                    Console.WriteLine(email.Text);
                    Console.WriteLine(email.GetBodyAsText());
                }

                pop3.Close();
            }

            return 1;
        }
        
    }
}


