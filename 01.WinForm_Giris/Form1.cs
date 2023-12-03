namespace _01.WinForm_Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = textBox1.Text + " " + textBox2.Text;

        }
    }
}