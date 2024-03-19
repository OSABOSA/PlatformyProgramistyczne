using PlatformyProgramistyczne.Lab1;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string liczbaPrzedmiotow = textBox1.Text;
            string pojemnoscPlecaka = textBox2.Text;
            string seed = textBox3.Text;
            string wynik = textBox4.Text;
            string dane = textBox5.Text;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int liczbaPrzedmiotow);
            int.TryParse(textBox2.Text, out int pojemnoscPlecaka);
            int.TryParse(textBox3.Text, out int seed);
            Plecak plecak = new Plecak(liczbaPrzedmiotow, seed);
            Result result = plecak.Solve(pojemnoscPlecaka);
            textBox4.Text = plecak.ToString();
            textBox5.Text = result.ToString() + "\n" ;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
