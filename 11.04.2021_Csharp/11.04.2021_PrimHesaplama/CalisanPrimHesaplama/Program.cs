using System;

namespace CalisanPrimHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2000 tl den kucuk satislar prim yok
             * 2000 tl ile 5000 tl arasi satisin %5 i prim
             * 5000 tl ile 7000 tl arasi satisin %10 u
             * 7000 tl ile ustu %15 prim kazanmaktadir.
             * */
            double satis = 0;
            double prim = 0;

            string tarih = DateTime.Now.ToString("yyyy-MM-dd");
            int primorani=0;

            Console.WriteLine("Aylik toplam satis tutarinizi giriniz:");
            satis = double.Parse(Console.ReadLine());
            if (satis < 2000)
            {
                primorani = 0;
                prim = 0;

            }


            else if (satis >= 2000 && satis < 5000)
            {
                primorani = 5 ;
                prim = satis * primorani/100;
            }

            else if (satis >= 5000 && satis < 7000) { 
                primorani = 10;
                prim = satis * primorani/100; }
            else if (satis >= 7000) {
                primorani = 15 ;
                prim = satis * primorani/100;
            }
            else
                Console.WriteLine("Lutfen bilgilerinizi kontrol ediniz");
            Console.WriteLine("{0} Tarihi itibari ile bu ay prim hakedisisniz {1}, prim oraniniz {2}",tarih,Convert.ToInt32(prim),primorani);
            Console.ReadKey();
        }
    }
}
