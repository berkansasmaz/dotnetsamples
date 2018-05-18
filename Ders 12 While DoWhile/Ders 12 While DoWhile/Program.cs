using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ders_12_While_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            while (a < 8) //while ile a 8 den küçük ise aşağıdakini yap dedik
            {
                Console.WriteLine(a); // ve sonsuz döngüye girer sürekli a nın değerini yazar
                a++;// sonsuz dögüye girmemesi için a yı bir artırırız 
                //yani 5 i yazdı sonra 1 artırdı başa döndü sonra 1 artırdı bir daha başa döndü ta ki 8 den küçü olasıya kadar
            }

            do//dowhile de while gibi ama tek farkları var aşağıda anlatıcam 
            {
                Console.WriteLine(a);
                a++;
            } while (a < 8);//while ın aşağıda olması

            /*while ile doWhile arasında ki fark
              while de üstte koşulu belirledik o koşul gerçekleşmesse hiç bir şeyy yazdırmaz ekrana
              doWhile de koşul kısmı süslü parantezden sonra olduğu için koşul gerçekleşmesse bile ekrana süslü parantez arasını yazdırır
            */


            Console.ReadKey();
        }
    }
}
