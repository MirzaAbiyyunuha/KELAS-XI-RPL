// MATERII ARRAY DAN KOLEKSI DASAR

// PADA MATERI INI KITA AKAN MEMPELAJARI
// ARRAY
// LIST
// SERTA MENYIMPAN BANYAK DATA DALAM SATU TEMPAT

// 1. ARRAY
// DIGUNAKAN UNTUK MENYIMPAN BANYAK DATA DALAM SATU VARIABEL

string[] namabuah = {"apel","jeruk", "mangga" }; // array string untuk menyimpan beberapa nama buah

foreach (string buah in namabuah) // perulangan untuk menampilkan semua data dalam array
{
    Console.WriteLine(buah);

}

List<String> namaSiswa = new List<string>(); // membuat list string untuk menyimpan beberapa nama siswa

// menambahkan data ke dalam list
namaSiswa.Add("Budi");
namaSiswa.Add("Siti");
namaSiswa.Add("Andi");

foreach (string siswa in namaSiswa)
{
    Console.WriteLine(siswa);
}
