using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifClassLib
{
    public class Publisher
    {
        public delegate void PublishMessage(string message);

        public PublishMessage publishMsg = null;

        public void publishMessage(string message)
        {
            publishMsg.Invoke(message);
        }
    }
}
