using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_35_Partial_Kısmi_Sınıflar
{
    partial class Toplayıcı//partial sınıfların isimleri aynı olmak zorunda.
    {
        public int Sayi1 { get; set; }
        public int Sayi2 { get; set; }

      public int Topla(int s1, int s2)
      {
            int Toplam = s1 + s2;

            Console.WriteLine(Convert.ToString(Toplam));

            return Toplam;
      }

        
    }

    partial class Toplayıcı//Diğer classın diğer partı gibi düşün 2 si toplamda toplayıcı classı ediyor.
    {
        public int Sayi3 { get; set; }

        public int Topla(int sayi1, int sayi2,int Sayi3)
        {
            int Toplam = sayi1 + sayi2+Sayi3;

            Console.WriteLine(Convert.ToString(Toplam));

            return Toplam;
        }
    }
}
