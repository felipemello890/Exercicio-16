using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp12
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == Utilizador.usuario))

            {
                if ((textBox3.Text == Utilizador.email))
                {
                    if ((textBox2.Text == Utilizador.passe))
                    { MessageBox.Show("Login efutuado com sucesso!"); }
                    else
                    { MessageBox.Show("Alguma informação está incorrecta!"); }
                }
                else
                { MessageBox.Show("Alguma informação está incorrecta!"); }
            }
            else
            { MessageBox.Show("Alguma informação está incorrecta!"); }
        }
    }
}
