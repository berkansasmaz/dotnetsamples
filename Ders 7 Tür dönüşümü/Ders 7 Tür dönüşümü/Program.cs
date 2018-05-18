using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_7_Tür_dönüşümü
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı = 10;                 //sayı değişkeni tanımladık
            float ondalık = 11.5f;        //ondalık sayı değişkeni tanımladık
            string metin = "25";         // sayı olarak 25 değil metin olarak yani 2 ile 5 in yan yana gelmesi gibi 

            //Bilinçli tür değişimi;
            ondalık = (float)sayı; //sayı değişkenini float veri tipine dönüştürdük sonra ondalık sayının içine attık
            
            //Bilinçsiz tür değişimi;
            ondalık = sayı;// her bir tamsayi ayni zamanda bir ondalıklı sayı oldugundan hata vermez

            // Parse tür değişimi;
            sayı = int.Parse(metin);   //Metin değişkenini metin olan 25 i sayı olan 25 cevirdik sonra sayı değişkenine eşitledik
            Console.WriteLine(sayı);
            //Tostring() tür değişimi
            metin = ondalık.ToString();//sayı yı stringe dönüştürür.
            Console.Write(ondalık);

           




            Console.ReadKey();
        }
    }
}
