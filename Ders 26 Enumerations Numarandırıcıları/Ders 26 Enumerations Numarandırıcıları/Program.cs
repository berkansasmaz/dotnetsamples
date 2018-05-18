using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_26_Enumerations_Numarandırıcıları
{
    class Program
    {//enum kullan 
        /*
         Enumları kullanma sebebimiz bi void tanımladık parametreli içine swich oluşuturduk ve burada bir sürü değişken tanımladık
         bu değişkenleri enum da tanımlarsak mainde kullanırken enumun dışında bir şey kullanırsak hata alırız izin vermez enumlar hayat kurtarır
         bir sürü değişken tanımladık tek tek ismine bakmak yerine direk bütün isimleri orada görebiliriz.
        */
        static void Main(string[] args)
        {
            EkranaYaz(Komut.Berkan);
            EkranaYaz(Komut.Şaşmaz);
            Console.ReadKey();


        }

        static void EkranaYaz(Komut K)//enumun ismini bi harfe tanımladık
        {
            if (K==Komut.Berkan)  //kullanımı eğer girdiğimiz değer enumdaki berkan ise süslü parantez içini uygula
            {
               // Console.WriteLine("İFAd");
                
            }
           
            switch (K) //switch te kullanımı 
            {
                case Komut.Berkan://komut Berkan ise  
                    Console.WriteLine("Ad");
                    break;
                case Komut.Şaşmaz://komut Şaşmaz ise
                    Console.WriteLine("Soyad");
                    break;
                default://ne Berkan ne Şaşmaz ise
                    break;
            }
        }

    }

    enum Komut //enum ve ismini komut olarak belirledi
    {
        //enuma tanımladığımız kelimeler 
        Berkan,
        Şaşmaz,
        //istediğimiz kadar değişkeni tanımlayabiliriz
    }
}
