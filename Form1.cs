namespace TZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Ôאיכ הכÿ ÒÇ|input.txt";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                string[] stroki = File.ReadAllLines(openFileDialog1.FileName);
                foreach (string stroka in stroki)
                {
                    if (!string.IsNullOrWhiteSpace(stroka))
                    {
                        textBox1.Text = stroka;
                        break;
                    }
                }
            }
        }
    }
}