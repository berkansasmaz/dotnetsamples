using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_31_Abstract_Soyut_Sınıflar
{
    class Program
    {
        static void Main(string[] args)
        {
            //kisi k1=new kisi();          //yapamayız abstract classlar tanımlamaz böyle 
            insan i1=new insan();
            i1.Ad = "Berkan";
            i1.Soyad = "Şaşmaz";
            i1.EkranaYaz();

            insanünvan i2=new insanünvan();
            i2.Ad = "Burak";
            i2.Soyad = "ŞAŞMAZ";
            i2.ünvan = "MSP";

            Console.ReadKey();
        }
    }

    abstract class kisi //abstract kullandığımız için bu class new kisi ile nesne oluşturamayız bu sadece miras işlemlerinde kullanılır
    {
        public string Ad { get; set; }//istersek bunlarıda abstract tanımlayabiliriz.
        public string Soyad { get; set; }

        public abstract void EkranaYaz(); //birde abstract sınıfların içine tanımlanan metotlar abstract metotdur.
        //abstract metotlar ezilmek zorunda yani aşağıda insan hata verir normalde hatanın altına gelip ampule tıklayıp Imlemented tıklarsa hata çözulmuş olur
        //bunun altına console.writeline(ad+soyad); desek bile aşagıda eziceğimiz için bu kodun önemi yokkkkkkkkk
    }

    class insan : kisi //abstract classın ıcındekılerı burada kullanmaya yarar ve sadece bunu new kisi olarak oluştursak yeter
    {
            public override void EkranaYaz() //implemented tıklayınca bu metot oluşor virtual sanal metot dan farkı sanal metot da ezmesek bile yani override diyip base.Ekranayaz() diyerek ezmemiş oluruz ama bunda ezme şarttttt
            {
                  //Virtual den farkı virtualsanal metotdun override farkı override ezmesekde olur base.ekranayaz() diyerek ezmeye biliyorduk bunda kesin ezicezz kaçarı yok
                  Console.WriteLine(Ad+" "+Soyad);//ve yukarıdaki abstract metot ezildi 
            }
    }

    class insanünvan : kisi
    {
        public string ünvan { get; set; }
        public override void EkranaYaz()//override diyerek yazdırılır
        {
            Console.WriteLine(ünvan+" "+Ad+" "+Soyad);
        }
    }



}
