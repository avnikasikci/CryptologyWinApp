namespace FINALRSA
{
    partial class UCESignatureSenerioController
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCESignatureSenerioController));
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnCreateKeys = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDecryptOutContent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEncryptOutContent = new System.Windows.Forms.TextBox();
            this.txtDecryptInputContent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEncryptInputContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrimerNumber1 = new System.Windows.Forms.TextBox();
            this.txtPrimerNumber2 = new System.Windows.Forms.TextBox();
            this.CreatePrimerNumbers = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(1102, 351);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 27);
            this.label8.TabIndex = 79;
            this.label8.Text = "Decrypt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(156, 351);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 27);
            this.label7.TabIndex = 78;
            this.label7.Text = "Encrypt";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnDecrypt.ForeColor = System.Drawing.Color.White;
            this.btnDecrypt.Image = ((System.Drawing.Image)(resources.GetObject("btnDecrypt.Image")));
            this.btnDecrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecrypt.Location = new System.Drawing.Point(1049, 670);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(6);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(176, 58);
            this.btnDecrypt.TabIndex = 76;
            this.btnDecrypt.Text = "Metni Çöz";
            this.btnDecrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.Image = ((System.Drawing.Image)(resources.GetObject("btnEncrypt.Image")));
            this.btnEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncrypt.Location = new System.Drawing.Point(161, 615);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(6);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(130, 58);
            this.btnEncrypt.TabIndex = 75;
            this.btnEncrypt.Text = "Şifrele";
            this.btnEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnCreateKeys
            // 
            this.btnCreateKeys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnCreateKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateKeys.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnCreateKeys.ForeColor = System.Drawing.Color.White;
            this.btnCreateKeys.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateKeys.Image")));
            this.btnCreateKeys.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateKeys.Location = new System.Drawing.Point(587, 231);
            this.btnCreateKeys.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreateKeys.Name = "btnCreateKeys";
            this.btnCreateKeys.Size = new System.Drawing.Size(158, 86);
            this.btnCreateKeys.TabIndex = 73;
            this.btnCreateKeys.Text = "Anahtar Oluştur";
            this.btnCreateKeys.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateKeys.UseVisualStyleBackColor = false;
            this.btnCreateKeys.Click += new System.EventHandler(this.btnCreateKeys_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(913, 754);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 27);
            this.label6.TabIndex = 72;
            this.label6.Text = "Açık Mesaj";
            // 
            // txtDecryptOutContent
            // 
            this.txtDecryptOutContent.Location = new System.Drawing.Point(913, 814);
            this.txtDecryptOutContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDecryptOutContent.Multiline = true;
            this.txtDecryptOutContent.Name = "txtDecryptOutContent";
            this.txtDecryptOutContent.Size = new System.Drawing.Size(416, 63);
            this.txtDecryptOutContent.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(37, 745);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 27);
            this.label4.TabIndex = 70;
            this.label4.Text = "Şifreli Mesaj";
            // 
            // txtEncryptOutContent
            // 
            this.txtEncryptOutContent.Location = new System.Drawing.Point(41, 805);
            this.txtEncryptOutContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEncryptOutContent.Multiline = true;
            this.txtEncryptOutContent.Name = "txtEncryptOutContent";
            this.txtEncryptOutContent.Size = new System.Drawing.Size(377, 122);
            this.txtEncryptOutContent.TabIndex = 69;
            // 
            // txtDecryptInputContent
            // 
            this.txtDecryptInputContent.Location = new System.Drawing.Point(918, 504);
            this.txtDecryptInputContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDecryptInputContent.Multiline = true;
            this.txtDecryptInputContent.Name = "txtDecryptInputContent";
            this.txtDecryptInputContent.Size = new System.Drawing.Size(411, 136);
            this.txtDecryptInputContent.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(913, 418);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 27);
            this.label3.TabIndex = 67;
            this.label3.Text = "Şifrelenmiş Mesaj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(27, 409);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 27);
            this.label2.TabIndex = 66;
            this.label2.Text = "Mesaj";
            // 
            // txtEncryptInputContent
            // 
            this.txtEncryptInputContent.Location = new System.Drawing.Point(22, 495);
            this.txtEncryptInputContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEncryptInputContent.Multiline = true;
            this.txtEncryptInputContent.Name = "txtEncryptInputContent";
            this.txtEncryptInputContent.Size = new System.Drawing.Size(396, 62);
            this.txtEncryptInputContent.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(913, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 27);
            this.label1.TabIndex = 64;
            this.label1.Text = "Private Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(17, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 27);
            this.label5.TabIndex = 63;
            this.label5.Text = "Public Key";
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(918, 195);
            this.txtPrivateKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(411, 122);
            this.txtPrivateKey.TabIndex = 62;
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(22, 195);
            this.txtPublicKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(396, 122);
            this.txtPublicKey.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(94, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 27);
            this.label9.TabIndex = 80;
            this.label9.Text = "Asal Sayı1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.Location = new System.Drawing.Point(913, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 27);
            this.label10.TabIndex = 81;
            this.label10.Text = "Asal Sayı2";
            // 
            // txtPrimerNumber1
            // 
            this.txtPrimerNumber1.Location = new System.Drawing.Point(310, 41);
            this.txtPrimerNumber1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrimerNumber1.Name = "txtPrimerNumber1";
            this.txtPrimerNumber1.Size = new System.Drawing.Size(100, 26);
            this.txtPrimerNumber1.TabIndex = 83;
            // 
            // txtPrimerNumber2
            // 
            this.txtPrimerNumber2.Location = new System.Drawing.Point(1105, 36);
            this.txtPrimerNumber2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrimerNumber2.Name = "txtPrimerNumber2";
            this.txtPrimerNumber2.Size = new System.Drawing.Size(100, 26);
            this.txtPrimerNumber2.TabIndex = 84;
            // 
            // CreatePrimerNumbers
            // 
            this.CreatePrimerNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.CreatePrimerNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrimerNumbers.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.CreatePrimerNumbers.ForeColor = System.Drawing.Color.White;
            this.CreatePrimerNumbers.Image = ((System.Drawing.Image)(resources.GetObject("CreatePrimerNumbers.Image")));
            this.CreatePrimerNumbers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreatePrimerNumbers.Location = new System.Drawing.Point(587, 35);
            this.CreatePrimerNumbers.Margin = new System.Windows.Forms.Padding(6);
            this.CreatePrimerNumbers.Name = "CreatePrimerNumbers";
            this.CreatePrimerNumbers.Size = new System.Drawing.Size(158, 86);
            this.CreatePrimerNumbers.TabIndex = 85;
            this.CreatePrimerNumbers.Text = "Random Üret";
            this.CreatePrimerNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreatePrimerNumbers.UseVisualStyleBackColor = false;
            this.CreatePrimerNumbers.Click += new System.EventHandler(this.CreatePrimerNumbers_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // UCESignatureSenerioController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.CreatePrimerNumbers);
            this.Controls.Add(this.txtPrimerNumber2);
            this.Controls.Add(this.txtPrimerNumber1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnCreateKeys);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDecryptOutContent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEncryptOutContent);
            this.Controls.Add(this.txtDecryptInputContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEncryptInputContent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.txtPublicKey);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCESignatureSenerioController";
            this.Size = new System.Drawing.Size(1450, 1031);
            this.Load += new System.EventHandler(this.UCESignatureSenerioController_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnCreateKeys;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDecryptOutContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEncryptOutContent;
        private System.Windows.Forms.TextBox txtDecryptInputContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEncryptInputContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrimerNumber1;
        private System.Windows.Forms.TextBox txtPrimerNumber2;
        private System.Windows.Forms.Button CreatePrimerNumbers;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
