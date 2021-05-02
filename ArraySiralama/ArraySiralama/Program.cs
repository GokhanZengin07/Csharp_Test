using System;

namespace ArraySiralama
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 10, 5, 7, 9, 15, 3, 8, 1, 6 };
            int[] siraliDizi = new int[dizi.Length];
            int g;

            // Siralama isleminden once:
            //Array.Sort(dizi);
            //Console.WriteLine(dizi);
            Array.Sort(dizi);
            
            Array.Reverse(dizi);
            Console.WriteLine(dizi[0] + "-") ;
            
            
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
            

            for (int i = 0; i < dizi.Length; i++)
            {
                for (int j = 0; j < dizi.Length; j++)
                {
                    if (dizi[i]>dizi[j])
                    {
                        g = dizi[j];
                        dizi[j] = dizi[i];
                        dizi[i] = g;

                    }
                }
            }
            
            foreach (var item in dizi) 
            {
               
                    if (item == dizi[(dizi.Length) - 1])
                    {
                        Console.Write(item);
                    }
                    else
                    {
                        Console.Write(item + "-");
                    }

                }
            }
        
        }
    }

