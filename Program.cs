using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Girdiğiniz sayı kadar pozitif sayı girin: ");
            int[] sayilar = new int[sayi];
            for (int i = 0; i < sayi; i++)
            {
                sayilar[i] = int.Parse(Console.ReadLine());
                if (sayilar[i] <= 0)
                {
                    Console.WriteLine("Negatif sayı ya da 0 girdiniz");
                    Array.Clear(sayilar,sayilar[i],sayilar[sayi]);
                }
            }
            
            foreach (var a in sayilar)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine("Çift sayılar: "+a);
                }
                else
                    Console.WriteLine("Çift sayı girmediniz");
            }
            
            Soru2 soru = new Soru2();
            soru.Soru();
            Soru3 soru3 = new Soru3();
            soru3.Soru();
            
            Soru4 soru4 = new Soru4();
            soru4.Soru();
        }
        public class Soru2{
            public void Soru()
            {
                int[] sayilar = new int[2];
                Console.WriteLine("Pozitif iki sayi giriniz: ");
                for (int i = 0; i < 2; i++)
                {
                    sayilar[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("{0} adet sayı giriniz: ",sayilar[0]);
                int[] sayilar2 = new int[sayilar[0]];
                for (int i = 0; i < sayilar[0]; i++)
                {
                    sayilar2[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("{0} 'e eşit ya da tam bölünen sayılar: ", sayilar[1]);
                for (int i = 0; i < sayilar[0]; i++)
                {
                    if(sayilar2[i] % sayilar[1] ==0)
                        Console.WriteLine(sayilar2[i]);
                    if(sayilar2[i] == sayilar[1])
                        Console.WriteLine(sayilar2[i]);
                }
            }
        }
        public class Soru3
        {
            public void Soru()
            {
                Console.WriteLine("Pozitif bir sayı giriniz: ");
                int sayi = int.Parse(Console.ReadLine());
                string[] kelime = new string[sayi];
                Console.WriteLine("{0} adet kelime giriniz: ",sayi);
                for (int i = 0; i < sayi; i++)
                {
                    kelime[i] = Console.ReadLine();
                }
                Array.Reverse(kelime);
                for (int i = 0; i < sayi; i++)
                {
                    Console.WriteLine(kelime[i]);
                }
            }
        }
        public class Soru4
        {
            public void Soru()
            {
                Console.WriteLine("Bir cümle giriniz: ");
                string cumle = Console.ReadLine();
                string[] cumleler = cumle.Split(' ');
                Console.WriteLine("Cümledeki kelime sayısı = "+cumleler.Length);
                int kelimesayisi = 0;
                string bosluk = " ";
                for (int i = 0; i < cumle.Length; i++)
                {
                    kelimesayisi++;
                    if(bosluk.Contains(cumle[i]))
                    {
                        kelimesayisi--;
                    }
                }
                Console.WriteLine("Cümledeki harf sayısı = "+kelimesayisi);
            }
        }
    }
}
