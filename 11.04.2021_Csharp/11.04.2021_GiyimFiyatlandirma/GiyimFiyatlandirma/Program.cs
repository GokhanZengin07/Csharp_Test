using System;

namespace GiyimFiyatlandirma
{
    class Program
    {
        static void Main(string[] args)
        {
            string beden;
            Console.WriteLine("Lutfen beden bilgisi giriniz: (Orn S yada M yada L");
            beden = Console.ReadLine();
            beden = beden.ToUpper();

            if (beden == "S" )
                
                Console.WriteLine("Urun fiyati 25 TL");
            else if (beden == "M" )
                Console.WriteLine("Urun fiyati :30 TL");
            else if (beden == "L" )
                Console.WriteLine("Urun fiyati 35 TL");
            else if (beden == "XL" )
                Console.WriteLine("Urun Fiyati 40 TL");
            else
                Console.WriteLine("Duzgun bir deger girin");

        }
    }
}
