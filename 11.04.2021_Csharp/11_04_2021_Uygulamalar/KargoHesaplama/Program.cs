using System;

namespace KargoHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bir kargo fiyati hesaplama modulu isteniyor. Algoritma:
            0.1 gr ile 1000gr arasi 20 TL (1000 gr dahil degil)
            1000gr ile 2000gr arasi 30 TL
            2000gr ile 3000gr arasi 40 TL
            3000gr uzeri 100 TL 
            20.0000gr uzeri tasinamaz.

             
             */
            double agirlik;
            Console.Write("Lutfen kargonun agirligini giriniz: (GR)");
            agirlik = double.Parse(Console.ReadLine());
            if (Console.ReadLine() == "")
                Console.WriteLine("Kargo agirligi bos olamaz!");
            if (agirlik == 0)
                Console.WriteLine("Kargo agirligi sifir(0) olamaz");

            if (agirlik < 0.1)
                Console.WriteLine("Kargo agirligini minimum 0.1 gr olmaz zorundadir");
            if (agirlik >= 0.1 && agirlik < 1000)
                Console.WriteLine(" Hesaplanan Kargo tutari: 20 tl");
            if (agirlik >= 1000 && agirlik < 2000)
                Console.WriteLine("Hesaplanan kargo tutari 30 TL");
            if (agirlik >= 2000 && agirlik == 3000)
                Console.WriteLine("Hesaplanan kargo tutari:40");
            if (agirlik >= 3000 && agirlik<=20000)
                Console.WriteLine("Hesaplanan kargo tutari 40 Tl");
            if (agirlik > 20000)
                Console.WriteLine("20 kg`den fazla agirliga sahip kargo kabul edilememektedir");
            Console.ReadKey();

        }
    }
}
