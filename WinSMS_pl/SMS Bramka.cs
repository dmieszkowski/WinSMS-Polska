using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com
{
    public partial class Form1 : Form
    {
        string contactFileName = "contacts.json";
        string configFileName = "config.json";
        Config config = new Config();
        int Compleatcounter = 0;
        bool defaultReady = false;

        public Form1()
        {
            InitializeComponent();

            int? d = 0;
            var s = d.ToString().PadLeft(2, '0');

            LoadConfig();
        }

        void LoadConfig()
        {
            try
            {
                var file = File.ReadAllText(configFileName);
                config = ExtensionMethods.DeserializeJson<Config>(file);
                bindRecipiens();
                bindSenders();
                setDefault();
                defaultReady = true;
            }
            catch (Exception)
            {
               // MessageBox.Show("Brak konfiguracji.");
            }
        }

        private void setDefault()
        {
            try
            {
                textBox_signature.Text = config.Signature;
                comboBox_recipient.SelectedIndex = config.DefaultRecipient;
                comboBox_sender.SelectedIndex = config.DefaultSender;
            }
            catch (Exception ex)
            {
            }
        }

        void saveConf()
        {
            var s = config.ToJson();
            File.WriteAllText(configFileName, s);
            //bindContacts();
        }

        void bindRecipiens()
        {
            //comboBox_recipient.Items.Clear();
            comboBox_recipient.DisplayMember = "Fixed";
            comboBox_recipient.ValueMember = "Number";
            comboBox_recipient.DataSource = new BindingSource(config.Recipients, null);
        }
        void bindSenders()
        {
            //comboBox_recipient.Items.Clear();

            //comboBox_sender.Items.Clear();
            comboBox_sender.DisplayMember = "Fixed";
            comboBox_sender.ValueMember = "Number";
            comboBox_sender.DataSource = new BindingSource(config.Senders, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // comboBox_recipient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //linkLabel_addRecipient.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            webBrowser1.ScriptErrorsSuppressed = true;
            loadPage();
            textBox_content.Focus();
        }

        private void loadPage()
        {
            Compleatcounter = 0;
            webBrowser1.DocumentCompleted += WebBrowser1_DocumentCompleted;
            webBrowser1.Navigate("https://sms.orange.pl/minisms2.aspx");
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Compleatcounter++;
            if (Compleatcounter < 3) return;
            var imgHTML = webBrowser1.Document.GetElementById("tokenimg");
            int CaptchaOffsetX = getXoffset(imgHTML);
            int CaptchaOffsetY = getYoffset(imgHTML);
            int imgW = 35;
            int imgH = 125;
            Bitmap bitmap = new Bitmap(imgW, imgH);
            Webbrowsershow();
            Image imgCap = webBrowser1.CaptureWindow(new Rectangle(CaptchaOffsetX, CaptchaOffsetY + 10, imgHTML.OffsetRectangle.Width, imgHTML.OffsetRectangle.Height));
            WebbrowserHide();
            pictureBox1.Image = imgCap;
            SetReciverNumber(comboBox_recipient.SelectedValue?.ToString());
            SetSenderNumber(comboBox_sender.SelectedValue?.ToString());
            SetSenderSignature(config.Signature);

            setText();
            textBox_captcha.Text = "";
            textBox_content.SelectAll();
            textBox_content.Focus();

            Compleatcounter = 0;
            webBrowser1.DocumentCompleted -= WebBrowser1_DocumentCompleted;
            webBrowser1.DocumentCompleted += WebBrowser1_DocumentCompletedSent;
            DisableSplash();
        }

        private void WebbrowserHide()
        {
            webBrowser1.Location = new Point(450, webBrowser1.Location.Y);
            webBrowser1.Hide();
        }

        private void Webbrowsershow()
        {
            webBrowser1.Location = new Point(0, webBrowser1.Location.Y);
            webBrowser1.Show();
        }

        private void WebBrowser1_DocumentCompletedSent(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Compleatcounter++;

            if (webBrowser1.Document.Body.InnerText.Contains(@"adresat wiadomości nie ma aktywnej "))
            {
                MessageBox.Show("Wiadomość nie została dostarczona, gdyż adresat wiadomości nie ma aktywnej usługi SMS z Internetu. Jeśli adresat posiada telefon w sieci Orange, to został on powiadomiony, że oczekuje na niego wiadomość i musi aktywować usługę SMS z Internetu, żeby ją otrzymać. Żeby aktywować usługę SMS z Internetu wystarczy wysłać ze swojego telefonu SMSa o treści INTERNET na numer 102 (koszt jak za zwykły SMS).");
                webBrowser1.DocumentCompleted -= WebBrowser1_DocumentCompletedSent;
                loadPage();
            }

            if (webBrowser1.Document.Body.InnerText.Contains("wysłana"))
            {
                MessageBox.Show("Wiadomość wysłana");
                webBrowser1.DocumentCompleted -= WebBrowser1_DocumentCompletedSent;
                loadPage();
            }

            if (webBrowser1.Document.Body.InnerText.Contains("Podano błędne hasło, SMS nie został wysłany"))
            {
                MessageBox.Show("Podano błędny kod z obrazka, SMS nie został wysłany", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                webBrowser1.DocumentCompleted -= WebBrowser1_DocumentCompletedSent;
                loadPage();
            }
        }

        private void getPicture()
        {
            var img = webBrowser1.Document.GetElementById("tokenimg");
            pictureBox1.LoadAsync(img.GetAttribute("src"));
        }

        private void SetSenderSignature(string signature)
        {
            try
            {
                webBrowser1.Document.GetElementById("SENDER").SetAttribute("value", signature);
            }
            catch (Exception ex)
            {
            }
        }

        private void setPhoneNumberOption()
        {
            try
            {
                var el = webBrowser1.Document.GetElementById("RESPOPTION");
                el.Children[1].SetAttribute("selected", "selected");
                el.SetAttribute("value", "2");
                webBrowser1.Document.InvokeScript("disableSlash", new Object[] { "(function(){window.splashDisplayed = true;})()" });
            }
            catch (Exception ex)
            {
            }
        }

        private void DisableSplash()
        {
            webBrowser1.Document.GetElementById("splash").Children[0].Children[0].InvokeMember("Click");
        }

        //Methods to get Co-ordinates Of an Element in your webbrowser
        public int getXoffset(HtmlElement el)
        {
            //get element pos
            int xPos = el.OffsetRectangle.Left;

            //get the parents pos
            HtmlElement tempEl = el.OffsetParent;
            while (tempEl != null)
            {
                xPos += tempEl.OffsetRectangle.Left;
                tempEl = tempEl.OffsetParent;
            }

            return xPos;
        }

        public int getYoffset(HtmlElement el)
        {
            //get element pos
            int yPos = el.OffsetRectangle.Top;

            //get the parents pos
            HtmlElement tempEl = el.OffsetParent;
            while (tempEl != null)
            {
                yPos += tempEl.OffsetRectangle.Top;
                tempEl = tempEl.OffsetParent;
            }

            return yPos;
        }

        private void SetReciverNumber(string number)
        {
            try
            {
                webBrowser1.Document.GetElementById("RECIPIENT").SetAttribute("value", number);
            }
            catch (Exception ex)
            {
            }
        }

        private void textBox_signature_TextChanged(object sender, EventArgs e)
        {
            config.Signature = textBox_signature.Text;
            saveConf();
            SetSenderSignature(config.Signature);
        }

        private void comboBox_sender_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SetSenderNumber(comboBox_sender.SelectedValue.ToString());

            if (defaultReady)
            {
                config.DefaultSender = comboBox_sender.SelectedIndex;
                saveConf();
            }
        }

        private void SetSenderNumber(string number)
        {
            try
            {
                return;
                setPhoneNumberOption();
                webBrowser1.Document.GetElementById("CCMSISDN").SetAttribute("value", number);
                webBrowser1.Document.GetElementById("CCMSISDN2").SetAttribute("value", number);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void comboBox_recipient_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetReciverNumber(comboBox_recipient.SelectedValue.ToString());
            if (defaultReady)
            {
                config.DefaultRecipient = comboBox_recipient.SelectedIndex;
                saveConf();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_captcha_onChange(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Document.GetElementById("pass").SetAttribute("value", textBox_captcha.Text);
            }
            catch (Exception ex)
            {
            }
        }

        private void textBox_content_TextChanged(object sender, EventArgs e)
        {
            setText();
        }

        private void setText()
        {
            try
            {
                webBrowser1.Document.GetElementById("SHORT_MESSAGE").SetAttribute("value", textBox_content.Text);
            }
            catch (Exception ex)
            {
            }
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_content.Text.Length == 0)
                {
                    MessageBox.Show("Wpisz treść");
                    return;
                }
                if (textBox_captcha.Text.Length == 0)
                {
                    MessageBox.Show("Przepisz poprawnie kod z obrazka");
                    return;
                }

                webBrowser1.Document.GetElementById("Send").InvokeMember("Click");
                if (webBrowser1.Document.Body.InnerText.Contains("Wpisz nr tel"))
                {
                    MessageBox.Show("Numer odbiorcy nie jest prawidłowy");
                }
            }
            catch (Exception)
            {
                webBrowser1.DocumentCompleted -= WebBrowser1_DocumentCompletedSent;
                loadPage();
            }
        }

        private void button_addRecipient_Click(object sender, EventArgs e)
        {
            AddRecipiet();
        }

        private void smsButton_delRecipiennt_Click(object sender, EventArgs e)
        {
            if (comboBox_recipient.SelectedItem != null)
                config.Recipients.Remove((Contact)comboBox_recipient.SelectedItem);
            comboBox_recipient.DataSource = new BindingSource(config.Recipients, null);
            saveConf();
        }

        private void smsButton_addSender_Click(object sender, EventArgs e)
        {
            Form_addNumber f = new Form_addNumber();
            f.Text = "Nowy wysyłający";
            if (f.ShowDialog() == DialogResult.OK)
            {
                config.Senders.Add(new Contact() { Name = f.textBox1.Text, Number = f.textBox2.Text });
            }
            saveConf();
            bindSenders();
        }

        private void smsButton_delSender_Click(object sender, EventArgs e)
        {
            if (comboBox_sender.SelectedItem != null)
                config.Senders.Remove((Contact)comboBox_sender.SelectedItem);
            comboBox_sender.DataSource = new BindingSource(config.Senders, null);
            saveConf();
        }

        private void AddRecipiet()
        {
            Form_addNumber f = new Form_addNumber();
            f.Text = "Nowy odbiorca";
            if (f.ShowDialog() == DialogResult.OK)
            {
                config.Recipients.Add(new Contact() { Name = f.textBox1.Text, Number = f.textBox2.Text });
            }
            saveConf();
            bindRecipiens();
        }

        private void comboBox_recipient_Enter(object sender, EventArgs e)
        {
            while(config.Recipients.Count == 0)
            {
                AddRecipiet();
            }

        }
    }
}
