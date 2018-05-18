using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_4_Koşul_ifadeleri_İf_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            //if=eğer 1antez ici
            //else if 2.değer dogruy. değer dogruysa 1. nin süslü parsa 2.nin süslü parantez ici
            //else=aksi halde

            Console.WriteLine("Bir sayı giriniz :");
            string değer = Console.ReadLine(); //yazdığımız değeri okutup değişken tanımladık.

            //eşitse==        eşit değilse!=
            if (değer == "1") //değer bire eşit ise süslü parantezin içindekini yaz...
            {
                Console.WriteLine("Değer bir'e eşit.");
            
            }

            else if (değer=="2") //1. if eşit değil se buna bak buda dogru değilse else bak 
            {

                Console.WriteLine("Değer iki'ye eşit");
            }

           else  //değer 1 eşit değilse süslü parantez içindekini yaz...
            {
                Console.WriteLine("Değer bir'den farklı.");
            }
            Console.ReadKey(); //klavyeden bir tuşa basmasını bekle.
            
        }
    }
}
