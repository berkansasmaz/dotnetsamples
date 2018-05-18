using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ders_29_Overloading_Aşırı_Yüklenme
{
    class Program
    {
        static void Main(string[] args)
        {
            kisi K1=new kisi();
            
            kisi K2=new kisi();

            

            K1.Ad = "Berkan";
            K1.Soyad = "Şaşmaz";
            K2.Ad = "Burak";
            K2.Soyad = "Şaşmaz";
        
            K1.EkranaYaz();
            K2.EkranaYaz(on_ek:"MCBU,");//2. overload 1.overload tan ayıran özelliği parametre tanımladık 
            K2.EkranaYaz(son_ek:",Hazırlık",onemsiz:false);//3. overload bool değişkeni hiç bir yerde kullanılmadığı için ister true yaz ister false yaz
            

            Console.ReadKey();
        }
    }
    class kisi
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void EkranaYaz()//Bu metotun ismi EkranaYaz aynı metot ismini bir kere daha kullanırsam ikincisi overloading yani aşırı yüklenmiş olur
        {
            Console.WriteLine(Ad+"  "+Soyad);
        }

        public void EkranaYaz(string on_ek)//2.sini tanımlarken bilgisayar ayırt etmesi için birincisinden parametre tanımlaadım
        {
            Console.WriteLine(on_ek+" "+Ad+" "+Soyad);
        }

        public void EkranaYaz(string son_ek,bool onemsiz)//bir kere daha overloading yaparsak bunuda 2. overload dan ayırmak için başka veri tipi kullandık hiç bir amac için kullanılmıycak sadece kodu bilgisayar ayırt etmesi için
        {
            Console.WriteLine(Ad+" "+Soyad+" "+son_ek );
        }
    }

}
