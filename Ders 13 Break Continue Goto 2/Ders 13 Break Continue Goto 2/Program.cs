using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_13_Break_Continue_Goto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int sayac = 0; sayac < 5; sayac++)//basit bir for döngüsü
            {
                if (sayac==3)//3 e geldiğinde süslü parantez içi
                {
                    continue;// 3 'e geldiğinde 3 atla bir sonraki işlemi yap yani bir arttır fordan çıkmaz sadece o işlemi atlar
                }

                Console.WriteLine(sayac);
            }



            Console.ReadKey();

        }
    }
}
