using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int  x;
            int  y;
            int  z;

            // Kare
            Console.WriteLine("lütfen bir sayı giriniz");

            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("alan= {0}", Metod.KareninAlanı(x));

            // Dıktorgen,

            // Ilk kenarı
            Console.WriteLine("Lütfen bir sayı giriniz");

            // Ikıncı kenarı
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayı giriniz");


            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("alan= {0}", Metod.DikdörtgeninAlanı(y,z));
        }
    }
}
