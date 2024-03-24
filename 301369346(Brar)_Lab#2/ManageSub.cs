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
using System.Net.Mail;

namespace _301369346_Brar__Lab_2
{
    public partial class ManageSub : Form
    {
        public ManageSub()
        {
            InitializeComponent();
        }

        private List<SendViaMail> emailSubscribers = new List<SendViaMail>();
        private List<SendViaPhone> phoneSubscribers = new List<SendViaPhone>();
        public List<SendViaMail> EmailSubscribers { get { return emailSubscribers; } }
        public List<SendViaPhone> PhoneSubscribers { get { return phoneSubscribers; } }

        private void lblEmailError_Click(object sender, EventArgs e)
        {

        }

        private void lblPhoneError_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkNotifEmail_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkNotifSMS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (chkNotifEmail.Checked && (txtEmail.Text != null ))
            {
                if (IsValidEmail(txtEmail.Text))
                {
                    emailSubscribers.Add(new SendViaMail(txtEmail.Text));
                    lblEmailError.Visible = false;
                    MessageBox.Show($"{txtEmail.Text} has been added as a new subscriber", "New Email Subscriber", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lblEmailError.Text = "Invalid email format.";
                    lblEmailError.Visible = true;
                }
            }

            if (chkNotifSMS.Checked && (txtPhone.Text != null))
            {
                if (IsValidPhone(txtPhone.Text))
                {
                    phoneSubscribers.Add(new SendViaPhone(long.Parse(txtPhone.Text)));
                    lblPhoneError.Visible = false;
                    MessageBox.Show($"{txtPhone.Text} has been added as a new subscriber", "New Phone Subscriber", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lblPhoneError.Text = "Invalid phone format.";
                    lblPhoneError.Visible = true;
                }
            }

        }

        private void btnUnsub_Click(object sender, EventArgs e)
        {
            SendViaMail subscriberToRemove = null;
            foreach (var subscriber in emailSubscribers)
            {
                if (subscriber.EmailAddress == txtEmail.Text)
                {
                    subscriberToRemove = subscriber;
                    break;
                }
            }

            if (subscriberToRemove != null)
            {
                emailSubscribers.Remove(subscriberToRemove);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhone(string phone)
        {
            try
            {
                long phoneNumber = long.Parse(phone);
                return phoneNumber > 0 && phone.Length == 10;
            }
            catch
            {
                return false;
            }
        }
    }
}
