using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_6_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            Console.WriteLine(a);
            Console.WriteLine(b);

            if (a>b)// a,b den büyük ise 
            {
                Console.WriteLine("a>b");
            }

            else if (a<b)// a,b den küçük ise
            {
                Console.WriteLine("a<b");
            }

            else // aksi halde yani a,b ye eşittir
            {
                Console.WriteLine("a=b");
            }

            

            switch (a) //switch a tanımladık
            {
                case 1://eğer a bir değil ise aşağıdaki
                    Console.WriteLine("bir");
                    break;
                case 2://eğer a iki değil ise aşağıdaki
                    Console.WriteLine("iki");
                    break;
                case 3://eğer a üç değil ise aşağıdaki
                    Console.WriteLine("üç");
                    break;
                default://eğer ne 1 ne 2 nede üç değil se açağıdakini yap
                    Console.WriteLine("Hiç biri değil");
                    break;
            }

            string ad = ("Beko");// metin ifadesi tanımladı
            Console.WriteLine(ad);//metin yazdırdık

            switch(ad)//switch tanımladık
            {
                case "Berkan"://bu doğru ise
                    Console.WriteLine("Adınız Doğru");
                    break;

                case "Şaşmaz"://bu doğru ise
                    Console.WriteLine("Adınız Yanlış");
                    break;

                default :// hiçbiri değilse
                    Console.WriteLine("Adınız ve Soyadınız yanlış");
                    break;

            }




            Console.ReadKey();
        }
    }
}
