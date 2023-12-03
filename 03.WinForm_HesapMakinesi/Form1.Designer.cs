namespace _03.WinForm_HesapMakinesi
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            btnTop = new Button();
            btnCıkar = new Button();
            btnCarp = new Button();
            btnBolme = new Button();
            lblSonuc = new Label();
            label5 = new Label();
            label4 = new Label();
            lblYuzde = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(160, 23);
            label1.Name = "label1";
            label1.Size = new Size(289, 37);
            label1.TabIndex = 0;
            label1.Text = "Basit Hesap Makinesi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.GhostWhite;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(108, 101);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 1;
            label2.Text = "1.Sayi :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(195, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.GhostWhite;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(108, 164);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 1;
            label3.Text = "2.Sayi :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(195, 161);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 23);
            textBox2.TabIndex = 2;
            // 
            // btnTop
            // 
            btnTop.Location = new Point(73, 213);
            btnTop.Name = "btnTop";
            btnTop.Size = new Size(80, 40);
            btnTop.TabIndex = 3;
            btnTop.Text = "Toplama";
            btnTop.UseVisualStyleBackColor = true;
            btnTop.Click += btnTop_Click;
            // 
            // btnCıkar
            // 
            btnCıkar.Location = new Point(178, 213);
            btnCıkar.Name = "btnCıkar";
            btnCıkar.Size = new Size(80, 40);
            btnCıkar.TabIndex = 4;
            btnCıkar.Text = "Cıkarma";
            btnCıkar.UseVisualStyleBackColor = true;
            btnCıkar.Click += btnCıkar_Click;
            // 
            // btnCarp
            // 
            btnCarp.Location = new Point(280, 213);
            btnCarp.Name = "btnCarp";
            btnCarp.Size = new Size(80, 40);
            btnCarp.TabIndex = 5;
            btnCarp.Text = "Carpma";
            btnCarp.UseVisualStyleBackColor = true;
            btnCarp.Click += btnCarp_Click;
            // 
            // btnBolme
            // 
            btnBolme.Location = new Point(379, 213);
            btnBolme.Name = "btnBolme";
            btnBolme.Size = new Size(80, 40);
            btnBolme.TabIndex = 6;
            btnBolme.Text = "Bölme";
            btnBolme.UseVisualStyleBackColor = true;
            btnBolme.Click += btnBolme_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(195, 301);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(31, 15);
            lblSonuc.TabIndex = 7;
            lblSonuc.Text = "........";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(108, 301);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 7;
            label5.Text = "Sonuc:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(588, 166);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 8;
            label4.Text = "Sayı Yüzdesi";
            // 
            // lblYuzde
            // 
            lblYuzde.AutoSize = true;
            lblYuzde.Location = new Point(588, 213);
            lblYuzde.Name = "lblYuzde";
            lblYuzde.Size = new Size(22, 15);
            lblYuzde.TabIndex = 8;
            lblYuzde.Text = ".....";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(lblYuzde);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(lblSonuc);
            Controls.Add(btnBolme);
            Controls.Add(btnCarp);
            Controls.Add(btnCıkar);
            Controls.Add(btnTop);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Button btnTop;
        private Button btnCıkar;
        private Button btnCarp;
        private Button btnBolme;
        private Label lblSonuc;
        private Label label5;
        private Label label4;
        private Label lblYuzde;
    }
}