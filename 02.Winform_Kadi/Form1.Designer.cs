namespace _02.Winform_Kadi
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
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btn_Kaydet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(145, 28);
            label1.Name = "label1";
            label1.Size = new Size(409, 37);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı  Adı ve Şifre işlemleri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(43, 136);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 1;
            label2.Text = "Kullanici adi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(98, 171);
            label3.Name = "label3";
            label3.Size = new Size(61, 28);
            label3.TabIndex = 1;
            label3.Text = "Sifre:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(183, 176);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(154, 23);
            textBox2.TabIndex = 2;
            // 
            // btn_Kaydet
            // 
            btn_Kaydet.Location = new Point(251, 233);
            btn_Kaydet.Name = "btn_Kaydet";
            btn_Kaydet.Size = new Size(86, 50);
            btn_Kaydet.TabIndex = 3;
            btn_Kaydet.Text = "Kaydet";
            btn_Kaydet.UseVisualStyleBackColor = true;
            btn_Kaydet.Click += btn_Kaydet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(851, 472);
            Controls.Add(btn_Kaydet);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btn_Kaydet;
    }
}