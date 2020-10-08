using System;

namespace DemoApp.Concepts.Delegates
{
    //Subscribers
    public class SendViaMobile
    {
        public void sendMessage(string msg)
        {
            Console.WriteLine("Send to Mobile" + msg);
        }
    }
    public class SendViaEmail
    {
        public void sendEmail(string msg)
        {
            Console.WriteLine("Send to EMail" + msg);
        }
    }

    //Publisher
    public class Publisher
    {
        //Declare Delegate
        public delegate void PublishMessageDel(string msg);

        //Define Delegate
        public PublishMessageDel publishmsg = null;

        //Method used to Invoke Delegate
        public void PublishMessage(string message)
        {

            //Invoke Delegate
            publishmsg.Invoke(message);
        }
    }
}
