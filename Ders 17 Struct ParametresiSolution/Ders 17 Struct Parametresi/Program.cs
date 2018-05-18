using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_17_Struct_Parametresi
{
    class Program
    {
        static void Main(string[] args)
        {
            ToplamaElemanlarım Parametrelerim =new ToplamaElemanlarım();
            Parametrelerim.a = 5;
            Parametrelerim.b = 3;
            Parametrelerim.c = 9;
            Parametrelerim.d = 6;
            Parametrelerim.sonucmetni = "Toplamın Sonucu:";

            Toplama(Parametrelerim);

            Console.ReadKey();
        }

        static void Toplama(ToplamaElemanlarım structelemanları)
        {
            int sonuc = structelemanları.a + structelemanları.b + structelemanları.c + structelemanları.d;
            Console.WriteLine(structelemanları.sonucmetni+sonuc.ToString());
        }

        struct ToplamaElemanlarım
        {
            //privete demek özel demek sadece structın içinde kullanılır demek biz bunları public olarak değiştiriyoruz ki başka yerlerdede kulanabilelim
            public int a;
            public int b;
            public int c;
            public int d;
            public string sonucmetni;
        }
    }
}
