namespace WinFormsApp12
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Utilizador.usuario = Convert.ToString(textBox1.Text);
            Utilizador.passe = Convert.ToString(textBox2.Text);
            Utilizador.email = Convert.ToString(textBox3.Text);
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            MessageBox.Show("As informações foram salvas!");

        }
    }
    static class Utilizador
    {
        public static string usuario;
        public static string passe;
        public static string email;
    }

}