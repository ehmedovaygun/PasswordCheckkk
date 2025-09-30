namespace EmailCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = password.Text;

            if (pass.Length < 8)
            {
                MessageBox.Show("Sifre 8 simvol olmalidir.");
                return;
            }

            if (!pass.Any(char.IsUpper))
            {
                MessageBox.Show("Sifrede boyuk herf olmalidir (A-Z).");
                return;
            }

            if (!pass.Any(char.IsLower))
            {
                MessageBox.Show("Sifrede kicik herf olmalidir (a-z).");
                return;
            }

            if (!pass.Any(char.IsDigit))
            {
                MessageBox.Show("Sifrede reqem olmalidir (0-9).");
                return;
            }

            if (!(pass.Contains("@") || pass.Contains("#") || pass.Contains("$")
                || pass.Contains("%") || pass.Contains("!") || pass.Contains("*")))
            {
                MessageBox.Show("Sifrede xususi herfler olmalidir (@, #, $, %, !, *).");
                return;
            }

            if (pass.Contains("123") || pass.Contains("abc"))
            {
                MessageBox.Show("Sifrede ardicil simvollar (123, abc) olmamalidir.");
                return;
            }

            MessageBox.Show("Sifre duzgundur!");
        }

    }
}
