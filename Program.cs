using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {  
            ArrayList araclar = new ArrayList();
            int sayi = 0;
        menu:
            Console.WriteLine("");
            Console.WriteLine("1-Araç Giriş");
            Console.WriteLine("2-Araç Çıkış");
            Console.WriteLine("3-Program Çıkış");
            Console.WriteLine("Seçiminiz.....");
            Console.WriteLine("");
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                if (sayi == 20)
                {
                    Console.WriteLine("Otopark Dolu İlk olarak Arç Çıkışı Yapın");
                    Console.WriteLine("");
                    Console.ReadKey();
                    goto menu;
                }
                Console.WriteLine("Araç Plakası");
                araclar.Add(Console.ReadLine());
                Console.WriteLine("");
                sayi++;
                goto menu;
            }
            if (secim == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("Çıkacak Araç Plakası");
                string cikacak = Console.ReadLine();
                int sira = araclar.IndexOf(cikacak);
                if (sira >= 0)
                {
                    Console.WriteLine("Kaç Saat Kaldı");
                    int saat = Int16.Parse(Console.ReadLine());

                    if (saat == 1)
                    {
                        Console.WriteLine("Ödenecek Ücret 5TL");
                    }
                    if (saat == 2)
                    {
                        Console.WriteLine("Ödenecek Ücret 10TL");
                    }
                    if (saat == 3)
                    {
                        Console.WriteLine("Ödenecek Ücret 15TL");
                    }
                    if (saat > 3)
                    {
                        Console.WriteLine("Ödenecek Ücret 40TL");
                    }
                    Console.WriteLine("");
                    sayi--;
                    araclar.RemoveAt(sira);
                }
                goto menu;

            }
            Console.ReadKey();

        }
    }
}
