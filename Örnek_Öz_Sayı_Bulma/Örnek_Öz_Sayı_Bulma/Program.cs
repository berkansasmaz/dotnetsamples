using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_Öz_Sayı_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            //öz sayı mesela  3 sayını ele alalım 9 la çarpıyoruz 27 ve bunu birler basamagı 7 , onlar basamagı 2 yani 3 ün özsayısı 9 
            //bu problemde üc basamaklıların öz sayı toplamı 
            int özsayi = 0;
            for (int i = 100; i < 1000; i++)
            {
                
                int sayi = i * 9;

                int binler = sayi / 1000;
                sayi = sayi % 1000;
                int yüzler = sayi / 100;
                sayi = sayi % 100;
                int onlar = sayi / 10;
                int birler = sayi % 10;

                int toplam = binler + yüzler + onlar + birler;
                özsayi += toplam;
            }
               
               Console.WriteLine(özsayi);//bunu for içinde yazarsan herseferinde sıfırlıyor.

            Console.ReadKey();
        }
    }
}
