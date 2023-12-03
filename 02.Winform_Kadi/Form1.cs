namespace _02.Winform_Kadi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {

            // karar yapýsý ?
            if (textBox1.Text == "apolex" && textBox2.Text == "1234")
            {

                // MessageBox.Show("tebrikler kullanýcý adý v eþifreniz dogru");
                // MessageBox.Show("tebrikler kullanýcý adý v eþifreniz dogru","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                // MessageBox.Show("tebrikler kullanýcý adý v eþifreniz dogru","UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                MessageBox.Show("tebrikler kullanýcý adý v eþifreniz dogru", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Yanlýþ bilgi girdiniz ");
            }
        }
    }
}