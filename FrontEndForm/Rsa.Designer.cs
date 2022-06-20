namespace FrontEndForm
{
    partial class RSASignature
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.signatureText = new System.Windows.Forms.TextBox();
            this.signatureCheckText = new System.Windows.Forms.TextBox();
            this.signatureHashText = new System.Windows.Forms.TextBox();
            this.signatureCheckHashText = new System.Windows.Forms.TextBox();
            this.hashButton = new System.Windows.Forms.Button();
            this.generateKeysButton = new System.Windows.Forms.Button();
            this.verifySignatureButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.public_e = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.public_n = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.private_q = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.private_p = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.private_inverse_q = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.private_d = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.private_dq = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.private_dp = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.private_n = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.private_e = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.verifySignatureResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signatureText
            // 
            this.signatureText.Location = new System.Drawing.Point(62, 76);
            this.signatureText.Name = "signatureText";
            this.signatureText.Size = new System.Drawing.Size(125, 27);
            this.signatureText.TabIndex = 0;
            this.signatureText.Text = "kot";
            // 
            // signatureCheckText
            // 
            this.signatureCheckText.Location = new System.Drawing.Point(62, 155);
            this.signatureCheckText.Name = "signatureCheckText";
            this.signatureCheckText.Size = new System.Drawing.Size(125, 27);
            this.signatureCheckText.TabIndex = 1;
            this.signatureCheckText.Text = "kot";
            // 
            // signatureHashText
            // 
            this.signatureHashText.Location = new System.Drawing.Point(236, 76);
            this.signatureHashText.Name = "signatureHashText";
            this.signatureHashText.Size = new System.Drawing.Size(534, 27);
            this.signatureHashText.TabIndex = 4;
            // 
            // signatureCheckHashText
            // 
            this.signatureCheckHashText.Location = new System.Drawing.Point(236, 155);
            this.signatureCheckHashText.Name = "signatureCheckHashText";
            this.signatureCheckHashText.Size = new System.Drawing.Size(534, 27);
            this.signatureCheckHashText.TabIndex = 5;
            // 
            // hashButton
            // 
            this.hashButton.Location = new System.Drawing.Point(62, 203);
            this.hashButton.Name = "hashButton";
            this.hashButton.Size = new System.Drawing.Size(125, 29);
            this.hashButton.TabIndex = 6;
            this.hashButton.Text = "hash signature";
            this.hashButton.UseVisualStyleBackColor = true;
            this.hashButton.Click += new System.EventHandler(this.HashButton_Click);
            // 
            // generateKeysButton
            // 
            this.generateKeysButton.Location = new System.Drawing.Point(236, 203);
            this.generateKeysButton.Name = "generateKeysButton";
            this.generateKeysButton.Size = new System.Drawing.Size(170, 29);
            this.generateKeysButton.TabIndex = 7;
            this.generateKeysButton.Text = "generate RSA keys";
            this.generateKeysButton.UseVisualStyleBackColor = true;
            this.generateKeysButton.Click += new System.EventHandler(this.GenerateKeysButton_Click);
            // 
            // verifySignatureButton
            // 
            this.verifySignatureButton.Location = new System.Drawing.Point(59, 486);
            this.verifySignatureButton.Name = "verifySignatureButton";
            this.verifySignatureButton.Size = new System.Drawing.Size(128, 29);
            this.verifySignatureButton.TabIndex = 8;
            this.verifySignatureButton.Text = "verify signature";
            this.verifySignatureButton.UseVisualStyleBackColor = true;
            this.verifySignatureButton.Click += new System.EventHandler(this.VerifySignatureButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "signature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "signature check";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "hashed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "hashed";
            // 
            // public_e
            // 
            this.public_e.Location = new System.Drawing.Point(62, 318);
            this.public_e.Name = "public_e";
            this.public_e.Size = new System.Drawing.Size(125, 27);
            this.public_e.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "public key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "exponent";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "modulus";
            // 
            // public_n
            // 
            this.public_n.Location = new System.Drawing.Point(62, 397);
            this.public_n.Name = "public_n";
            this.public_n.Size = new System.Drawing.Size(125, 27);
            this.public_n.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "q";
            // 
            // private_q
            // 
            this.private_q.Location = new System.Drawing.Point(367, 397);
            this.private_q.Name = "private_q";
            this.private_q.Size = new System.Drawing.Size(125, 27);
            this.private_q.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "p";
            // 
            // private_p
            // 
            this.private_p.Location = new System.Drawing.Point(367, 318);
            this.private_p.Name = "private_p";
            this.private_p.Size = new System.Drawing.Size(125, 27);
            this.private_p.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(367, 522);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "inverse q";
            // 
            // private_inverse_q
            // 
            this.private_inverse_q.Location = new System.Drawing.Point(367, 556);
            this.private_inverse_q.Name = "private_inverse_q";
            this.private_inverse_q.Size = new System.Drawing.Size(125, 27);
            this.private_inverse_q.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(367, 443);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "d";
            // 
            // private_d
            // 
            this.private_d.Location = new System.Drawing.Point(367, 477);
            this.private_d.Name = "private_d";
            this.private_d.Size = new System.Drawing.Size(125, 27);
            this.private_d.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(207, 522);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 20);
            this.label12.TabIndex = 33;
            this.label12.Text = "dq";
            // 
            // private_dq
            // 
            this.private_dq.Location = new System.Drawing.Point(207, 556);
            this.private_dq.Name = "private_dq";
            this.private_dq.Size = new System.Drawing.Size(125, 27);
            this.private_dq.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(207, 443);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "dp";
            // 
            // private_dp
            // 
            this.private_dp.Location = new System.Drawing.Point(207, 477);
            this.private_dp.Name = "private_dp";
            this.private_dp.Size = new System.Drawing.Size(125, 27);
            this.private_dp.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(207, 363);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "modulus";
            // 
            // private_n
            // 
            this.private_n.Location = new System.Drawing.Point(207, 397);
            this.private_n.Name = "private_n";
            this.private_n.Size = new System.Drawing.Size(125, 27);
            this.private_n.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(207, 284);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "exponent";
            // 
            // private_e
            // 
            this.private_e.Location = new System.Drawing.Point(207, 318);
            this.private_e.Name = "private_e";
            this.private_e.Size = new System.Drawing.Size(125, 27);
            this.private_e.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(308, 251);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "private key";
            // 
            // verifySignatureResultLabel
            // 
            this.verifySignatureResultLabel.AutoSize = true;
            this.verifySignatureResultLabel.Location = new System.Drawing.Point(59, 543);
            this.verifySignatureResultLabel.Name = "verifySignatureResultLabel";
            this.verifySignatureResultLabel.Size = new System.Drawing.Size(119, 20);
            this.verifySignatureResultLabel.TabIndex = 35;
            this.verifySignatureResultLabel.Text = "hash verify result";
            // 
            // RSASignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 672);
            this.Controls.Add(this.verifySignatureResultLabel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.private_dq);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.private_dp);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.private_n);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.private_e);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.private_inverse_q);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.private_d);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.private_q);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.private_p);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.public_n);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.public_e);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verifySignatureButton);
            this.Controls.Add(this.generateKeysButton);
            this.Controls.Add(this.hashButton);
            this.Controls.Add(this.signatureCheckHashText);
            this.Controls.Add(this.signatureHashText);
            this.Controls.Add(this.signatureCheckText);
            this.Controls.Add(this.signatureText);
            this.Name = "RSASignature";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox signatureText;
        private TextBox signatureCheckText;
        private TextBox signatureHashText;
        private TextBox signatureCheckHashText;
        private Button hashButton;
        private Button generateKeysButton;
        private Button verifySignatureButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox public_e;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox public_n;
        private Label label8;
        private TextBox private_q;
        private Label label9;
        private TextBox private_p;
        private Label label10;
        private TextBox private_inverse_q;
        private Label label11;
        private TextBox private_d;
        private Label label12;
        private TextBox private_dq;
        private Label label13;
        private TextBox private_dp;
        private Label label14;
        private TextBox private_n;
        private Label label15;
        private TextBox private_e;
        private Label label16;
        private Label verifySignatureResultLabel;
    }
}