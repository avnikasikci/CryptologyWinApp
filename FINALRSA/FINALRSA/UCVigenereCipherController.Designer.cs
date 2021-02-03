namespace FINALRSA
{
    partial class UCVigenereCipherController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCVigenereCipherController));
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDecryptOutContent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEncryptOutContent = new System.Windows.Forms.TextBox();
            this.txtDecryptInputContent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEncryptInputContent = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(1111, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 27);
            this.label8.TabIndex = 108;
            this.label8.Text = "Decrypt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(165, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 27);
            this.label7.TabIndex = 107;
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
            this.btnDecrypt.Location = new System.Drawing.Point(1058, 460);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(6);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(176, 58);
            this.btnDecrypt.TabIndex = 106;
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
            this.btnEncrypt.Location = new System.Drawing.Point(170, 405);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(6);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(130, 58);
            this.btnEncrypt.TabIndex = 105;
            this.btnEncrypt.Text = "Şifrele";
            this.btnEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(922, 544);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 27);
            this.label6.TabIndex = 102;
            this.label6.Text = "Açık Mesaj";
            // 
            // txtDecryptOutContent
            // 
            this.txtDecryptOutContent.Location = new System.Drawing.Point(922, 604);
            this.txtDecryptOutContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDecryptOutContent.Multiline = true;
            this.txtDecryptOutContent.Name = "txtDecryptOutContent";
            this.txtDecryptOutContent.Size = new System.Drawing.Size(416, 63);
            this.txtDecryptOutContent.TabIndex = 101;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(46, 535);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 27);
            this.label4.TabIndex = 100;
            this.label4.Text = "Şifreli Mesaj";
            // 
            // txtEncryptOutContent
            // 
            this.txtEncryptOutContent.Location = new System.Drawing.Point(50, 595);
            this.txtEncryptOutContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEncryptOutContent.Multiline = true;
            this.txtEncryptOutContent.Name = "txtEncryptOutContent";
            this.txtEncryptOutContent.Size = new System.Drawing.Size(377, 122);
            this.txtEncryptOutContent.TabIndex = 99;
            // 
            // txtDecryptInputContent
            // 
            this.txtDecryptInputContent.Location = new System.Drawing.Point(927, 294);
            this.txtDecryptInputContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDecryptInputContent.Multiline = true;
            this.txtDecryptInputContent.Name = "txtDecryptInputContent";
            this.txtDecryptInputContent.Size = new System.Drawing.Size(411, 136);
            this.txtDecryptInputContent.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(922, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 27);
            this.label3.TabIndex = 97;
            this.label3.Text = "Şifrelenmiş Mesaj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(36, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 27);
            this.label2.TabIndex = 96;
            this.label2.Text = "Mesaj";
            // 
            // txtEncryptInputContent
            // 
            this.txtEncryptInputContent.Location = new System.Drawing.Point(31, 285);
            this.txtEncryptInputContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEncryptInputContent.Multiline = true;
            this.txtEncryptInputContent.Name = "txtEncryptInputContent";
            this.txtEncryptInputContent.Size = new System.Drawing.Size(396, 62);
            this.txtEncryptInputContent.TabIndex = 95;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(475, 106);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(396, 62);
            this.txtKey.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(611, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 27);
            this.label1.TabIndex = 119;
            this.label1.Text = "Anahtar";
            // 
            // UCVigenereCipherController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDecryptOutContent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEncryptOutContent);
            this.Controls.Add(this.txtDecryptInputContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEncryptInputContent);
            this.Name = "UCVigenereCipherController";
            this.Size = new System.Drawing.Size(1450, 1031);
            this.Load += new System.EventHandler(this.VigenereCipherController_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDecryptOutContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEncryptOutContent;
        private System.Windows.Forms.TextBox txtDecryptInputContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEncryptInputContent;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label1;
    }
}
