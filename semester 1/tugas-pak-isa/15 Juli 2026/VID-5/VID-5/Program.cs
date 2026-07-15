// Materi perulangan for, while, dan foreach

// perulangan digunakan untuk  menjalankan perintah berulang otomatis

// dengan perulangan program dapat menghemat penulisan kode

// for 
//digunakan ketika perulangan sudh diketahui

// fordigunaka tuk perulangan dengan jumlah tertentu


for (int i = 1; i <=5; i++)
{
    Console.WriteLine("perulangan ke-" + i);
}


// while loop 
// digunakan ketika jumlah perulangan belum diketahui secara pasti



int angka = 1;

while(angka <= 5)
{
    Console.WriteLine("angka; "+ angka);
    angka++;

}

// foreach loop
// digunakan untuk mengambil data dari kumpulan data seperti array, list, dan lain-lain
string[] namabuah = { "apel", "mangga", "pisang"  };

foreach (string buah in namabuah)
{
    Console.WriteLine(buah);
}


