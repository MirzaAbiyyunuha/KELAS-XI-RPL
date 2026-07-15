// method / fungsi sederhana 

// pada materi ini kita akan mempelajari :
// 1. method / fungsi
//2. parameter
// 3. return value

// 1. Method 
// ada kumpulan kode yang digunakan untuk menjalankan tugas tertentu
// dapat membantu program menjadi 
// - lebih rapih 
// - lebih terstruktrur 
// - dan dapat digunakan kembali (reuse)

// void karena method tidak mengembalikan nilai

static void Salam() //  method bernama salam 
{
    Console.WriteLine("Hello world"); // method memiliki tugas untuk menampilkan "hello world"
}


// memanngil method tanpa return value dan tanpa parameter
Salam();


// method dengan parameter
// parameter digunakan untuk mengirim data ke method
static void Sapa(string nama)
{
    Console.WriteLine("Hello " + nama);
}

Sapa("Budi");


static int Tambah(int a, int b)
{
    return a + b;
}

Console.WriteLine(Tambah(5, 7));

// method digunakan untuk menjalankan tugas tertentu
// parameter digunakan untuk menrima data
// return digunakan untuk mengembalikan nilai