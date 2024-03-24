using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifClassLib
{
    public class SendViaMail
    {
        public string EmailAddress { get; set; }

        public SendViaMail() { }

        public SendViaMail(string emailAddress)
        {
            EmailAddress = emailAddress;
        }

        public void sendMail(string message)
        {
            Console.WriteLine($"Notification: '{message}' has been sent to {EmailAddress}");
        }

        public void Sub(Publisher pub)
        {
            pub.publishMsg += sendMail;
        }

        public void UnSub(Publisher pub)
        {
            pub.publishMsg -= sendMail;
        }
    }
}
