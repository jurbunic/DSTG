namespace MessageEncryption
{
    partial class Posiljatelj
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
            this.txtKeySender = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtEncryptedMessage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKeySender
            // 
            this.txtKeySender.Location = new System.Drawing.Point(73, 12);
            this.txtKeySender.Name = "txtKeySender";
            this.txtKeySender.ReadOnly = true;
            this.txtKeySender.Size = new System.Drawing.Size(288, 20);
            this.txtKeySender.TabIndex = 0;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(73, 60);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(288, 67);
            this.txtMessage.TabIndex = 1;
            // 
            // txtEncryptedMessage
            // 
            this.txtEncryptedMessage.Location = new System.Drawing.Point(73, 193);
            this.txtEncryptedMessage.Multiline = true;
            this.txtEncryptedMessage.Name = "txtEncryptedMessage";
            this.txtEncryptedMessage.ReadOnly = true;
            this.txtEncryptedMessage.Size = new System.Drawing.Size(288, 67);
            this.txtEncryptedMessage.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Enkriptiraj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(160, 284);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(124, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Pošalji";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Posiljatelj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 402);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEncryptedMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtKeySender);
            this.Name = "Posiljatelj";
            this.Text = "Posiljatelj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKeySender;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtEncryptedMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSend;
    }
}