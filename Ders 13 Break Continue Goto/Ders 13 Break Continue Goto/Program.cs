using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_13_Break_Continue_Goto
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int sayac = 0; sayac < 5; sayac++)//basit bir for dögüsü oluşturduk
            {
                if (sayac==3)//eğer sayac 3 ise süslü parantez içini yap
                {
                    break;//sayac 3 geldiğinde for dan çık
                }
                Console.WriteLine(sayac);
            }




            Console.ReadKey();
        }
    }
}
