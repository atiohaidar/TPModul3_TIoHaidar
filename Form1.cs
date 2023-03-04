namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Submit";
            label1.Text = "";
            label2.Text = "Masukan Nama Anda";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String inputan = textBox1.Text;
            if (inputan == "")
            {
            label1.Text = "Anda belum memasukan apa-apa ke textbox";

            }
            label1.Text = "Halo " + inputan;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}