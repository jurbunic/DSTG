namespace MessageEncryption
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
            this.btnSender = new System.Windows.Forms.Button();
            this.btnReceiver = new System.Windows.Forms.Button();
            this.txtMainKey = new System.Windows.Forms.TextBox();
            this.btnNewKey = new System.Windows.Forms.Button();
            this.btnPotpis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSender
            // 
            this.btnSender.Location = new System.Drawing.Point(22, 254);
            this.btnSender.Name = "btnSender";
            this.btnSender.Size = new System.Drawing.Size(108, 61);
            this.btnSender.TabIndex = 0;
            this.btnSender.Text = "Pošiljatelj";
            this.btnSender.UseVisualStyleBackColor = true;
            this.btnSender.Click += new System.EventHandler(this.btnSender_Click);
            // 
            // btnReceiver
            // 
            this.btnReceiver.Location = new System.Drawing.Point(184, 252);
            this.btnReceiver.Name = "btnReceiver";
            this.btnReceiver.Size = new System.Drawing.Size(108, 63);
            this.btnReceiver.TabIndex = 1;
            this.btnReceiver.Text = "Primatelj";
            this.btnReceiver.UseVisualStyleBackColor = true;
            this.btnReceiver.Click += new System.EventHandler(this.btnReceiver_Click);
            // 
            // txtMainKey
            // 
            this.txtMainKey.Location = new System.Drawing.Point(12, 12);
            this.txtMainKey.Name = "txtMainKey";
            this.txtMainKey.ReadOnly = true;
            this.txtMainKey.Size = new System.Drawing.Size(302, 20);
            this.txtMainKey.TabIndex = 2;
            // 
            // btnNewKey
            // 
            this.btnNewKey.Location = new System.Drawing.Point(110, 51);
            this.btnNewKey.Name = "btnNewKey";
            this.btnNewKey.Size = new System.Drawing.Size(108, 63);
            this.btnNewKey.TabIndex = 3;
            this.btnNewKey.Text = "Generiraj ključ";
            this.btnNewKey.UseVisualStyleBackColor = true;
            this.btnNewKey.Click += new System.EventHandler(this.btnNewKey_Click);
            // 
            // btnPotpis
            // 
            this.btnPotpis.Location = new System.Drawing.Point(110, 156);
            this.btnPotpis.Name = "btnPotpis";
            this.btnPotpis.Size = new System.Drawing.Size(108, 46);
            this.btnPotpis.TabIndex = 4;
            this.btnPotpis.Text = "Potpis";
            this.btnPotpis.UseVisualStyleBackColor = true;
            this.btnPotpis.Click += new System.EventHandler(this.btnPotpis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 352);
            this.Controls.Add(this.btnPotpis);
            this.Controls.Add(this.btnNewKey);
            this.Controls.Add(this.txtMainKey);
            this.Controls.Add(this.btnReceiver);
            this.Controls.Add(this.btnSender);
            this.Name = "Form1";
            this.Text = "Početna forma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSender;
        private System.Windows.Forms.Button btnReceiver;
        private System.Windows.Forms.TextBox txtMainKey;
        private System.Windows.Forms.Button btnNewKey;
        private System.Windows.Forms.Button btnPotpis;
    }
}

