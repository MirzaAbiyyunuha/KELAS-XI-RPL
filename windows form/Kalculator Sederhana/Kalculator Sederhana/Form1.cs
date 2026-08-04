using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalculator_Sederhana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            int Angka1 = Convert.ToInt32(teksAngka1.Text);
            int Angka2 = Convert.ToInt32(teksAngka2.Text);

            int hasil = Angka1 + Angka2;
            lblHasil.Text = "Hasil: " + hasil;
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            int Angka1 = Convert.ToInt32(teksAngka1.Text);
            int Angka2 = Convert.ToInt32(teksAngka2.Text);

            int hasil = Angka1 - Angka2;
            lblHasil.Text = "Hasil: " + hasil;
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            int Angka1 = Convert.ToInt32(teksAngka1.Text);
            int Angka2 = Convert.ToInt32(teksAngka2.Text);

            int hasil = Angka1 * Angka2;
            lblHasil.Text = "Hasil: " + hasil;
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            int Angka1 = Convert.ToInt32(teksAngka1.Text);
            int Angka2 = Convert.ToInt32(teksAngka2.Text);

            int hasil = Angka1 / Angka2;
            lblHasil.Text = "Hasil: " + hasil;
        }
    }
}
