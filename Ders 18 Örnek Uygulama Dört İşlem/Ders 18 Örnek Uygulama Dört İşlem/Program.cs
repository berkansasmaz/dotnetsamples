using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_18_Örnek_Uygulama_Dört_İşlem
{
    class Program
    {
        static void Main(string[] args)
        {
            string secim;

            do
            {
                MenüYaz();
                secim = Console.ReadLine();

                secim = İşlemyap(secim);

            } while (secim == "0" || secim == "1" || secim == "2" || secim == "3" || secim == "4" || secim == "5");
        }

        static void MenüYaz()
        {
            Console.WriteLine("[1] Toplama");
            Console.WriteLine("[2] Çıkarma");
            Console.WriteLine("[3] Çarpma");
            Console.WriteLine("[4] Bölme");
            Console.WriteLine("[5] Çıkış");
            Console.WriteLine("");
            Console.Write("Lütfen İşlem Numarasını Giriniz: ");
            
        }

        static string İşlemyap(string secim1)
        {
            switch (secim1)
            {
                case "1":
                  toplamayap();
                    Console.Clear();
                 break;
                case "2":
                  cıkarmayap();
                    Console.Clear();
                    break;
                case "3":
                  carpmayap();
                    Console.Clear();
                    break;
                case "4":
                 bölmeyap();
                    Console.Clear();
                    break;
                case "5":
                    secim1 = cıkışyap();
                    Console.Clear();
                    break;
                default:
                  MenüYaz();
                    secim1 = "0";
                    Console.Clear();
                  break;
                      
            }
            return secim1;
        }

        static string cıkışyap()
        {
            return "6";
        }


        static void İşlembaşligi(string başlik)
        {
            Console.Clear();

            Console.WriteLine(başlik);

            for (int i = 0; i < başlik.Length; i++)//kelimenin büyüklüğü kadar demek
            {
                Console.Write("=");

            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static int sayial(string kacincisayi)
        {
            Console.Write(kacincisayi + ". Sayı Giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            return sayi;
        }

        static void sonucyaz(string sonucmetni)
        {
            Console.WriteLine("");
            Console.WriteLine("Sonuç ===> " + Convert.ToString(sonucmetni));

            Console.WriteLine("");
            Console.WriteLine("Devam Etmek İçin Bir Tuşa Basınız..");
            Console.ReadKey();
        }//kodu kısaltmak için yaptım..



        static void toplamayap()
        {
            
            İşlembaşligi("Toplama İşlemi");

            int sayi1 = sayial("1");
            int sayi2 = sayial("2");


            int toplam = sayi1 + sayi2;

            sonucyaz(Convert.ToString(toplam));


        }


        static void cıkarmayap()
        {
           İşlembaşligi("Çıkarma İşlemi");

            int sayi1 = sayial("1");
            int sayi2 = sayial("2");

            int toplam = sayi1 - sayi2;

            sonucyaz(Convert.ToString(toplam));

        }


        static void carpmayap()
        {
           İşlembaşligi("Çarpma İşlemi");

            int sayi1 = sayial("1");
            int sayi2 = sayial("2");

            int toplam = sayi1 * sayi2;

            sonucyaz(Convert.ToString(toplam));
        }

        
        static void bölmeyap()
        {
            İşlembaşligi("Bölme İşlemi");

            int sayi1 = sayial("1");
            int sayi2 = sayial("2");

            int toplam = sayi1 / sayi2;

            sonucyaz(Convert.ToString(toplam));

        }

    }
}
