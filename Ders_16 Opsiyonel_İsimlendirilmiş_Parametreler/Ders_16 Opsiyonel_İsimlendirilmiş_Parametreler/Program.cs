using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_16_Opsiyonel_İsimlendirilmiş_Parametreler
{
    class Program
    {
        static void Main(string[] args)
        {
            EkranaYaziYaz("Berkan",metin2:"ŞAŞMAZ");//metin 3 değer atamadım varsılan yani opsiyonel olarak aşağıdakini kulanıcak ayrıca tek tek tanımlama istersemde metin:şaşmaz da yaptığım gibi tanımlayabilirim.

            Console.ReadKey();
        }

        static void EkranaYaziYaz(string metin1="", string metin2="", string metin3 ="Hell0")//Eğer 3 değer atamassam varyılan olara bunları "" içindekileri kullanıcak.

        {
            //geri dönüşlü olmayan metot 
            Console.WriteLine(metin1);
            Console.WriteLine(metin2);
            Console.WriteLine(metin3);
        }
    }
}
