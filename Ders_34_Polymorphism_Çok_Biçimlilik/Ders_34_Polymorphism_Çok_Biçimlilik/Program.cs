using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_34_Polymorphism_Çok_Biçimlilik
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel P1 = new Personel();
            P1.KullaniciAdi = "Berkan";
            P1.KullaniciUnvan = "Enginering";
            P1.GorevYap( "işlem1");
            //P1.LogAl();

            Console.WriteLine("");

            Isci isci1 = new Isci();
            isci1.KullaniciAdi = "Şaşmaz";
            isci1.KullaniciUnvan = "Akademisyen";
            isci1.GorevYap("İşlem2");
            //isci1.LogAl();

            Console.WriteLine("");

            Yönetici y1 = new Yönetici();
            y1.KullaniciAdi = "Berkan";
            y1.KullaniciUnvan = "Ceo";
            y1.GorevYap("İşlem3");
            //y1.LogAl();

            Console.WriteLine("");

            Console.ReadKey();
            
        }
    }

    class  Personel
    {
        public string KullaniciAdi { get; set; }
        public string KullaniciUnvan { get; set; }

        public  void GorevYap(string gorevAdi)
        {
            Console.WriteLine(string.Format("{0}({1}) isimli kullanıcı {2} gorevini gerçekleştirdi. ",KullaniciAdi,KullaniciUnvan,gorevAdi));//bu satırda string.format kulladığımızda süslü parantez içinde 0 1 2 gibi şeyler yazarız ve "" kapattıktan sonra sırasıyla 0. indise 1. indise neler atıyacağımızı belirleriz.
            this.LogAl();//Bu metot diğer classlarda miras alındığı için logal burada kullandık ve her clasın kendi logunu aldı.
        }
        
        public virtual void LogAl()  //Log aldırıyoruz yani yapılan işleri kayıt altına alıcaz.ve burada ki virtual diğer classlarda ezip çalışanı patron olarak değitirmemize imkan tanıyor.
        {
            Console.WriteLine(string.Format("{0} isimli çalışan işlem yaptı.",KullaniciAdi));
        }
       

    }
    //Polymorphism bu şekilde başka bir classtan miras alarak ezilmesine denir 
    class Isci:Personel
    {
        public int seviye { get; set; }

        public override void LogAl()//Ezebileceğimiz metotları görmek için override yazzıp bir boşluk bırakmak yeterli.
        {
            Console.WriteLine(string.Format("{0} isimli isci işlem yaptı.", KullaniciAdi));
        }
    }

    class Yönetici:Personel
    {
        public override void LogAl()
        {
            Console.WriteLine(string.Format("{0} isimli Yönetici işlem yaptı.", KullaniciAdi));
        }
    }

}
