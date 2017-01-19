namespace MessageEncryption
{
    partial class Primatelj
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
            this.txtReceivedMessage = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtKeyReceiver = new System.Windows.Forms.TextBox();
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtReceivedMessage
            // 
            this.txtReceivedMessage.Location = new System.Drawing.Point(68, 77);
            this.txtReceivedMessage.Multiline = true;
            this.txtReceivedMessage.Name = "txtReceivedMessage";
            this.txtReceivedMessage.Size = new System.Drawing.Size(314, 87);
            this.txtReceivedMessage.TabIndex = 0;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(160, 170);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(107, 33);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "Dekriptiraj poruku";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtKeyReceiver
            // 
            this.txtKeyReceiver.Location = new System.Drawing.Point(68, 25);
            this.txtKeyReceiver.Name = "txtKeyReceiver";
            this.txtKeyReceiver.ReadOnly = true;
            this.txtKeyReceiver.Size = new System.Drawing.Size(314, 20);
            this.txtKeyReceiver.TabIndex = 2;
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Location = new System.Drawing.Point(68, 219);
            this.txtDecrypted.Multiline = true;
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.Size = new System.Drawing.Size(314, 87);
            this.txtDecrypted.TabIndex = 3;
            // 
            // Primatelj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 395);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.txtKeyReceiver);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtReceivedMessage);
            this.Name = "Primatelj";
            this.Text = "Primatelj";
            this.Load += new System.EventHandler(this.Primatelj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReceivedMessage;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtKeyReceiver;
        private System.Windows.Forms.TextBox txtDecrypted;
    }
}