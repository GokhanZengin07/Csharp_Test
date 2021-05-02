using System;

namespace Asal_Sayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            for (int i = 2; i <= 100; i++)
            { int kontrol = 0;
                for (int j = 2; j <i; j++)
                {
                    if(i%j==0)
                    {
                        kontrol = 1;
                        break;
                    }    
                }
                if(kontrol==1)
                {
                    Console.WriteLine("{0} sayisi asal sayi degildir", i);

                }
                else
                {
                    Console.WriteLine("{0} sayisi asal sayidir", i);
                    sayac++;
                }

            }
            Console.WriteLine("----------------");
            Console.WriteLine("Toplam {0} adet asal sayi mevcut", sayac);
            Console.ReadLine();
        }
    }
}
