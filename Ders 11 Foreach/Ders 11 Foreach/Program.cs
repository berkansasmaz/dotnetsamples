using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_11_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizim = new int[3];

            dizim[0] = 10;
            dizim[1] = 20;
            dizim[2] = 30;

            //for (int sayac = 0; sayac < 3 ; sayac++)
            //{
            //    int sayi =dizim[sayac];
            //    Console.WriteLine(sayi);
            //}

            //üsteki for la dda yapılır ama foreach ile daha kolay olur
            foreach (int sayi in dizim)//sayı değişkeni tanımladık ve dizimi içine attık
            {
                Console.WriteLine(sayi);
            }

            Console.ReadKey();
        }
    }
}
