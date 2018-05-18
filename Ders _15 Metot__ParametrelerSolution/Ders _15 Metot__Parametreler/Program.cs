using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders__15_Metot__Parametreler
{
    class Program
    {
        static void Main(string[] args)
        {
            EkranaYaziYaz("Bunu Ekrana Yaz");//Bunu ekranayaz parametre oluyor

            string adSoyad = AdSoyadVer("Berkan" , " ŞAŞMAZ");
            Console.WriteLine(adSoyad);

            int topladı = Toplama(5, 10);
            Console.WriteLine(topladı);

            

            Console.ReadKey();
        }
        
        
        static void EkranaYaziYaz(string yazilacakyazi)//ekrana kendi istediğimi yazdırmak için string değişkeni tanımladım
        {
            Console.WriteLine(yazilacakyazi);
        }

        static string AdSoyadVer(string ad, string soyad)
        {
            return ad +""+ soyad;
        }

        static int Toplama(int a, int b)
        {
            int sonuc = a + b;
            return sonuc;
        }

    }
}
