using System;

namespace UrunFiyatOrtalama
{
    class Program
    {
        static void Main(string[] args)
        {
            double fiyat = 0, toplam = 0, ortalamaFiyat = 0;
            for (int i = 1; i <=12; i++)
            {
                Console.WriteLine("{0}. ay icin fiyat bilgisi giriniz:",i);
                fiyat = double.Parse(Console.ReadLine());
                toplam += fiyat;
                
            }

            ortalamaFiyat = toplam / 12;
            Console.WriteLine("__________");
            Console.WriteLine("Urunun ortalama fiyat {0}", ortalamaFiyat);
        }
    }
}
