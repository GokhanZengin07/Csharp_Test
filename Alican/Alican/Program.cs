using System;

namespace Alican
{
    class Program
    {
        static void Main(string[] args)
        {

            ibo.fonk(5);

            int flag = 0;
            while (flag <= 0)
            {
                try
                {

                    int sayi1 = 0;
                    int sayi2 = 0;
                    int[] sarr = new int[9];
                    while (sayi1 < 1 | sayi1 > 100)
                    {
                        Console.WriteLine("Lutfen sayi 1`i istenilen 1-100 arasinda giriniz");

                        int v = int.Parse(Console.ReadLine());
                        sayi1 = v;

                    }

                    while (sayi2 < 1 | sayi2 > 100)
                    {
                        Console.WriteLine("Lutfen sayi 2`i istenilen 1-100 arasinda giriniz");

                        int x = int.Parse(Console.ReadLine());
                        sayi2 = x;

                    }
                    for (int i = 0; i < sayi1; i++)
                    {
                        for (int j   = 0; j < sayi2; j++)
                        {
                            
                        }
                    }
                    Console.WriteLine("Sayi1 {0} ve Sayi2 {1}`nin toplami {2}", sayi1, sayi2, sayi1 + sayi2);
                    flag = flag + 1;
                }
                catch (System.Exception a)
                {
                    Console.WriteLine("Sayi girmediniz lutfen sayi giriniz");
                    flag = 0;
                }

            }

        }

    }
    public static class ibo
    {
        public static double fonk(int a)
        {
            return Math.Pow(a, 3);
        }


    }

    public class ibot
    {
        public double fonk(int a)
        {
            return Math.Pow(a, 3);
        }
    }
}



