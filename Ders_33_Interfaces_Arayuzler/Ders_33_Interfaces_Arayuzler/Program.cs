using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_33_Interfaces_Arayuzler
{
    class Program
    {
        static void Main(string[] args)
        {
            //IOrtakFonksiyonlar ii=new IOrtakFonksiyonlar();   //diye türetemeyizzz böyle birşey söz konusu bile olamaz
            //interfaceleri direkt olarak kullanamayız intherit edildigi classları kullanabiliriz interfaceler class değildir interface!=class
            //metot tanımları ile yazılacak metotları biziim için ilgili classa ekler
            //iki farklı tip aynı tipe eşitleme sağlar
            //inheritten farklı olarak interface implement edilir dolayısıyla birden çok interface'i bir classa virgül ile ayırarak ekleyebiliriz
            /* 
               normalde araba I1=new araba(); deriz lakin böylede tanımlayabiliriz mantığı araba classında 
               IortakFonksiyonlarda miras aldığımız için bir classın türetildiği classdanda nesne oluşturabiliriz
               aynı şekil interface yerine gercek bir class dan inherit alsak bile bu kural gecerlidir
            */
            IOrtakFonksiyonlar Araba1=new Araba();//araba classı IOrtakFonksiyonlardan türetildiği için kullanılabilir
            IOrtakFonksiyonlar Parca1=new Parca();//ikisi de aynı inter face den türediği için artık ikisini eşitleyebiliriz
            Parca1 = Araba1;//ikiside aynı interfaceden türediği için eşitleyebiliriz.
            Araba1.Sifirla();//araba1. dedikten sonra arababilgilerinikaydet metodu gelmedi gelmemesinin sebebi nesneyi IOrtakFonksiyonlar ile tanımladık yani sadece interface içindekiler gelir
            Parca1.Sifirla();

            Araba aa=new Araba();
            aa.ArabaBilgileriniKaydet();//şimdi geldi sebebi araba clası ile nesneyi oluşturmam.



            

            Console.ReadKey();
        }
    }

    interface IOrtakFonksiyonlar//inerface isimleri I ile başlamak zorunda koymassan birşey olmaz ama yazılımcılar arası kural gibi düşün.
    {
        //buraya yazılanlar otomatik olarak public oluyor 
        void Sifirla();//böyle tanımlana bilir ne baştaki public yada private nede kod yazılmaz interface içinde sadece cinsi ve ismi
        string Metinver();
    }
    
    class Araba:IOrtakFonksiyonlar//inherit miras alma gibi kullanılır ama hata verir altına gelince ampul cıkar implement etmenizi ister İnterface kesin kullanmamız gerek yoksa hata alırız 
    {
        public int Yili { get; set; }
        public string Modeli { get; set; }
        public string Marka { get; set; }

        public void ArabaBilgileriniKaydet()
        {
            //veritabanına yada bilgisayarda bir dosyaya verileri kaydetsin.
        }
        
        public void Sifirla()//interfacei miras olarak aldığımızda interface içerisin dekileri o class ıcınde kullanmak zorundayız 
        {
            this.Yili = -1;
            this.Modeli = string.Empty;
            this.Marka = String.Empty;
        }

        public string Metinver()//metinver yazdıgımız da cıkar ve süslü parantez içini kendimiz dolduruyoruz yada miras almada kırmızı cızgının üstüne gelip implement ederek kullanabiliriz
        {
            return this.Yili + " " + this.Yili + " " + this.Marka;
        }



        //public void Sifirla()  //interface tanımlayıp yapmak daha faydalı hata oranını azaltır kesin kullanmamız gerektiği için
        //{
        //    this.Yili = -1;
        //    this.Modeli = string.Empty;
        //    this.Marka=String.Empty;
        //}

        //public string Metinver()
        //{
        //    return this.Yili + " " + this.Yili + " " + this.Marka;
        //} 
    }

    class Parca:IOrtakFonksiyonlar//normalde inherit da yani miras almada bir classa birtane inherit ekleyebilir ama interfaceden istedğimiz kadar bir classa ekleyebilir 
    {
        public int Parcakodu { get; set; }
        public string ParcaAdi { get; set; }
        
        public void Parcabilgisikaydet()
        {
            //veritabanına yada bilgisayarda bir dosyaya verileri kaydetsin.
        }
        
        public void Sifirla()
        {
            this.Parcakodu = -1;
            this.ParcaAdi = String.Empty;
        }

        public string Metinver()
        {
            return this.Parcakodu + " " + this.ParcaAdi;
        }
     
        
    }

}
