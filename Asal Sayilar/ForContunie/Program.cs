using System;

namespace ForContunie
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 5) break;
                Console.WriteLine(i);
                
            
            }
            Console.ReadKey();
        }
    }
}
