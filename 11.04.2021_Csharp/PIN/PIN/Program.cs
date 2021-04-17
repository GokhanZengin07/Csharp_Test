using System;
using System.Collections;
using System.Linq;
namespace PIN
{
    class Program
    {
        static void Main(string[] args)
        {
            /* pin kontrolu
             * pin kodu 4 hane
             * Dogru pin 1453
             * Eger pin yanlis ise yanlis uyarisi */

           /* Console.WriteLine("Lutfen kelime giriniz: ");
            string kelime = Console.ReadLine();
            Console.WriteLine("Girdiginiz {0} kelimesi {1} karakterden olusmaktadir", kelime,kelime.Length);
           */
            int pinKodu=0; // Varsayilan:1453
            Console.WriteLine("Lutfen 4 haneli PIN kodunuzu giriniz:");
            pinKodu =int.Parse (Console.ReadLine());
            if ( Enumerable.Range(1000,9999).Contains(pinKodu))
            {
                //pin kodu kontrolu yapiliyor
                if (pinKodu == 1453) 
                {
                    Console.WriteLine("PIN kodunuz dogru");

                }
                else
                {
                    Console.WriteLine("Pin kodunuz yanlis");
                }
            }
            else
                Console.WriteLine("4 haneli sayi girebilirsiniz");

        }
    }
}
