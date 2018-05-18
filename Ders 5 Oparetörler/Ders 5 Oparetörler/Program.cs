using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_5_Oparetörler
{
    class Program
    {
        static void Main(string[] args)
        {
            //+= , -= , *=  , /=

            int a = 10;
            int b = 15;

             a = a + 5; //yerine a += 5 yazmak daha kolay.
             a = a - 5; //yerine a -= 5 yazmak daha kolay.
             a = a * 5; // yerine a *= 5 yazmak daha kolay.
             a = a / 5; //yerine a /=5 yazmak daha kolay.

            Console.WriteLine(a);
            Console.WriteLine(b);
            

            b = (a + b);
            Console.WriteLine(a);
            Console.WriteLine(b);
            

            Console.ReadKey();
        }
    }
}
