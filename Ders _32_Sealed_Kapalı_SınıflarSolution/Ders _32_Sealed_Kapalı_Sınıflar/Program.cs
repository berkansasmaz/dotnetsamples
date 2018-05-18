using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders__32_Sealed_Kapalı_Sınıflar
{
    class Program
    {
        static void Main(string[] args)
        {
            kisikartı kk=new kisikartı();
            kk.Ad = "Berkan";
            kk.Soyad = "ŞAŞMAZ";
            kk.TelNo = "5443082830";

            Fonksiyonlar.İkiMetinBirleştir(p1:"berkan",p2:"Şaşmaz");//classın içindeki static metotlar new kisi(); demeden yani nesne oluşturmadan böyle kullanılabilir.
            Console.ReadKey();
        }
    }

    sealed class kisikartı //abstractın tam tersi miras almaya izin vermez ve sadece new kişi(); diye oluşturulur inheritance
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelNo { get; set; }
    }

    sealed class Fonksiyonlar//içindeki tüm classları static olarak tanımlarsak classı sealed olarak tanımlamamız hata oranını azaltacaktır statik metotlar miras almada ve nesne oluşturmada kullanılamaz
    {
        public static string İkiMetinBirleştir(string p1, string p2)//Bir class içindeki metotlar static ise new ile türetmeye gerek kalmaz 
        {
            return p1 + p2;
        }

        public static int İkiSayiBirleştir(int p1, int p2, int p3)//miras aldığımızda static metotları inherit alamayız
        {
            return p1 + p2 + p3;
        }
    }


}
