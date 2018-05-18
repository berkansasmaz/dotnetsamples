using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_5_Oparetörler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  && = ve ,  || = veya , ? = ise demek , :  = aksi halde 
            int a = 10;//a yi tanımladık
            int b = 15;//b yi tanımladık
                       //b = 11;// b yi yeniden tanımladık 
            Console.WriteLine(a);
            Console.WriteLine(b);


            if (a > 5 && b > 12)// a 5 ten büyük ve b 12 den büyük se süslü parantezi yap dedik
            {
                //koşullardan ikisinin de doğru olması lazım
                Console.WriteLine("a beşten büyük ve b on iki den büyük.");

            }

            else if (a > 5 && b < 12) //eğer üsteki doğru değilse bu koşula bak a 5 ten büyük ve b 12 den küçük ise süslü parantezi yap
            {
                //koşullardan ikisinin de doğru olması lazım
                Console.WriteLine("a beşten büyük ve b on ikiden küçüktür.");


            }
            
         
            if (a > 5 || b > 15) ; // a 5 ten büyük yada b 12 den büyük ise aşagıdakini yap
            {
                //koşullardan biri doğru olması yeterli.
                Console.WriteLine("a 5 ten büyük yada b 12 den büyük");


            }
           
            b = a > 5 ? b += a : b -= a; // a 5 ten büyük ise b ye a ekle aksi halde b den a cıkar demek 
            Console.WriteLine(a);
            Console.WriteLine(b);




            Console.ReadKey();
        }
    }
}
