using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Isi ComboBox Kelas
            cmbKelas.Items.Add("X RPL 1");
            cmbKelas.Items.Add("X RPL 2");
            cmbKelas.Items.Add("X RPL 3");
            cmbKelas.Items.Add("XI RPL 1");
            cmbKelas.Items.Add("XI RPL 2");
            cmbKelas.Items.Add("XII RPL 1");
            cmbKelas.Items.Add("XII RPL 2");

            // Saldo hanya bisa dilihat
            txtSaldo.ReadOnly = true;

            // Saldo awal
            txtSaldo.Text = "0";

        }

        

        private void btnMenabung_Click(object sender, EventArgs e)
        {
            // Cek NIS
            if (txtNIS.Text == "")
            {
                MessageBox.Show("NIS harus diisi!");
                txtNIS.Focus();
                return;
            }

            // Cek nama
            if (txtNama.Text == "")
            {
                MessageBox.Show("Nama siswa harus diisi!");
                txtNama.Focus();
                return;
            }

            // Cek kelas
            if (cmbKelas.SelectedIndex == -1)
            {
                MessageBox.Show("Silakan pilih kelas!");
                cmbKelas.Focus();
                return;
            }

            // Cek nominal
            if (txtNominal.Text == "")
            {
                MessageBox.Show("Nominal harus diisi!");
                txtNominal.Focus();
                return;
            }

            // Ubah nominal menjadi angka
            decimal nominal;

            if (!decimal.TryParse(txtNominal.Text, out nominal))
            {
                MessageBox.Show("Nominal harus berupa angka!");
                txtNominal.Focus();
                return;
            }

            if (nominal <= 0)
            {
                MessageBox.Show("Nominal harus lebih dari 0!");
                return;
            }

            // Ambil saldo sekarang
            decimal saldo;

            decimal.TryParse(txtSaldo.Text, out saldo);

            // Tambahkan nominal ke saldo
            saldo = saldo + nominal;

            // Tampilkan saldo baru
            txtSaldo.Text = saldo.ToString("N0");

            MessageBox.Show(
                "Berhasil menabung!\n\n" +
                "Nama : " + txtNama.Text +
                "\nNIS : " + txtNIS.Text +
                "\nKelas : " + cmbKelas.Text +
                "\nSaldo : Rp " + saldo.ToString("N0"),
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Kosongkan nominal
            txtNominal.Clear();
        }


        

        private void btnTarik_Click(object sender, EventArgs e)
        {
            // Cek nominal
            if (txtNominal.Text == "")
            {
                MessageBox.Show("Nominal harus diisi!");
                txtNominal.Focus();
                return;
            }

            // Ubah nominal menjadi angka
            decimal nominal;

            if (!decimal.TryParse(txtNominal.Text, out nominal))
            {
                MessageBox.Show("Nominal harus berupa angka!");
                txtNominal.Focus();
                return;
            }

            if (nominal <= 0)
            {
                MessageBox.Show("Nominal harus lebih dari 0!");
                return;
            }

            // Ambil saldo sekarang
            decimal saldo;

            decimal.TryParse(txtSaldo.Text, out saldo);

            // Cek saldo
            if (nominal > saldo)
            {
                MessageBox.Show(
                    "Saldo tidak mencukupi!\n\n" +
                    "Saldo saat ini : Rp " + saldo.ToString("N0"),
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Kurangi saldo
            saldo = saldo - nominal;

            // Tampilkan saldo baru
            txtSaldo.Text = saldo.ToString("N0");

            MessageBox.Show(
                "Penarikan berhasil!\n\n" +
                "Nama : " + txtNama.Text +
                "\nNIS : " + txtNIS.Text +
                "\nKelas : " + cmbKelas.Text +
                "\nSaldo : Rp " + saldo.ToString("N0"),
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Kosongkan nominal
            txtNominal.Clear();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
