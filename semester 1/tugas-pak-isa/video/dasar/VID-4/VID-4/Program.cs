int umur = 15;

if (umur >= 17)
{
    Console.WriteLine("boleh membuat KTP");
}
else

{
    Console.WriteLine("Belum boleh membuat KTP");
}

int nilai = 85;

if (nilai >= 90)
{
    Console.WriteLine("Nilai A");

} else if (nilai >= 75) 

{
    Console.WriteLine("Nilai B");

} else {
    Console.WriteLine("Nilai C");

}


string hari = "Senin";

switch (hari)
{
    case "Senin":
        Console.WriteLine("Hari ini adalah hari pertama");
        break;
    case "Minggu":
        Console.WriteLine("Hari ini adalah hari ketujuh");
        break;
    default:
        Console.WriteLine("Hari lain");
        break;
}
