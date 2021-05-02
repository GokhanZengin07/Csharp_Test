using System;

namespace ArrayListUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList adSoyad = new ArrayList();
            adSoyad.Add("Gokhan Zengin");
            adSoyad.Add("Efe Mavi");
            adSoyad.Add("Mehmet Zengin");

            adSoyad.Remove("Gokhan Zengin");
        }
    }
}
