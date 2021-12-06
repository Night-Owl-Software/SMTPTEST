
namespace SMTPTEST
{
    partial class MainForm
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
            this.tboxAuthEmailAddress = new System.Windows.Forms.TextBox();
            this.tboxAuthPassword = new System.Windows.Forms.TextBox();
            this.lblAuthEmailAddress = new System.Windows.Forms.Label();
            this.lblAuthPassword = new System.Windows.Forms.Label();
            this.grpAuthentication = new System.Windows.Forms.GroupBox();
            this.tboxAuthPort = new System.Windows.Forms.TextBox();
            this.grpMailDetails = new System.Windows.Forms.GroupBox();
            this.tboxMailBody = new System.Windows.Forms.RichTextBox();
            this.lblMailBody = new System.Windows.Forms.Label();
            this.lblMailSubject = new System.Windows.Forms.Label();
            this.tboxMailSubject = new System.Windows.Forms.TextBox();
            this.lblMailFrom = new System.Windows.Forms.Label();
            this.tboxMailFrom = new System.Windows.Forms.TextBox();
            this.lblMailTo = new System.Windows.Forms.Label();
            this.tboxMailTo = new System.Windows.Forms.TextBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.lblAuthPortNumber = new System.Windows.Forms.Label();
            this.boolAuthEnableSSL = new System.Windows.Forms.CheckBox();
            this.lblAuthMailServer = new System.Windows.Forms.Label();
            this.tboxAuthMailServer = new System.Windows.Forms.TextBox();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOffice365DirectSend = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAuthentication.SuspendLayout();
            this.grpMailDetails.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxAuthEmailAddress
            // 
            this.tboxAuthEmailAddress.Location = new System.Drawing.Point(88, 55);
            this.tboxAuthEmailAddress.Name = "tboxAuthEmailAddress";
            this.tboxAuthEmailAddress.Size = new System.Drawing.Size(200, 20);
            this.tboxAuthEmailAddress.TabIndex = 1;
            // 
            // tboxAuthPassword
            // 
            this.tboxAuthPassword.Location = new System.Drawing.Point(88, 89);
            this.tboxAuthPassword.Name = "tboxAuthPassword";
            this.tboxAuthPassword.PasswordChar = '*';
            this.tboxAuthPassword.Size = new System.Drawing.Size(200, 20);
            this.tboxAuthPassword.TabIndex = 2;
            // 
            // lblAuthEmailAddress
            // 
            this.lblAuthEmailAddress.AutoSize = true;
            this.lblAuthEmailAddress.Location = new System.Drawing.Point(6, 58);
            this.lblAuthEmailAddress.Name = "lblAuthEmailAddress";
            this.lblAuthEmailAddress.Size = new System.Drawing.Size(76, 13);
            this.lblAuthEmailAddress.TabIndex = 2;
            this.lblAuthEmailAddress.Text = "Email Address:";
            // 
            // lblAuthPassword
            // 
            this.lblAuthPassword.AutoSize = true;
            this.lblAuthPassword.Location = new System.Drawing.Point(26, 92);
            this.lblAuthPassword.Name = "lblAuthPassword";
            this.lblAuthPassword.Size = new System.Drawing.Size(56, 13);
            this.lblAuthPassword.TabIndex = 3;
            this.lblAuthPassword.Text = "Password:";
            // 
            // grpAuthentication
            // 
            this.grpAuthentication.Controls.Add(this.lblAuthMailServer);
            this.grpAuthentication.Controls.Add(this.tboxAuthMailServer);
            this.grpAuthentication.Controls.Add(this.boolAuthEnableSSL);
            this.grpAuthentication.Controls.Add(this.lblAuthPortNumber);
            this.grpAuthentication.Controls.Add(this.tboxAuthPort);
            this.grpAuthentication.Controls.Add(this.lblAuthEmailAddress);
            this.grpAuthentication.Controls.Add(this.lblAuthPassword);
            this.grpAuthentication.Controls.Add(this.tboxAuthEmailAddress);
            this.grpAuthentication.Controls.Add(this.tboxAuthPassword);
            this.grpAuthentication.Location = new System.Drawing.Point(12, 35);
            this.grpAuthentication.Name = "grpAuthentication";
            this.grpAuthentication.Size = new System.Drawing.Size(306, 161);
            this.grpAuthentication.TabIndex = 4;
            this.grpAuthentication.TabStop = false;
            this.grpAuthentication.Text = "Authentication Details";
            // 
            // tboxAuthPort
            // 
            this.tboxAuthPort.Location = new System.Drawing.Point(88, 123);
            this.tboxAuthPort.Name = "tboxAuthPort";
            this.tboxAuthPort.Size = new System.Drawing.Size(57, 20);
            this.tboxAuthPort.TabIndex = 3;
            // 
            // grpMailDetails
            // 
            this.grpMailDetails.Controls.Add(this.tboxMailBody);
            this.grpMailDetails.Controls.Add(this.lblMailBody);
            this.grpMailDetails.Controls.Add(this.lblMailSubject);
            this.grpMailDetails.Controls.Add(this.tboxMailSubject);
            this.grpMailDetails.Controls.Add(this.lblMailFrom);
            this.grpMailDetails.Controls.Add(this.tboxMailFrom);
            this.grpMailDetails.Controls.Add(this.lblMailTo);
            this.grpMailDetails.Controls.Add(this.tboxMailTo);
            this.grpMailDetails.Location = new System.Drawing.Point(12, 202);
            this.grpMailDetails.Name = "grpMailDetails";
            this.grpMailDetails.Size = new System.Drawing.Size(306, 221);
            this.grpMailDetails.TabIndex = 5;
            this.grpMailDetails.TabStop = false;
            this.grpMailDetails.Text = "Mail Details";
            // 
            // tboxMailBody
            // 
            this.tboxMailBody.Location = new System.Drawing.Point(45, 111);
            this.tboxMailBody.Name = "tboxMailBody";
            this.tboxMailBody.Size = new System.Drawing.Size(243, 96);
            this.tboxMailBody.TabIndex = 8;
            this.tboxMailBody.Text = "";
            // 
            // lblMailBody
            // 
            this.lblMailBody.AutoSize = true;
            this.lblMailBody.Location = new System.Drawing.Point(6, 114);
            this.lblMailBody.Name = "lblMailBody";
            this.lblMailBody.Size = new System.Drawing.Size(34, 13);
            this.lblMailBody.TabIndex = 9;
            this.lblMailBody.Text = "Body:";
            // 
            // lblMailSubject
            // 
            this.lblMailSubject.AutoSize = true;
            this.lblMailSubject.Location = new System.Drawing.Point(6, 85);
            this.lblMailSubject.Name = "lblMailSubject";
            this.lblMailSubject.Size = new System.Drawing.Size(46, 13);
            this.lblMailSubject.TabIndex = 8;
            this.lblMailSubject.Text = "Subject:";
            // 
            // tboxMailSubject
            // 
            this.tboxMailSubject.Location = new System.Drawing.Point(64, 82);
            this.tboxMailSubject.Name = "tboxMailSubject";
            this.tboxMailSubject.Size = new System.Drawing.Size(224, 20);
            this.tboxMailSubject.TabIndex = 7;
            // 
            // lblMailFrom
            // 
            this.lblMailFrom.AutoSize = true;
            this.lblMailFrom.Location = new System.Drawing.Point(6, 57);
            this.lblMailFrom.Name = "lblMailFrom";
            this.lblMailFrom.Size = new System.Drawing.Size(33, 13);
            this.lblMailFrom.TabIndex = 6;
            this.lblMailFrom.Text = "From:";
            // 
            // tboxMailFrom
            // 
            this.tboxMailFrom.Location = new System.Drawing.Point(45, 54);
            this.tboxMailFrom.Name = "tboxMailFrom";
            this.tboxMailFrom.Size = new System.Drawing.Size(243, 20);
            this.tboxMailFrom.TabIndex = 6;
            // 
            // lblMailTo
            // 
            this.lblMailTo.AutoSize = true;
            this.lblMailTo.Location = new System.Drawing.Point(6, 31);
            this.lblMailTo.Name = "lblMailTo";
            this.lblMailTo.Size = new System.Drawing.Size(23, 13);
            this.lblMailTo.TabIndex = 4;
            this.lblMailTo.Text = "To:";
            // 
            // tboxMailTo
            // 
            this.tboxMailTo.Location = new System.Drawing.Point(45, 28);
            this.tboxMailTo.Name = "tboxMailTo";
            this.tboxMailTo.Size = new System.Drawing.Size(243, 20);
            this.tboxMailTo.TabIndex = 5;
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(12, 429);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(75, 23);
            this.btnSendMail.TabIndex = 9;
            this.btnSendMail.Text = "Send Mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(243, 429);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(75, 23);
            this.btnResetForm.TabIndex = 10;
            this.btnResetForm.Text = "Reset";
            this.btnResetForm.UseVisualStyleBackColor = true;
            // 
            // lblAuthPortNumber
            // 
            this.lblAuthPortNumber.AutoSize = true;
            this.lblAuthPortNumber.Location = new System.Drawing.Point(53, 126);
            this.lblAuthPortNumber.Name = "lblAuthPortNumber";
            this.lblAuthPortNumber.Size = new System.Drawing.Size(29, 13);
            this.lblAuthPortNumber.TabIndex = 7;
            this.lblAuthPortNumber.Text = "Port:";
            // 
            // boolAuthEnableSSL
            // 
            this.boolAuthEnableSSL.AutoSize = true;
            this.boolAuthEnableSSL.Location = new System.Drawing.Point(175, 126);
            this.boolAuthEnableSSL.Name = "boolAuthEnableSSL";
            this.boolAuthEnableSSL.Size = new System.Drawing.Size(113, 17);
            this.boolAuthEnableSSL.TabIndex = 4;
            this.boolAuthEnableSSL.Text = "Enable SSL/TLS?";
            this.boolAuthEnableSSL.UseVisualStyleBackColor = true;
            // 
            // lblAuthMailServer
            // 
            this.lblAuthMailServer.AutoSize = true;
            this.lblAuthMailServer.Location = new System.Drawing.Point(6, 29);
            this.lblAuthMailServer.Name = "lblAuthMailServer";
            this.lblAuthMailServer.Size = new System.Drawing.Size(63, 13);
            this.lblAuthMailServer.TabIndex = 10;
            this.lblAuthMailServer.Text = "Mail Server:";
            // 
            // tboxAuthMailServer
            // 
            this.tboxAuthMailServer.Location = new System.Drawing.Point(88, 26);
            this.tboxAuthMailServer.Name = "tboxAuthMailServer";
            this.tboxAuthMailServer.Size = new System.Drawing.Size(200, 20);
            this.tboxAuthMailServer.TabIndex = 0;
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testsToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(338, 24);
            this.menuMain.TabIndex = 8;
            this.menuMain.Text = "menuStrip1";
            // 
            // testsToolStripMenuItem
            // 
            this.testsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOffice365DirectSend});
            this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.testsToolStripMenuItem.Text = "Tests";
            // 
            // menuItemOffice365DirectSend
            // 
            this.menuItemOffice365DirectSend.Name = "menuItemOffice365DirectSend";
            this.menuItemOffice365DirectSend.Size = new System.Drawing.Size(189, 22);
            this.menuItemOffice365DirectSend.Text = "Office365 Direct-Send";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 461);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.grpMailDetails);
            this.Controls.Add(this.grpAuthentication);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.Text = "Office365 SMTP Test";
            this.grpAuthentication.ResumeLayout(false);
            this.grpAuthentication.PerformLayout();
            this.grpMailDetails.ResumeLayout(false);
            this.grpMailDetails.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxAuthEmailAddress;
        private System.Windows.Forms.TextBox tboxAuthPassword;
        private System.Windows.Forms.Label lblAuthEmailAddress;
        private System.Windows.Forms.Label lblAuthPassword;
        private System.Windows.Forms.GroupBox grpAuthentication;
        private System.Windows.Forms.TextBox tboxAuthPort;
        private System.Windows.Forms.GroupBox grpMailDetails;
        private System.Windows.Forms.RichTextBox tboxMailBody;
        private System.Windows.Forms.Label lblMailBody;
        private System.Windows.Forms.Label lblMailSubject;
        private System.Windows.Forms.TextBox tboxMailSubject;
        private System.Windows.Forms.Label lblMailFrom;
        private System.Windows.Forms.TextBox tboxMailFrom;
        private System.Windows.Forms.Label lblMailTo;
        private System.Windows.Forms.TextBox tboxMailTo;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.CheckBox boolAuthEnableSSL;
        private System.Windows.Forms.Label lblAuthPortNumber;
        private System.Windows.Forms.Label lblAuthMailServer;
        private System.Windows.Forms.TextBox tboxAuthMailServer;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem testsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemOffice365DirectSend;
    }
}

