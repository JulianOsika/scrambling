namespace Scramble
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = encryptInput.Text;
            int shift = int.Parse(encryptShift.Text);
            encryptOutput.Text = Convert.Encrypt(input, shift);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = decryptInput.Text;
            int shift = int.Parse(decryptShift.Text);
            decryptOutput.Text = Convert.Decrypt(input, shift);
        }
    }
}
