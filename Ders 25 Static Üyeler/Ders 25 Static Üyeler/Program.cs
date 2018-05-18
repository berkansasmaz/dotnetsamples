using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_25_Static_Üyeler
{
    class Program
    {
        static void Main(string[] args)            //bu main içinde eğer static olarak belirtmessek hepsi dynamic tir.
        {
             /*GarbageCollector GC =eğer bir veriyi static diye tanımlamassak dynamic olur ve ramde yer kaplamasın diye uygulama çalıtırldıktan
             sonra o kodu işledikten sonra .net te GarbageCollector adlı Çöp bunları siler static diye tanımlarsak silmez ve ramde yer kaplar*/
            
            // mavi ile yazılı int string gibi bunlar VALUE TYPE diye geçer
            int sayi;
            sayi = 0;
            string yazi;
            yazi = "Berkan";

            Ekranayaz(sayi);

            
            kisi.Ad = "Berkan";//Kullanımı Böyle olur kisi k=new kisi(); diyemeyiz static leri new ile tekrar tekrar kullanamayız nesne oluşmaz
            kisi.Soyad = "ŞAŞMAZ";
            
            Console.ReadKey();
        }
            //burada yani main dışında tanımladığımız her şey static dir.
           //yani burası program sonlanana kadar ramde yer kaplar.
       
        static void Ekranayaz(int s)
        {
            
            //işlemler yapılır.
        }


    }

    static class kisi//eğer propery static diye tanımlarsam ve class da statick diyye tanımlarsam üsteki kullanımı farklı
    {
        //new ile çoğaltmak istersek static kullanmayacağız.
        //static lik ram üzerinde bir tane oluşturulması istenen durumlarda kolaylık sağlıyor
        public static string Ad { get;  set; }
        public static string Soyad { get; set; }
    }
}
