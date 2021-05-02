using System;

namespace ArraySiralama
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 10, 5, 7, 9, 15, 3, 8, 1, 6 };
            int[] siraliDizi = new int[dizi.Length];
            
            // Siralama isleminden once:
            
            foreach (var item in dizi )
            {
                
                
                if (item==dizi[(dizi.Length)-1])
                {
                    Console.Write(item);
                }
                else
                {
                    Console.Write(item + "-");
                }
                
            }
            Console.WriteLine("\nDizi boyutu " + dizi.Length);
            Console.ReadLine();

        }
    }
}
