using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NotifClassLib
{
    public class SendViaPhone
    {
        public long Phone { get; set; }

        public SendViaPhone() { }

        public SendViaPhone(long phone)
        {
            Phone = phone;
        }

        public void sendText(string message)
        {
            Console.WriteLine($"Notification: '{message}' has been sent to {Phone}");
        }

        public void Sub(Publisher pub)
        {
            pub.publishMsg += sendText;
        }

        public void UnSub(Publisher pub)
        {
            pub.publishMsg -= sendText;
        }
    }
}
