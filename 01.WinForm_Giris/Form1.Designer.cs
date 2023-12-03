namespace _01.WinForm_Giris
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            lbl_ad = new Label();
            lbl_Soy = new Label();
            label1 = new Label();
            lblSonuc = new Label();
            label2 = new Label();
            label3 = new Label();
            txtKadi = new TextBox();
            textBox4 = new TextBox();
            btn_Kaydet = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(107, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(212, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(107, 23);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Location = new Point(304, 291);
            button1.MaximumSize = new Size(12, 10);
            button1.Name = "button1";
            button1.Size = new Size(12, 0);
            button1.TabIndex = 2;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            // 
            // lbl_ad
            // 
            lbl_ad.AutoSize = true;
            lbl_ad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ad.Location = new Point(94, 102);
            lbl_ad.Name = "lbl_ad";
            lbl_ad.Size = new Size(63, 21);
            lbl_ad.TabIndex = 3;
            lbl_ad.Text = "Adınız:";
            // 
            // lbl_Soy
            // 
            lbl_Soy.AutoSize = true;
            lbl_Soy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Soy.Location = new Point(94, 160);
            lbl_Soy.Name = "lbl_Soy";
            lbl_Soy.Size = new Size(89, 21);
            lbl_Soy.TabIndex = 4;
            lbl_Soy.Text = "Soyadınız:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 28);
            label1.Name = "label1";
            label1.Size = new Size(357, 28);
            label1.TabIndex = 5;
            label1.Text = "Windows Form Uygulamalarına Giriş";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSonuc.Location = new Point(94, 291);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(61, 21);
            lblSonuc.TabIndex = 6;
            lblSonuc.Text = "Sonuc:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(94, 205);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 3;
            label2.Text = "Kadi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(94, 243);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 7;
            label3.Text = "sifre:";
            // 
            // txtKadi
            // 
            txtKadi.Location = new Point(212, 202);
            txtKadi.Name = "txtKadi";
            txtKadi.Size = new Size(107, 23);
            txtKadi.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(212, 237);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(107, 23);
            textBox4.TabIndex = 1;
            // 
            // btn_Kaydet
            // 
            btn_Kaydet.Location = new Point(277, 320);
            btn_Kaydet.Name = "btn_Kaydet";
            btn_Kaydet.Size = new Size(98, 51);
            btn_Kaydet.TabIndex = 8;
            btn_Kaydet.Text = "Kaydet";
            btn_Kaydet.UseVisualStyleBackColor = true;
            btn_Kaydet.Click += btn_Kaydet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(534, 431);
            Controls.Add(btn_Kaydet);
            Controls.Add(label3);
            Controls.Add(lblSonuc);
            Controls.Add(label1);
            Controls.Add(lbl_Soy);
            Controls.Add(label2);
            Controls.Add(lbl_ad);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(txtKadi);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form Giris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label lbl_ad;
        private Label lbl_Soy;
        private Label label1;
        private Label lblSonuc;
        private Label label2;
        private Label label3;
        private TextBox txtKadi;
        private TextBox textBox4;
        private Button btn_Kaydet;
    }
}