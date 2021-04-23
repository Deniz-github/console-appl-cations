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

            Console.WriteLine("lütfen bir sayı giriniz");

            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("alan= {0}", Metod.KareninAlanı(x));
            Console.WriteLine("Lütfen bir sayı giriniz");


            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayı giriniz");


            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("alan= {0}", Metod.DikdörtgeninAlanı(y,z));
        }
    }
}
