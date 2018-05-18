using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_10_For
{
    class Program
    {
        static void Main(string[] args)
        {
            
              //a++ demek a yı bir arttır demek a 10 ise 11 olmuştur
              //a-- demek a yu bir azalt demek a 10 ise 9 olmuştur

            //// int a = 10;   ////Bir den çok değer tutturmak için aşağıdaki kullanılır
            int[] dizi = new int[5];//Bir tamsayı türünde dizi değişkeni tanımladık ve bu değişken içinde beş tane değer tutucak. 

            dizi[0] = 1;                     //dizi değişkeninin 1 . değeri 1 dir dedik
            dizi[1] = 2;                    //dizi değişkeninin 2 . değeri 2 dir dedik
            dizi[2] = 10;                  //dizi değişkeninin 3 . değeri 5 dir dedik
            dizi[3] = 15;                 //dizi değişkeninin 4 . değeri 10 dir dedik
            dizi[4] = 20;                //dizi değişkeninin 5 . değeri 15 dir dedik

            Console.WriteLine(dizi[3]);   // dizinin üçüncü elemanını yazdır.

            for (int sayac = 0; sayac < 5; sayac++)//eğer 2 artırmak istersek sayac+=2 ile yapılır ; diye ayrılıp 3 bölümden oluşur for
                //sayac diye  bir int değişkeni tanımladık ve ilk değeri 0 dır.sonra sayac 5 den küçük oldukça.sayacı bir arttır.
            {
                //dizideki değerleri sırasıyla yazdımak için
                Console.WriteLine(dizi[sayac]);//sıfıdan başlayıp 4 kadar yazıcak yani dizinin 0. elemanı 1. elemanı gibi
            }



            Console.ReadKey();
        }
    }
}
