using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_14_Metot_Nedir
{
    class Program
    {
        static void Main(string[] args)//static olduğu için sadece statik metotları içine alabilir
        {
            Ekrana_Yazi_Yaz();


            string adSoyad = Adimi_Soyadımı_Yaz();//Geri dönüşlü olduğu için bir string değişkenine eşitliyoruz

            Console.WriteLine(Adimi_Soyadımı_Yaz);


            Console.ReadKey();
        }

        static void Ekrana_Yazi_Yaz()//Geri dönüşü olmayan metot  static koyduk başına yazdırabilmek için
        {
            Console.Write("Adım : Berkan");//Console.write direk yazdırır
            Console.Write(" Soyadım : ŞAŞMAZ");//console.write alta geçmeden aynı satırda yazdırır
            Console.WriteLine("");//bi satır atla dedik
        }

        static string Adimi_Soyadımı_Yaz()//geri dödüren metot static koyduk başına yazdırabilmek için
        {
            return "Berkan" + "" + "Şaşmaz";

        }


    }
}
