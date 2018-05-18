using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_13_Break_Continue_Goto_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool giris_islendimi = false; //sonsuz döngüye girmemesi için bool veri tipi tanımladık giriş işlendimi hayır.

            Giriş://Burayı giriş olarak tanımladım 
            for (int sayac = 0; sayac < 5; sayac++)
            {

                
                Console.WriteLine(sayac);
            }

            //Giriş işlenince aşağıya hiç girmeyecek ve sonsuz döngüden kurtulacağız

            if (giris_islendimi == false)//eğer giriş işlnemediyse aşağıdakini yap
            {
                 giris_islendimi = true;//O zaman girişi işlnedi olarak belirle 
                goto Giriş;//goto giriş dediğim için girişe geri git dedim ve sonsuza kadar döngüye girdi
            }

            
            Console.ReadKey();
        }
    }
}
