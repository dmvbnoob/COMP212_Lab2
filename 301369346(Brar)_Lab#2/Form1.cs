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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnPublish.Enabled = false;
        }

        private ManageSub msDialog;
        private Publisher publisher = new Publisher();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            msDialog = new ManageSub();
            msDialog.FormClosed += ManageSub_FormClosed;
            msDialog.Show();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            if (msDialog != null && (msDialog.EmailSubscribers.Any() || msDialog.PhoneSubscribers.Any()))
            {
                PublishNotif pnDialog = new PublishNotif(publisher, msDialog.EmailSubscribers, msDialog.PhoneSubscribers);
                pnDialog.Show();
            }
        }
        private void ManageSub_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (msDialog.EmailSubscribers.Count > 0 || msDialog.PhoneSubscribers.Count > 0)
            {
                btnPublish.Enabled = true;
            }
            else
            {
                btnPublish.Enabled = false;
            }
        }
    }
}
