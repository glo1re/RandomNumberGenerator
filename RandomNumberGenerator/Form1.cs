namespace RandomNumberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random(); 
            int sayi = rastgele.Next(0,100);
            label2.Text = sayi.ToString();
        }
    }
}
