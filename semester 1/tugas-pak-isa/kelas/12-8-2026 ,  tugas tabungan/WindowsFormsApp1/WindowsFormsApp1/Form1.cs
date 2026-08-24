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
            Dictionary<string, DataTabungan> dataSiswa = new Dictionary<string, DataTabungan>();

            public class DataTabungan
            {
                public string Nama { get; set; }
                public string Kelas { get; set; }
                public decimal Saldo { get; set; }
            }
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
            string nis = txtNIS.Text.Trim();

            if (nis == "")
            {
                MessageBox.Show("NIS harus diisi!");
                return;
            }

            if (txtNama.Text.Trim() == "")
            {
                MessageBox.Show("Nama siswa harus diisi!");
                return;
            }

            if (cmbKelas.SelectedIndex == -1)
            {
                MessageBox.Show("Silakan pilih kelas!");
                return;
            }

            decimal nominal;

            if (!decimal.TryParse(txtNominal.Text, out nominal) || nominal <= 0)
            {
                MessageBox.Show("Nominal harus berupa angka dan lebih dari 0!");
                return;
            }

            // Kalau NIS sudah ada
            if (dataSiswa.ContainsKey(nis))
            {
                DataTabungan data = dataSiswa[nis];

                // Tambahkan ke saldo yang tersimpan
                data.Saldo += nominal;

                // Update nama dan kelas
                data.Nama = txtNama.Text;
                data.Kelas = cmbKelas.Text;

                // Simpan kembali
                dataSiswa[nis] = data;

                txtSaldo.Text = data.Saldo.ToString("N0");
            }
            else
            {
                // Buat data baru
                DataTabungan dataBaru = new DataTabungan();

                dataBaru.Nama = txtNama.Text;
                dataBaru.Kelas = cmbKelas.Text;
                dataBaru.Saldo = nominal;

                dataSiswa.Add(nis, dataBaru);

                txtSaldo.Text = nominal.ToString("N0");
            }

            MessageBox.Show(
                "Berhasil menabung!\n\n" +
                "NIS : " + nis +
                "\nNama : " + txtNama.Text +
                "\nKelas : " + cmbKelas.Text +
                "\nSaldo terbaru : Rp " + txtSaldo.Text
            );

            txtNominal.Clear();
        }




        private void btnTarik_Click(object sender, EventArgs e)
        {
            
            string nis = txtNIS.Text.Trim();

            if (nis == "")
            {
                MessageBox.Show("NIS harus diisi!");
                return;
            }

            // WAJIB cari data dari Dictionary
            if (!dataSiswa.ContainsKey(nis))
            {
                MessageBox.Show("NIS belum terdaftar!");
                return;
            }

            decimal nominal;

            if (!decimal.TryParse(txtNominal.Text, out nominal) || nominal <= 0)
            {
                MessageBox.Show("Nominal penarikan tidak valid!");
                return;
            }

            // AMBIL DATA ASLI DARI DICTIONARY
            DataTabungan data = dataSiswa[nis];

            // AMBIL SALDO ASLI
            decimal saldoLama = data.Saldo;

            if (nominal > saldoLama)
            {
                MessageBox.Show(
                    "Saldo tidak mencukupi!\n\n" +
                    "Saldo saat ini : Rp " + saldoLama.ToString("N0")
                );

                return;
            }

            // HITUNG SALDO BARU
            decimal saldoBaru = saldoLama - nominal;

            // SIMPAN SALDO BARU KE DATA
            data.Saldo = saldoBaru;

            // UPDATE DICTIONARY
            dataSiswa[nis] = data;

            // TAMPILKAN SALDO BARU
            txtSaldo.Text = saldoBaru.ToString("N0");

            MessageBox.Show(
                "Penarikan berhasil!\n\n" +
                "NIS : " + nis +
                "\nNama : " + data.Nama +
                "\nKelas : " + data.Kelas +
                "\nDitarik : Rp " + nominal.ToString("N0") +
                "\n\nSaldo lama : Rp " + saldoLama.ToString("N0") +
                "\nSaldo terbaru : Rp " + saldoBaru.ToString("N0"),
                "Penarikan Berhasil",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            txtNominal.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
            {
                txtNIS.Text = "";
                txtNama.Text = "";
                cmbKelas.SelectedIndex = -1;
                txtNominal.Text = "";
                txtSaldo.Text = "0";

                txtNIS.Focus();

                MessageBox.Show("Form berhasil direset!", "Reset",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }


        private void btnCari_Click(object sender, EventArgs e)
        {
            string nis = txtCari.Text.Trim();

            if (nis == "")
            {
                MessageBox.Show("Masukkan NIS!");
                txtCari.Focus();
                return;
            }

            if (!dataSiswa.ContainsKey(nis))
            {
                MessageBox.Show(
                    "Data dengan NIS " + nis + " tidak ditemukan!"
                );
                return;
            }

            // AMBIL DATA TERBARU DARI DICTIONARY
            DataTabungan data = dataSiswa[nis];

            txtNIS.Text = nis;
            txtNama.Text = data.Nama;
            cmbKelas.Text = data.Kelas;

            // SALDO DIAMBIL DARI DATA TERBARU
            txtSaldo.Text = data.Saldo.ToString("N0");

            MessageBox.Show(
                "Data ditemukan!\n\n" +
                "NIS : " + nis +
                "\nNama : " + data.Nama +
                "\nKelas : " + data.Kelas +
                "\nSaldo terbaru : Rp " + data.Saldo.ToString("N0"),
                "Data Ditemukan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

    }
        }

    
    
    
    


      
        
    


      
    
    
    


      
        
    

