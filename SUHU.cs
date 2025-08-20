/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Konversi Suhu");
        Console.WriteLine("Pilih jenis konversi:");
        Console.WriteLine("1. Celsius ke Fahrenheit");
        Console.WriteLine("2. Fahrenheit ke Celsius");
        Console.WriteLine("Masukkan pilihan (1/2)");
        int pilihan = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("MASUKKAN SUHU: ");
        double suhu = Convert.ToDouble(Console.ReadLine());

        double hasil = 0;
        if (pilihan == 1)
        {
            hasil = (suhu * 9 / 5) + 32;
            Console.WriteLine($"Hasil: {hasil} F ");
        }
        else if (pilihan == 2)
        {
            hasil = (suhu - 32) * 5 / 9;
            Console.WriteLine($"Hasil: {hasil} C");
        }
        else
        {
            Console.WriteLine("pilihan tidak valid!");
        }

        Console.WriteLine("\nTekan sembarang tombol untuk keluar");
        Console.ReadKey();
    }
}

*/