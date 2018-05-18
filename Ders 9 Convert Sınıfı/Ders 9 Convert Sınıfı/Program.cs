using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_9_Convert_Sınıfı
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 12;
            string metin1 = "Berkan";
            string metin2 = "20";
            
            // Tür dönüşümü convertsiz
            string metin3 = a.ToString();
            int c = int.Parse(metin2);

            // Convertli
            metin3 = Convert.ToString(a);
            c = Convert.ToInt32(metin2);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(metin1);
            Console.WriteLine(metin2);
            Console.WriteLine(metin3);





            Console.ReadKey();
        }
    }
}
