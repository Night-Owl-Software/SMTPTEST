using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace SMTPTEST
{
    public partial class DirectSendForm : Form
    {
        public DirectSendForm()
        {
            InitializeComponent();
            ResetForm();
        }

        private void ResetForm()
        {
            // Disable all Events
            btnSendMail.Click -= OnSendMailClick;
            btnCloseForm.Click -= OnCloseClick;

            tboxAuthMailServer.TextChanged -= OnValueChanged;
            tboxAuthEmailAddress.TextChanged -= OnValueChanged;
            tboxMailFrom.TextChanged -= OnValueChanged;
            tboxMailTo.TextChanged -= OnValueChanged;

            boolOverrideAuthMailServer.CheckedChanged -= OnOverrideChanged;
            boolOverrideMailBody.CheckedChanged -= OnOverrideChanged;
            boolOverrideMailSubject.CheckedChanged -= OnOverrideChanged;
            boolOverrideMailFrom.CheckedChanged -= OnOverrideChanged;

            // Set Default Values
            btnSendMail.Enabled = false;

            tboxAuthMailServer.Text = "example-com.mail.protection.outlook.com";
            tboxAuthEmailAddress.Text = "user@example.com";
            tboxMailFrom.Text = tboxAuthEmailAddress.Text;
            tboxMailTo.Text = "user";
            tboxMailSubject.Text = "Office365 Direct-Send Test Email";
            tboxMailBody.Text = "This is a test using the Office365 Direct-Send SMTP Troubleshooting application.";

            // Enable Events
            boolOverrideAuthMailServer.CheckedChanged += OnOverrideChanged;
            boolOverrideMailBody.CheckedChanged += OnOverrideChanged;
            boolOverrideMailSubject.CheckedChanged += OnOverrideChanged;
            boolOverrideMailFrom.CheckedChanged += OnOverrideChanged;

            tboxAuthMailServer.TextChanged += OnValueChanged;
            tboxAuthEmailAddress.TextChanged += OnValueChanged;
            tboxMailFrom.TextChanged += OnValueChanged;
            tboxMailTo.TextChanged += OnValueChanged;

            btnSendMail.Click += OnSendMailClick;
            btnCloseForm.Click += OnCloseClick;
        }
        private void ValidateAllFields()
        {
            bool formIsReady = true;

            string authMailServer = tboxAuthMailServer.Text;
            string authEmailAddress = tboxAuthEmailAddress.Text;
            string mailTo = tboxMailTo.Text;
            string mailFrom = tboxMailFrom.Text;

            if (string.IsNullOrWhiteSpace(authEmailAddress) == false)
            {
                if (IsValidEmail(authEmailAddress))
                {
                    string[] emailStrings = authEmailAddress.Split('@');
                    string domainName = emailStrings[1];

                    lblMailToDomain.Text = $"@{domainName}";

                    if (boolOverrideAuthMailServer.Checked == false)
                    {
                        tboxAuthMailServer.Text = $"{domainName.Replace(".","-")}.mail.protection.outlook.com";
                    }
                }
            }

            if (boolOverrideMailFrom.Checked == false)
            {
                tboxMailFrom.Text = authEmailAddress;
            }

            if (string.IsNullOrWhiteSpace(authMailServer))
            {
                formIsReady = false;
            }

            if (string.IsNullOrWhiteSpace(mailTo))
            {
                formIsReady = false;
            }

            if (string.IsNullOrWhiteSpace(mailFrom))
            {
                formIsReady = false;
            }

            btnSendMail.Enabled = formIsReady;
        }
        private bool IsValidEmail(string emailAddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailAddress);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            ValidateAllFields();
        }
        private void OnOverrideChanged(object sender, EventArgs e)
        {
            if (boolOverrideAuthMailServer.Checked == false && string.IsNullOrWhiteSpace(tboxAuthEmailAddress.Text) == false)
            {
                if (IsValidEmail(tboxAuthEmailAddress.Text))
                {
                    string[] emailStrings = tboxAuthEmailAddress.Text.Split('@');
                    string domainName = emailStrings[1].Replace(".", "-");
                    tboxAuthMailServer.Text = $"{domainName}.mail.protection.outlook.com";
                }
            }

            if (boolOverrideMailFrom.Checked == false)
            {
                tboxMailFrom.Text = tboxAuthEmailAddress.Text;
            }

            if (boolOverrideMailSubject.Checked == false)
            {
                tboxMailSubject.Text = "Office365 Direct-Send Test Email";
            }

            if (boolOverrideMailBody.Checked == false)
            {
                tboxMailBody.Text = "This is a test using the Office365 Direct-Send SMTP Troubleshooting application.";
            }

            tboxAuthMailServer.ReadOnly = !boolOverrideAuthMailServer.Checked;
            tboxMailFrom.ReadOnly = !boolOverrideMailFrom.Checked;
            tboxMailSubject.ReadOnly = !boolOverrideMailSubject.Checked;
            tboxMailBody.ReadOnly = !boolOverrideMailBody.Checked;

        }
        private void OnSendMailClick(object sender, EventArgs e)
        {
            // Collect Necessary Input
            string authMailServer = tboxAuthMailServer.Text;
            string mailTo = tboxMailTo.Text + lblMailToDomain.Text;
            string mailFrom = tboxMailFrom.Text;
            string mailSubject = tboxMailSubject.Text;
            string mailBody = tboxMailBody.Text;

            using (SmtpClient smtpClient = new SmtpClient(authMailServer))
            {
                smtpClient.Port = 25;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(tboxAuthEmailAddress.Text, "");

                try
                {
                    smtpClient.Send(mailFrom, mailTo, mailSubject, mailBody);
                }
                catch (SmtpException exception)
                {
                    MessageBox.Show($"Mail failed to send with the following error:\r\r\n\n{exception.Message}");
                }
            }
        }
        private void OnCloseClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}

