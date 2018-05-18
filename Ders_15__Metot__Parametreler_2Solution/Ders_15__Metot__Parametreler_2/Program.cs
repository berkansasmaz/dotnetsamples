using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_15__Metot__Parametreler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc = Topla(15,20);
            Console.WriteLine(sonuc);

            string Şarkininİsmi = Şarkı("Tarkan Cuppa");
            Console.WriteLine(Şarkininİsmi);

            string AdımSoyadım = İsimGiriniz("Berkan Şaşmaz");
            Console.WriteLine(AdımSoyadım);

            int ÇarpmanınSonucu = çarpma(5, 10);
            Console.WriteLine(ÇarpmanınSonucu);
            
            Console.ReadKey();
        }

        static int Topla(int a,int b)
        {
            int Topluyor = a + b;
            return Topluyor;
        }

        static string Şarkı(string SARKIİSMİGİRİNİZ)
        {
            string DeğerGir = SARKIİSMİGİRİNİZ;
            return DeğerGir;

        }

        static string İsimGiriniz(string İsminiz)
        {
            return İsminiz;
        }

        static int çarpma(int a,int b)
        {
           int çarpıcak = a * b;
            return çarpıcak;
        }

    }
}
