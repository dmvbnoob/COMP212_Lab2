namespace _301369346_Brar__Lab_2
{
    partial class PublishNotif
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnPublishMsg = new System.Windows.Forms.Button();
            this.btnExitPub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notification Content";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(179, 44);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(265, 20);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // btnPublishMsg
            // 
            this.btnPublishMsg.Location = new System.Drawing.Point(76, 104);
            this.btnPublishMsg.Name = "btnPublishMsg";
            this.btnPublishMsg.Size = new System.Drawing.Size(143, 33);
            this.btnPublishMsg.TabIndex = 2;
            this.btnPublishMsg.Text = "Publish";
            this.btnPublishMsg.UseVisualStyleBackColor = true;
            this.btnPublishMsg.Click += new System.EventHandler(this.btnPublishMsg_Click);
            // 
            // btnExitPub
            // 
            this.btnExitPub.Location = new System.Drawing.Point(262, 104);
            this.btnExitPub.Name = "btnExitPub";
            this.btnExitPub.Size = new System.Drawing.Size(143, 33);
            this.btnExitPub.TabIndex = 3;
            this.btnExitPub.Text = "Exit";
            this.btnExitPub.UseVisualStyleBackColor = true;
            this.btnExitPub.Click += new System.EventHandler(this.btnExitPub_Click);
            // 
            // PublishNotif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 180);
            this.Controls.Add(this.btnExitPub);
            this.Controls.Add(this.btnPublishMsg);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label1);
            this.Name = "PublishNotif";
            this.Text = "PublishNotif";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnPublishMsg;
        private System.Windows.Forms.Button btnExitPub;
    }
}