
namespace SMTPTEST
{
    partial class DirectSendForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectSendForm));
            this.lblAuthMailServer = new System.Windows.Forms.Label();
            this.lblAuthEmailAddress = new System.Windows.Forms.Label();
            this.lblMailFrom = new System.Windows.Forms.Label();
            this.lblMailTo = new System.Windows.Forms.Label();
            this.lblMailSubject = new System.Windows.Forms.Label();
            this.lblMailBody = new System.Windows.Forms.Label();
            this.tboxMailBody = new System.Windows.Forms.RichTextBox();
            this.tboxMailSubject = new System.Windows.Forms.TextBox();
            this.tboxMailTo = new System.Windows.Forms.TextBox();
            this.tboxMailFrom = new System.Windows.Forms.TextBox();
            this.tboxAuthMailServer = new System.Windows.Forms.TextBox();
            this.tboxAuthEmailAddress = new System.Windows.Forms.TextBox();
            this.boolOverrideAuthMailServer = new System.Windows.Forms.CheckBox();
            this.grpAuthMailSettings = new System.Windows.Forms.GroupBox();
            this.boolOverrideMailSubject = new System.Windows.Forms.CheckBox();
            this.boolOverrideMailBody = new System.Windows.Forms.CheckBox();
            this.grpMailDetails = new System.Windows.Forms.GroupBox();
            this.lblMailToDomain = new System.Windows.Forms.Label();
            this.boolOverrideMailFrom = new System.Windows.Forms.CheckBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.grpAuthMailSettings.SuspendLayout();
            this.grpMailDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAuthMailServer
            // 
            this.lblAuthMailServer.AutoSize = true;
            this.lblAuthMailServer.Location = new System.Drawing.Point(25, 32);
            this.lblAuthMailServer.Name = "lblAuthMailServer";
            this.lblAuthMailServer.Size = new System.Drawing.Size(63, 13);
            this.lblAuthMailServer.TabIndex = 0;
            this.lblAuthMailServer.Text = "Mail Server:";
            // 
            // lblAuthEmailAddress
            // 
            this.lblAuthEmailAddress.AutoSize = true;
            this.lblAuthEmailAddress.Location = new System.Drawing.Point(12, 58);
            this.lblAuthEmailAddress.Name = "lblAuthEmailAddress";
            this.lblAuthEmailAddress.Size = new System.Drawing.Size(76, 13);
            this.lblAuthEmailAddress.TabIndex = 1;
            this.lblAuthEmailAddress.Text = "Email Address:";
            // 
            // lblMailFrom
            // 
            this.lblMailFrom.AutoSize = true;
            this.lblMailFrom.Location = new System.Drawing.Point(12, 31);
            this.lblMailFrom.Name = "lblMailFrom";
            this.lblMailFrom.Size = new System.Drawing.Size(55, 13);
            this.lblMailFrom.TabIndex = 2;
            this.lblMailFrom.Text = "Mail From:";
            // 
            // lblMailTo
            // 
            this.lblMailTo.AutoSize = true;
            this.lblMailTo.Location = new System.Drawing.Point(22, 57);
            this.lblMailTo.Name = "lblMailTo";
            this.lblMailTo.Size = new System.Drawing.Size(45, 13);
            this.lblMailTo.TabIndex = 3;
            this.lblMailTo.Text = "Mail To:";
            // 
            // lblMailSubject
            // 
            this.lblMailSubject.AutoSize = true;
            this.lblMailSubject.Location = new System.Drawing.Point(21, 83);
            this.lblMailSubject.Name = "lblMailSubject";
            this.lblMailSubject.Size = new System.Drawing.Size(46, 13);
            this.lblMailSubject.TabIndex = 4;
            this.lblMailSubject.Text = "Subject:";
            // 
            // lblMailBody
            // 
            this.lblMailBody.AutoSize = true;
            this.lblMailBody.Location = new System.Drawing.Point(33, 109);
            this.lblMailBody.Name = "lblMailBody";
            this.lblMailBody.Size = new System.Drawing.Size(34, 13);
            this.lblMailBody.TabIndex = 5;
            this.lblMailBody.Text = "Body:";
            // 
            // tboxMailBody
            // 
            this.tboxMailBody.Location = new System.Drawing.Point(73, 106);
            this.tboxMailBody.Name = "tboxMailBody";
            this.tboxMailBody.ReadOnly = true;
            this.tboxMailBody.Size = new System.Drawing.Size(192, 108);
            this.tboxMailBody.TabIndex = 8;
            this.tboxMailBody.Text = "";
            // 
            // tboxMailSubject
            // 
            this.tboxMailSubject.Location = new System.Drawing.Point(73, 80);
            this.tboxMailSubject.Name = "tboxMailSubject";
            this.tboxMailSubject.ReadOnly = true;
            this.tboxMailSubject.Size = new System.Drawing.Size(192, 20);
            this.tboxMailSubject.TabIndex = 6;
            // 
            // tboxMailTo
            // 
            this.tboxMailTo.Location = new System.Drawing.Point(73, 54);
            this.tboxMailTo.Name = "tboxMailTo";
            this.tboxMailTo.Size = new System.Drawing.Size(92, 20);
            this.tboxMailTo.TabIndex = 5;
            // 
            // tboxMailFrom
            // 
            this.tboxMailFrom.Location = new System.Drawing.Point(73, 28);
            this.tboxMailFrom.Name = "tboxMailFrom";
            this.tboxMailFrom.ReadOnly = true;
            this.tboxMailFrom.Size = new System.Drawing.Size(192, 20);
            this.tboxMailFrom.TabIndex = 3;
            // 
            // tboxAuthMailServer
            // 
            this.tboxAuthMailServer.Location = new System.Drawing.Point(94, 29);
            this.tboxAuthMailServer.Name = "tboxAuthMailServer";
            this.tboxAuthMailServer.ReadOnly = true;
            this.tboxAuthMailServer.Size = new System.Drawing.Size(192, 20);
            this.tboxAuthMailServer.TabIndex = 0;
            // 
            // tboxAuthEmailAddress
            // 
            this.tboxAuthEmailAddress.Location = new System.Drawing.Point(94, 55);
            this.tboxAuthEmailAddress.Name = "tboxAuthEmailAddress";
            this.tboxAuthEmailAddress.Size = new System.Drawing.Size(192, 20);
            this.tboxAuthEmailAddress.TabIndex = 2;
            // 
            // boolOverrideAuthMailServer
            // 
            this.boolOverrideAuthMailServer.AutoSize = true;
            this.boolOverrideAuthMailServer.Location = new System.Drawing.Point(292, 31);
            this.boolOverrideAuthMailServer.Name = "boolOverrideAuthMailServer";
            this.boolOverrideAuthMailServer.Size = new System.Drawing.Size(66, 17);
            this.boolOverrideAuthMailServer.TabIndex = 1;
            this.boolOverrideAuthMailServer.Text = "Override";
            this.boolOverrideAuthMailServer.UseVisualStyleBackColor = true;
            // 
            // grpAuthMailSettings
            // 
            this.grpAuthMailSettings.Controls.Add(this.lblAuthMailServer);
            this.grpAuthMailSettings.Controls.Add(this.boolOverrideAuthMailServer);
            this.grpAuthMailSettings.Controls.Add(this.lblAuthEmailAddress);
            this.grpAuthMailSettings.Controls.Add(this.tboxAuthEmailAddress);
            this.grpAuthMailSettings.Controls.Add(this.tboxAuthMailServer);
            this.grpAuthMailSettings.Location = new System.Drawing.Point(12, 12);
            this.grpAuthMailSettings.Name = "grpAuthMailSettings";
            this.grpAuthMailSettings.Size = new System.Drawing.Size(364, 97);
            this.grpAuthMailSettings.TabIndex = 13;
            this.grpAuthMailSettings.TabStop = false;
            this.grpAuthMailSettings.Text = "Authentication Details";
            // 
            // boolOverrideMailSubject
            // 
            this.boolOverrideMailSubject.AutoSize = true;
            this.boolOverrideMailSubject.Location = new System.Drawing.Point(271, 83);
            this.boolOverrideMailSubject.Name = "boolOverrideMailSubject";
            this.boolOverrideMailSubject.Size = new System.Drawing.Size(66, 17);
            this.boolOverrideMailSubject.TabIndex = 7;
            this.boolOverrideMailSubject.Text = "Override";
            this.boolOverrideMailSubject.UseVisualStyleBackColor = true;
            // 
            // boolOverrideMailBody
            // 
            this.boolOverrideMailBody.AutoSize = true;
            this.boolOverrideMailBody.Location = new System.Drawing.Point(271, 109);
            this.boolOverrideMailBody.Name = "boolOverrideMailBody";
            this.boolOverrideMailBody.Size = new System.Drawing.Size(66, 17);
            this.boolOverrideMailBody.TabIndex = 9;
            this.boolOverrideMailBody.Text = "Override";
            this.boolOverrideMailBody.UseVisualStyleBackColor = true;
            // 
            // grpMailDetails
            // 
            this.grpMailDetails.Controls.Add(this.lblMailToDomain);
            this.grpMailDetails.Controls.Add(this.boolOverrideMailFrom);
            this.grpMailDetails.Controls.Add(this.lblMailFrom);
            this.grpMailDetails.Controls.Add(this.boolOverrideMailBody);
            this.grpMailDetails.Controls.Add(this.lblMailTo);
            this.grpMailDetails.Controls.Add(this.boolOverrideMailSubject);
            this.grpMailDetails.Controls.Add(this.lblMailSubject);
            this.grpMailDetails.Controls.Add(this.lblMailBody);
            this.grpMailDetails.Controls.Add(this.tboxMailFrom);
            this.grpMailDetails.Controls.Add(this.tboxMailBody);
            this.grpMailDetails.Controls.Add(this.tboxMailTo);
            this.grpMailDetails.Controls.Add(this.tboxMailSubject);
            this.grpMailDetails.Location = new System.Drawing.Point(12, 115);
            this.grpMailDetails.Name = "grpMailDetails";
            this.grpMailDetails.Size = new System.Drawing.Size(364, 227);
            this.grpMailDetails.TabIndex = 16;
            this.grpMailDetails.TabStop = false;
            this.grpMailDetails.Text = "Mail Details";
            // 
            // lblMailToDomain
            // 
            this.lblMailToDomain.AutoSize = true;
            this.lblMailToDomain.Location = new System.Drawing.Point(164, 57);
            this.lblMailToDomain.Name = "lblMailToDomain";
            this.lblMailToDomain.Size = new System.Drawing.Size(80, 13);
            this.lblMailToDomain.TabIndex = 17;
            this.lblMailToDomain.Text = "@example.com";
            // 
            // boolOverrideMailFrom
            // 
            this.boolOverrideMailFrom.AutoSize = true;
            this.boolOverrideMailFrom.Location = new System.Drawing.Point(271, 31);
            this.boolOverrideMailFrom.Name = "boolOverrideMailFrom";
            this.boolOverrideMailFrom.Size = new System.Drawing.Size(66, 17);
            this.boolOverrideMailFrom.TabIndex = 4;
            this.boolOverrideMailFrom.Text = "Override";
            this.boolOverrideMailFrom.UseVisualStyleBackColor = true;
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(12, 348);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(75, 23);
            this.btnSendMail.TabIndex = 10;
            this.btnSendMail.Text = "Send Mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Location = new System.Drawing.Point(301, 348);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(75, 23);
            this.btnCloseForm.TabIndex = 11;
            this.btnCloseForm.Text = "Close";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            // 
            // DirectSendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 387);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.grpMailDetails);
            this.Controls.Add(this.grpAuthMailSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DirectSendForm";
            this.Text = "Office365 Direct Send Test";
            this.grpAuthMailSettings.ResumeLayout(false);
            this.grpAuthMailSettings.PerformLayout();
            this.grpMailDetails.ResumeLayout(false);
            this.grpMailDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAuthMailServer;
        private System.Windows.Forms.Label lblAuthEmailAddress;
        private System.Windows.Forms.Label lblMailFrom;
        private System.Windows.Forms.Label lblMailTo;
        private System.Windows.Forms.Label lblMailSubject;
        private System.Windows.Forms.Label lblMailBody;
        private System.Windows.Forms.RichTextBox tboxMailBody;
        private System.Windows.Forms.TextBox tboxMailSubject;
        private System.Windows.Forms.TextBox tboxMailTo;
        private System.Windows.Forms.TextBox tboxMailFrom;
        private System.Windows.Forms.TextBox tboxAuthMailServer;
        private System.Windows.Forms.TextBox tboxAuthEmailAddress;
        private System.Windows.Forms.CheckBox boolOverrideAuthMailServer;
        private System.Windows.Forms.GroupBox grpAuthMailSettings;
        private System.Windows.Forms.CheckBox boolOverrideMailSubject;
        private System.Windows.Forms.CheckBox boolOverrideMailBody;
        private System.Windows.Forms.GroupBox grpMailDetails;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.CheckBox boolOverrideMailFrom;
        private System.Windows.Forms.Label lblMailToDomain;
    }
}