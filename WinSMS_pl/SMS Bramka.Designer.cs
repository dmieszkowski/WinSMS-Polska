using sms;

namespace Com
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_signature = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_captcha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_content = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_send = new sms.SMSButton();
            this.comboBox_sender = new sms.SMSComboBox();
            this.smsButton_delSender = new sms.SMSButton();
            this.smsButton_addSender = new sms.SMSButton();
            this.smsButton_delRecipiennt = new sms.SMSButton();
            this.button_addRecipient = new sms.SMSButton();
            this.comboBox_recipient = new sms.SMSComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odbiorca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(30, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nadawca";
            // 
            // textBox_signature
            // 
            this.textBox_signature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_signature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_signature.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_signature.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_signature.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_signature.Location = new System.Drawing.Point(110, 56);
            this.textBox_signature.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_signature.Name = "textBox_signature";
            this.textBox_signature.Size = new System.Drawing.Size(229, 26);
            this.textBox_signature.TabIndex = 3;
            this.textBox_signature.TextChanged += new System.EventHandler(this.textBox_signature_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(45, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Podpis";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 14);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(30, 31);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(708, 785);
            this.webBrowser1.TabIndex = 40;
            this.webBrowser1.TabStop = false;
            this.webBrowser1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(4, 331);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Przepisz kod";
            // 
            // textBox_captcha
            // 
            this.textBox_captcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_captcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_captcha.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_captcha.Location = new System.Drawing.Point(110, 329);
            this.textBox_captcha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_captcha.Name = "textBox_captcha";
            this.textBox_captcha.Size = new System.Drawing.Size(229, 26);
            this.textBox_captcha.TabIndex = 5;
            this.textBox_captcha.TextChanged += new System.EventHandler(this.textBox_captcha_onChange);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(54, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Treść";
            // 
            // textBox_content
            // 
            this.textBox_content.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBox_content.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_content.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_content.Location = new System.Drawing.Point(110, 92);
            this.textBox_content.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_content.Multiline = true;
            this.textBox_content.Name = "textBox_content";
            this.textBox_content.Size = new System.Drawing.Size(229, 187);
            this.textBox_content.TabIndex = 4;
            this.textBox_content.TextChanged += new System.EventHandler(this.textBox_content_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(61, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Na ten numer trafi odpowiedź na tego smsa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(109, 289);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 30);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox_sender);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.smsButton_delSender);
            this.panel1.Controls.Add(this.smsButton_addSender);
            this.panel1.Location = new System.Drawing.Point(-4, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5007, 90);
            this.panel1.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(13, 362);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Opcjonalne";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.textBox_captcha);
            this.panel2.Controls.Add(this.textBox_signature);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox_content);
            this.panel2.Controls.Add(this.label4);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 566);
            this.panel2.TabIndex = 10;
            // 
            // button_send
            // 
            this.button_send.BackColor = System.Drawing.Color.Silver;
            this.button_send.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_send.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_send.Image = global::sms.Properties.Resources.send50x50;
            this.button_send.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_send.Location = new System.Drawing.Point(0, 457);
            this.button_send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(434, 67);
            this.button_send.TabIndex = 30;
            this.button_send.Text = "Wyślij";
            this.button_send.UseVisualStyleBackColor = false;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // comboBox_sender
            // 
            this.comboBox_sender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox_sender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_sender.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox_sender.FormattingEnabled = true;
            this.comboBox_sender.Location = new System.Drawing.Point(112, 17);
            this.comboBox_sender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_sender.Name = "comboBox_sender";
            this.comboBox_sender.Size = new System.Drawing.Size(229, 28);
            this.comboBox_sender.TabIndex = 10;
            this.comboBox_sender.SelectedIndexChanged += new System.EventHandler(this.comboBox_sender_SelectedIndexChanged);
            // 
            // smsButton_delSender
            // 
            this.smsButton_delSender.BackColor = System.Drawing.Color.Silver;
            this.smsButton_delSender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smsButton_delSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.smsButton_delSender.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.smsButton_delSender.Location = new System.Drawing.Point(383, 17);
            this.smsButton_delSender.Name = "smsButton_delSender";
            this.smsButton_delSender.Size = new System.Drawing.Size(32, 32);
            this.smsButton_delSender.TabIndex = 12;
            this.smsButton_delSender.Text = "-";
            this.smsButton_delSender.UseVisualStyleBackColor = false;
            this.smsButton_delSender.Click += new System.EventHandler(this.smsButton_delSender_Click);
            // 
            // smsButton_addSender
            // 
            this.smsButton_addSender.BackColor = System.Drawing.Color.Silver;
            this.smsButton_addSender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smsButton_addSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.smsButton_addSender.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.smsButton_addSender.Location = new System.Drawing.Point(345, 17);
            this.smsButton_addSender.Name = "smsButton_addSender";
            this.smsButton_addSender.Size = new System.Drawing.Size(32, 32);
            this.smsButton_addSender.TabIndex = 11;
            this.smsButton_addSender.Text = "+";
            this.smsButton_addSender.UseVisualStyleBackColor = false;
            this.smsButton_addSender.Click += new System.EventHandler(this.smsButton_addSender_Click);
            // 
            // smsButton_delRecipiennt
            // 
            this.smsButton_delRecipiennt.BackColor = System.Drawing.Color.Silver;
            this.smsButton_delRecipiennt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smsButton_delRecipiennt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.smsButton_delRecipiennt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.smsButton_delRecipiennt.Location = new System.Drawing.Point(384, 15);
            this.smsButton_delRecipiennt.Name = "smsButton_delRecipiennt";
            this.smsButton_delRecipiennt.Size = new System.Drawing.Size(32, 32);
            this.smsButton_delRecipiennt.TabIndex = 2;
            this.smsButton_delRecipiennt.Text = "-";
            this.smsButton_delRecipiennt.UseVisualStyleBackColor = false;
            this.smsButton_delRecipiennt.Click += new System.EventHandler(this.smsButton_delRecipiennt_Click);
            // 
            // button_addRecipient
            // 
            this.button_addRecipient.BackColor = System.Drawing.Color.Silver;
            this.button_addRecipient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_addRecipient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_addRecipient.Location = new System.Drawing.Point(346, 16);
            this.button_addRecipient.Name = "button_addRecipient";
            this.button_addRecipient.Size = new System.Drawing.Size(32, 32);
            this.button_addRecipient.TabIndex = 1;
            this.button_addRecipient.Text = "+";
            this.button_addRecipient.UseVisualStyleBackColor = false;
            this.button_addRecipient.Click += new System.EventHandler(this.button_addRecipient_Click);
            // 
            // comboBox_recipient
            // 
            this.comboBox_recipient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox_recipient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox_recipient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_recipient.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox_recipient.FormattingEnabled = true;
            this.comboBox_recipient.Location = new System.Drawing.Point(110, 18);
            this.comboBox_recipient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_recipient.Name = "comboBox_recipient";
            this.comboBox_recipient.Size = new System.Drawing.Size(229, 28);
            this.comboBox_recipient.TabIndex = 0;
            this.comboBox_recipient.SelectedIndexChanged += new System.EventHandler(this.comboBox_recipient_SelectedIndexChanged);
            this.comboBox_recipient.Enter += new System.EventHandler(this.comboBox_recipient_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.smsButton_delRecipiennt);
            this.Controls.Add(this.button_addRecipient);
            this.Controls.Add(this.comboBox_recipient);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.webBrowser1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinSMS - Polska";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_signature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_captcha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_content;
        private SMSButton button_send;
        private System.Windows.Forms.Label label6;
        private SMSButton button_addRecipient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private SMSComboBox comboBox_recipient;
        private SMSComboBox comboBox_sender;
        private SMSButton smsButton_delSender;
        private SMSButton smsButton_addSender;
        private SMSButton smsButton_delRecipiennt;
        private System.Windows.Forms.Panel panel2;
    }
}

