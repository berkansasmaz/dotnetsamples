using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_30_Virtual_Sanal_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi k1=new Kisi();
            k1.AD = "Berkan";
            k1.Soyad = "Şaşmaz";
            k1.EkranaYazıYaz();


            Kisi_Unvan k2=new Kisi_Unvan();
            k2.AD = "Berkan";
            k2.Soyad = "ŞAŞMAZ";
            k2.Unvan = "MSP";
            k2.EkranaYazıYaz();

            Console.ReadKey();
        }
    }

    class  Kisi
    {
        public string AD { get; set; }
        public string Soyad { get; set; }

        public virtual void EkranaYazıYaz()//Virtual eklediğmizde artık değiştirebiliriz 
        {
            Console.WriteLine(AD+" "+Soyad);// Amac bu kodun başına ünvan eklemek yani bunu ezip yenisini tanımlamak
        }
    }

    class  Kisi_Unvan:Kisi//kisi classından miras aldık
    {
        public string Unvan { get; set; }//inheritance miras alma ile karıştırma aynı ad ama farklı class içinde geliştiriyoruz 

        public override void EkranaYazıYaz()//Ezme işlemi override ile yapılır
        {
           // base.EkranaYazıYaz(); // base. yazarsak hiç bir değişilik yapmadan çalıştırır yanı ad +soyad şeklinde ama biz yeni bir şey yazdırmak istediğmiz için bunu kullanmıycaz
           Console.WriteLine(Unvan+" "+AD+" "+" "+Soyad);//Ekranayazıyaz orjinal metodu ezdik ve artık bu kullanılacak 
        }
    }
}
