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

            // karar yap�s� ?
            if (textBox1.Text == "apolex" && textBox2.Text == "1234")
            {

                // MessageBox.Show("tebrikler kullan�c� ad� v e�ifreniz dogru");
                // MessageBox.Show("tebrikler kullan�c� ad� v e�ifreniz dogru","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                // MessageBox.Show("tebrikler kullan�c� ad� v e�ifreniz dogru","UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                MessageBox.Show("tebrikler kullan�c� ad� v e�ifreniz dogru", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Yanl�� bilgi girdiniz ");
            }
        }
    }
}