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
        // A lock for changing and sending the map image.
        public static Mutex mapLock;

        // A lock for changing when the mail should be changed.
        public static Mutex mailLock;

        // Whether or not the program should continue to run.
        public static bool isRunning = true;

        // The password (passed through by arguments when launching the program) for the email.
        static string loginPassword;

        // A list of all the items in the game.
        public static ItemDictionary mItemDictionary;

        static void Main(string[] args)
        {
            mapLock = new Mutex();
            mailLock = new Mutex();

            mItemDictionary = new ItemDictionary();
            mItemDictionary.loadItemsFromFile("../media/items.csv");

            if (args.Length == 0)
            {
                Console.WriteLine("First argument needs to be a password for the email");
                return;
            }
            loginPassword = args[0];

            UserHandler.getInstance().setPassword(loginPassword);

            emailChecker ec = new emailChecker(loginPassword);
            Thread t = new Thread(new ThreadStart(ec.checkMailLoop));
            t.Start();

            Thread t2 = new Thread(new ThreadStart(UserHandler.getInstance().updateUsers));
            t2.Start();
            
            

            while (isRunning)
            {
                

                string s = Console.In.ReadLine();

                if (s.Equals("exit") || s.Equals("quit"))
                {
                    // Tells this loop that it will end at the end of the loop.
                    isRunning = false;

                    

                }

                if (s.Equals("save"))
                {
                    SaveSystem.saveData();
                }
                
                    
            }

            // Sets the email checker to stop looping.
            ec.shouldRun = false;

            // Sets the user updater to stop looping.
            UserHandler.getInstance().shouldRun = false;

            // Sets the email checking thread to join this thread.
            t.Join();

            // Sets the user checking thread to join this thread.
            t2.Join();



        }

        static void sendMessage(string msg, string email)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("nomemestext", loginPassword);

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
            SmtpServer.Credentials = new System.Net.NetworkCredential("nomemestext", loginPassword);

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
            SmtpServer.Credentials = new System.Net.NetworkCredential("nomemestext", loginPassword);
        }
        
        
        static int checkMail()
        {
            using (Pop3 pop3 = new Pop3())
            {
                pop3.ConnectSSL("pop.gmail.com");
                pop3.Login("no.memes.text", loginPassword);

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


