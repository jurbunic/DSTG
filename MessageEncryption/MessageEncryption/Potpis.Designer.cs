namespace MessageEncryption
{
    partial class Potpis
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDigitalSimEnc = new System.Windows.Forms.TextBox();
            this.txtDigitalKey = new System.Windows.Forms.TextBox();
            this.txtDigitalEnvelope = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(635, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Potpiši";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(635, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Provjeri potpis";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 161);
            this.textBox1.TabIndex = 2;
            // 
            // txtDigitalSimEnc
            // 
            this.txtDigitalSimEnc.Location = new System.Drawing.Point(186, 30);
            this.txtDigitalSimEnc.Multiline = true;
            this.txtDigitalSimEnc.Name = "txtDigitalSimEnc";
            this.txtDigitalSimEnc.ReadOnly = true;
            this.txtDigitalSimEnc.Size = new System.Drawing.Size(148, 91);
            this.txtDigitalSimEnc.TabIndex = 6;
            // 
            // txtDigitalKey
            // 
            this.txtDigitalKey.Location = new System.Drawing.Point(186, 140);
            this.txtDigitalKey.Multiline = true;
            this.txtDigitalKey.Name = "txtDigitalKey";
            this.txtDigitalKey.ReadOnly = true;
            this.txtDigitalKey.Size = new System.Drawing.Size(148, 108);
            this.txtDigitalKey.TabIndex = 7;
            // 
            // txtDigitalEnvelope
            // 
            this.txtDigitalEnvelope.Location = new System.Drawing.Point(389, 54);
            this.txtDigitalEnvelope.Multiline = true;
            this.txtDigitalEnvelope.Name = "txtDigitalEnvelope";
            this.txtDigitalEnvelope.ReadOnly = true;
            this.txtDigitalEnvelope.Size = new System.Drawing.Size(200, 125);
            this.txtDigitalEnvelope.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Enkriptiran tekst(Simetricno)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(183, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "sažetak";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(386, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Potpisana Poruka";
            // 
            // Potpis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 290);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDigitalEnvelope);
            this.Controls.Add(this.txtDigitalKey);
            this.Controls.Add(this.txtDigitalSimEnc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Potpis";
            this.Text = "Potpis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtDigitalSimEnc;
        private System.Windows.Forms.TextBox txtDigitalKey;
        private System.Windows.Forms.TextBox txtDigitalEnvelope;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}