using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_3_Değişkenler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Metin değikeni tanımlama;
                    // string Metin_değişkeni = "Berkan";

            //Sayı değikeni tanımlama ;
                   //int Sayi_değişkeni = 10;

            //Ondalık sayı değişkeni tanımlama;
                    // float Ondalik_sayi_değişkeni_kücük = 1.7f;//float değişkeni tanımlarken sonuna f konulur.
                    //double Ondalik_sayi_değişkeni_büyük = 100.5d; //dobule değikeni tanımlarken sonuna d konulur.
           //True veya False 1 yada 0 değikeni;
                   //bool True_veya_false_değişkeni_true = true;
                  // bool True_veya_false_değişkeni_false = false;
            
             

            //Örnek

            Console.WriteLine("Bir metin giriniz : ");

            string metin = Console.ReadLine(); // readline komutu ekrandaki yazıyı oku demek sonra string ile bir metin değikenine tanımladık.

            Console.WriteLine(metin); //okuduğun değeri yaz.

            Console.ReadKey(); // program kapanmasın diye bir tuşa basmamı bekle.


              

        }
    }
}
