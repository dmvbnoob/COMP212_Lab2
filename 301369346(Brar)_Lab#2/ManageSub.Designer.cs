namespace _301369346_Brar__Lab_2
{
    partial class ManageSub
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkNotifEmail = new System.Windows.Forms.CheckBox();
            this.chkNotifSMS = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSub = new System.Windows.Forms.Button();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblPhoneError = new System.Windows.Forms.Label();
            this.btnUnsub = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkNotifEmail
            // 
            this.chkNotifEmail.AutoSize = true;
            this.chkNotifEmail.Location = new System.Drawing.Point(33, 49);
            this.chkNotifEmail.Name = "chkNotifEmail";
            this.chkNotifEmail.Size = new System.Drawing.Size(146, 17);
            this.chkNotifEmail.TabIndex = 0;
            this.chkNotifEmail.Text = "Notification Sent by Email";
            this.chkNotifEmail.UseVisualStyleBackColor = true;
            this.chkNotifEmail.CheckedChanged += new System.EventHandler(this.chkNotifEmail_CheckedChanged);
            // 
            // chkNotifSMS
            // 
            this.chkNotifSMS.AutoSize = true;
            this.chkNotifSMS.Location = new System.Drawing.Point(33, 117);
            this.chkNotifSMS.Name = "chkNotifSMS";
            this.chkNotifSMS.Size = new System.Drawing.Size(144, 17);
            this.chkNotifSMS.TabIndex = 1;
            this.chkNotifSMS.Text = "Notification Sent by SMS";
            this.chkNotifSMS.UseVisualStyleBackColor = true;
            this.chkNotifSMS.CheckedChanged += new System.EventHandler(this.chkNotifSMS_CheckedChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(219, 46);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 20);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(219, 114);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(237, 20);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(33, 183);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(137, 33);
            this.btnSub.TabIndex = 4;
            this.btnSub.Text = "Subscribe";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.ForeColor = System.Drawing.Color.Red;
            this.lblEmailError.Location = new System.Drawing.Point(224, 69);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(0, 13);
            this.lblEmailError.TabIndex = 5;
            this.lblEmailError.Click += new System.EventHandler(this.lblEmailError_Click);
            // 
            // lblPhoneError
            // 
            this.lblPhoneError.AutoSize = true;
            this.lblPhoneError.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneError.Location = new System.Drawing.Point(224, 137);
            this.lblPhoneError.Name = "lblPhoneError";
            this.lblPhoneError.Size = new System.Drawing.Size(0, 13);
            this.lblPhoneError.TabIndex = 6;
            this.lblPhoneError.Click += new System.EventHandler(this.lblPhoneError_Click);
            // 
            // btnUnsub
            // 
            this.btnUnsub.Location = new System.Drawing.Point(176, 183);
            this.btnUnsub.Name = "btnUnsub";
            this.btnUnsub.Size = new System.Drawing.Size(137, 33);
            this.btnUnsub.TabIndex = 7;
            this.btnUnsub.Text = "Unsubscribe";
            this.btnUnsub.UseVisualStyleBackColor = true;
            this.btnUnsub.Click += new System.EventHandler(this.btnUnsub_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(319, 183);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 33);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ManageSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 260);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUnsub);
            this.Controls.Add(this.lblPhoneError);
            this.Controls.Add(this.lblEmailError);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.chkNotifSMS);
            this.Controls.Add(this.chkNotifEmail);
            this.Name = "ManageSub";
            this.Text = "Manage Subscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkNotifEmail;
        private System.Windows.Forms.CheckBox chkNotifSMS;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblPhoneError;
        private System.Windows.Forms.Button btnUnsub;
        private System.Windows.Forms.Button btnCancel;
    }
}