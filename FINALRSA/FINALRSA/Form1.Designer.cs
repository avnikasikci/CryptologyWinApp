namespace FINALRSA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSenerioVigenere = new System.Windows.Forms.Button();
            this.btnSenerio1 = new System.Windows.Forms.Button();
            this.btnSenerioWinFrom = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelLayout = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLayout.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSenerioVigenere
            // 
            this.btnSenerioVigenere.FlatAppearance.BorderSize = 0;
            this.btnSenerioVigenere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSenerioVigenere.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSenerioVigenere.ForeColor = System.Drawing.Color.White;
            this.btnSenerioVigenere.Image = ((System.Drawing.Image)(resources.GetObject("btnSenerioVigenere.Image")));
            this.btnSenerioVigenere.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSenerioVigenere.Location = new System.Drawing.Point(13, 532);
            this.btnSenerioVigenere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSenerioVigenere.Name = "btnSenerioVigenere";
            this.btnSenerioVigenere.Size = new System.Drawing.Size(296, 82);
            this.btnSenerioVigenere.TabIndex = 4;
            this.btnSenerioVigenere.Text = "   VigenereCipher";
            this.btnSenerioVigenere.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSenerioVigenere.UseVisualStyleBackColor = true;
            this.btnSenerioVigenere.Click += new System.EventHandler(this.btnSenerioVigenere_Click);
            // 
            // btnSenerio1
            // 
            this.btnSenerio1.FlatAppearance.BorderSize = 0;
            this.btnSenerio1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSenerio1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSenerio1.ForeColor = System.Drawing.Color.White;
            this.btnSenerio1.Image = ((System.Drawing.Image)(resources.GetObject("btnSenerio1.Image")));
            this.btnSenerio1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSenerio1.Location = new System.Drawing.Point(13, 450);
            this.btnSenerio1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSenerio1.Name = "btnSenerio1";
            this.btnSenerio1.Size = new System.Drawing.Size(296, 82);
            this.btnSenerio1.TabIndex = 4;
            this.btnSenerio1.Text = "    Alicenin Mesajı";
            this.btnSenerio1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSenerio1.UseVisualStyleBackColor = true;
            this.btnSenerio1.Click += new System.EventHandler(this.btnSenerio1_Click);
            // 
            // btnSenerioWinFrom
            // 
            this.btnSenerioWinFrom.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.btnSenerioWinFrom.FlatAppearance.BorderSize = 0;
            this.btnSenerioWinFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSenerioWinFrom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSenerioWinFrom.ForeColor = System.Drawing.Color.White;
            this.btnSenerioWinFrom.Image = ((System.Drawing.Image)(resources.GetObject("btnSenerioWinFrom.Image")));
            this.btnSenerioWinFrom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSenerioWinFrom.Location = new System.Drawing.Point(13, 366);
            this.btnSenerioWinFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSenerioWinFrom.Name = "btnSenerioWinFrom";
            this.btnSenerioWinFrom.Size = new System.Drawing.Size(296, 82);
            this.btnSenerioWinFrom.TabIndex = 4;
            this.btnSenerioWinFrom.Text = "     Email Link";
            this.btnSenerioWinFrom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSenerioWinFrom.UseVisualStyleBackColor = true;
            this.btnSenerioWinFrom.Click += new System.EventHandler(this.btnSenerioWinFrom_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1468, 19);
            this.panel2.TabIndex = 6;
            // 
            // panelLayout
            // 
            this.panelLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelLayout.Controls.Add(this.btnSenerioVigenere);
            this.panelLayout.Controls.Add(this.btnSenerio1);
            this.panelLayout.Controls.Add(this.btnSenerioWinFrom);
            this.panelLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLayout.Location = new System.Drawing.Point(0, 0);
            this.panelLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLayout.Name = "panelLayout";
            this.panelLayout.Size = new System.Drawing.Size(300, 1070);
            this.panelLayout.TabIndex = 5;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Location = new System.Drawing.Point(307, 27);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1450, 1031);
            this.panelContent.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(403, 338);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(837, 63);
            this.label1.TabIndex = 9;
            this.label1.Text = "Necmettin Erbakan Üniversitresi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(613, 446);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kriptoloji Final Bonus Ödevi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1768, 1070);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLayout);
            this.Name = "Form1";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLayout.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSenerioVigenere;
        private System.Windows.Forms.Button btnSenerio1;
        private System.Windows.Forms.Button btnSenerioWinFrom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelLayout;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

