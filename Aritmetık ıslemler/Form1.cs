namespace Aritmetık_ıslemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam, cıkarma, carp, bol;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            toplam = sayi1 + sayi2;
            cıkarma = sayi1 - sayi2;
            carp = sayi1 * sayi2;
            bol = sayi1 / sayi2;
            MessageBox.Show("Toplam: " + toplam + "\n" + "Cıkarma: " + cıkarma + "\n" + "Bolme: " + bol + "\n" + "Carpma: " + carp);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}