using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace SMTPTEST
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ResetForm();
        }

        private void ResetForm()
        {
            // Disable All Events
            btnSendMail.Click -= OnSendMailClick;
            btnResetForm.Click -= OnResetFormClick;

            tboxAuthMailServer.TextChanged -= OnValueChanged;
            tboxAuthEmailAddress.TextChanged -= OnValueChanged;
            tboxAuthPassword.TextChanged -= OnValueChanged;
            tboxAuthPort.TextChanged -= OnValueChanged;
            tboxMailTo.TextChanged -= OnValueChanged;
            tboxMailFrom.TextChanged -= OnValueChanged;
            boolOverrideMailFrom.CheckedChanged -= OnCheckedChanged;

            menuItemOffice365DirectSend.Click -= OnDirectSendTestItemClick;

            // Clear All Form Data
            btnSendMail.Enabled = false;

            tboxAuthMailServer.Text = "smtp.office365.com";
            tboxAuthEmailAddress.Text = "";
            tboxAuthPassword.Text = "";
            tboxAuthPort.Text = "25";
            tboxMailFrom.Text = "";
            tboxMailTo.Text = "";
            tboxMailSubject.Text = "SMTP Test Email";
            tboxMailBody.Text = "This is a test using the SMTP Troubleshooting application.";

            boolAuthEnableSSL.Checked = false;

            // Enable All Events
            tboxAuthMailServer.TextChanged += OnValueChanged;
            tboxAuthEmailAddress.TextChanged += OnValueChanged;
            tboxAuthPassword.TextChanged += OnValueChanged;
            tboxAuthPort.TextChanged += OnValueChanged;
            tboxMailTo.TextChanged += OnValueChanged;
            tboxMailFrom.TextChanged += OnValueChanged;
            boolOverrideMailFrom.CheckedChanged += OnCheckedChanged;

            menuItemOffice365DirectSend.Click += OnDirectSendTestItemClick;

            btnSendMail.Click += OnSendMailClick;
            btnResetForm.Click += OnResetFormClick;
        }

        private void ValidateAllFields()
        {
            // Set Original Verification Boolean
            bool formIsReady = true;

            // Collect Necessary Input
            string authMailServer = tboxAuthMailServer.Text;
            string authEmailAddress = tboxAuthEmailAddress.Text;
            string authPassword = tboxAuthPassword.Text;
            string authPortString = tboxAuthPort.Text;
            string mailTo = tboxMailTo.Text;
            string mailFrom = tboxMailFrom.Text;

            // Attempt to Parse an INT from authPortString
            bool authPortIsValid = int.TryParse(authPortString, out int authPort);

            if(string.IsNullOrWhiteSpace(authEmailAddress) || IsValidEmail(authEmailAddress) == false)
            {
                formIsReady = false;
            }

            if (string.IsNullOrWhiteSpace(mailTo) || IsValidEmail(mailTo) == false)
            {
                formIsReady = false;
            }

            if (string.IsNullOrWhiteSpace(mailFrom) || IsValidEmail(mailFrom) == false)
            {
                formIsReady = false;
            }

            if (string.IsNullOrWhiteSpace(authMailServer))
            {
                formIsReady = false;
            }

            if (string.IsNullOrWhiteSpace(authPassword))
            {
                formIsReady = false;
            }

            if (string.IsNullOrWhiteSpace(authPortString) || authPortIsValid == false)
            {
                formIsReady = false;
            }

            if (boolOverrideMailFrom.Checked == false)
            {
                tboxMailFrom.Text = tboxAuthEmailAddress.Text;
            }

            // Use Final Validation
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
        private void OnCheckedChanged(object sender, EventArgs e)
        {
            tboxMailFrom.ReadOnly = !boolOverrideMailFrom.Checked;

            if (boolOverrideMailFrom.Checked == false)
            {
                tboxMailFrom.Text = tboxAuthEmailAddress.Text;
            }
        }
        private void OnSendMailClick(object sender, EventArgs e)
        {
            // Collect Necessary Input
            string authMailServer = tboxAuthMailServer.Text;
            string authEmailAddress = tboxAuthEmailAddress.Text;
            string authPassword = tboxAuthPassword.Text;
            int authPort = int.Parse(tboxAuthPort.Text);
            string mailTo = tboxMailTo.Text;
            string mailFrom = tboxMailFrom.Text;
            string mailSubject = tboxMailSubject.Text;
            string mailBody = tboxMailBody.Text;

            using (SmtpClient smtpClient = new SmtpClient(authMailServer))
            {
                smtpClient.Port = authPort;
                smtpClient.EnableSsl = boolAuthEnableSSL.Checked;
                smtpClient.Credentials = new NetworkCredential(authEmailAddress, authPassword);

                try
                {
                    smtpClient.Send(mailFrom, mailTo, mailSubject, mailBody);
                }
                catch(SmtpException exception)
                {
                    MessageBox.Show($"Mail failed to send with the following error:\r\r\n\n{exception.Message}");
                }
            }
        }
        private void OnResetFormClick(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void OnDirectSendTestItemClick(object sender, EventArgs e)
        {
            DirectSendForm newForm = new DirectSendForm();
            newForm.Show();
        }
    }
}
