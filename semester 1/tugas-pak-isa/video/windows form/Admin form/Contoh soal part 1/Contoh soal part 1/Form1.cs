using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contoh_soal_part_1
{
    public partial class Form1Login : Form
    {
        public Form1Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3Dasboard dasboard = new Form3Dasboard();
            this.Hide();
            dasboard.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form2register register = new Form2register();
            this.Hide();
            register.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
