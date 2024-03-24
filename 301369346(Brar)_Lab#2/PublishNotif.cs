using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotifClassLib;

namespace _301369346_Brar__Lab_2
{
    public partial class PublishNotif : Form
    {
        public PublishNotif(Publisher pub, List<SendViaMail> emailSubs, List<SendViaPhone> phoneSubs)
        {
            InitializeComponent();
            publisher = pub;
            emailSubscribers = emailSubs;
            phoneSubscribers = phoneSubs;

            SubscribeAll();
        }

        private Publisher publisher;
        private List<SendViaMail> emailSubscribers;
        private List<SendViaPhone> phoneSubscribers;

        private void btnExitPub_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPublishMsg_Click(object sender, EventArgs e) 
        {
            if (txtMessage.Text != null)
            {
                publisher.publishMessage(txtMessage.Text);
                MessageBox.Show("Notifications have been sent.","Success!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a message.","No Message Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void SubscribeAll()
        {
            emailSubscribers.ForEach(subscriber => subscriber.Sub(publisher));
            phoneSubscribers.ForEach(subscriber => subscriber.Sub(publisher));
        }
    }
}
