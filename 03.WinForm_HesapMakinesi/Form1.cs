namespace _03.WinForm_HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
        private void btnTop_Click(object sender, EventArgs e)
        {

            double yuz = Convert.ToDouble( textBox2.Text) / Convert.ToDouble(textBox1.Text);
            lblYuzde.Text = yuz.ToString();


            //1.yol

            int sonuc = Convert.ToInt32(textBox1.Text) + int.Parse(textBox2.Text);

            lblSonuc.Text = sonuc.ToString();


            
            //2.yol
            //lblSonuc.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();



        }

        private void btnCýkar_Click(object sender, EventArgs e)
        {
            //1.yol

            int sonuc = Convert.ToInt32(textBox1.Text) - int.Parse(textBox2.Text);

            lblSonuc.Text = sonuc.ToString();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            //1.yol

            int sonuc = Convert.ToInt32(textBox1.Text) * int.Parse(textBox2.Text);

            lblSonuc.Text = sonuc.ToString();
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            //1.yol

            double sonuc = double.Parse(textBox1.Text) / double.Parse(textBox2.Text);

            lblSonuc.Text = sonuc.ToString();
        }
    }
}