using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders28_Inheritance_Miras_Alma
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    /*
      Inheritance yani miras alma classlarda tekrar eden yani aşağıda ad soyad hep tekrar ediyor onun için yeni bir class oluştrurup
      ve içinde tekrar edenleri yerleştirip uyguluyoruz Inheritance amacı kod kalabalığı yapmamak ve kodu değiştirmek istediğimizde
      ad yerine adi yaptığımız da heryerde değil bir yerde değişiklik yapmak için kullanımı aşagıdaki gibidir
    */
    class Canlı
    {
        public string Kangrubu { get; set; }
    }
    class  İnsan : Canlı//bir classs sadece bir kere miras alabilir
    {
        //mesela "Ad" ı "Adı" olarak değitiricez classlarda "Ad" olarak kullandığımız için hata verir ama üzerinde biraz bekleyip yandaki piramite tıklayıp rename edicez ve heryerde değişmiş olucak
        public string Adı { get; set; }
        public string Soyad { get; set; }
        public decimal Maaş { get; set; } //Decimal para birimlerinde kullanılır genelde burada çalışanın maaşını belirtmek için

        public void MaaşAl()
        {
            //Maaşlar hesaba yatırılır
        }
    }

    class Çalışan : İnsan //Inheritance kullanımı böyledir ve this kelimesinde bir üsteki classa ait miras aldığımız classın içini de kullanabiliriz
    {
        //public string Ad { get; set; }
        //public string Soyad { get; set; }
        
        public Çalışan()//maaş belirttik constructor de işlemişdik ctor yazıp çıktı direk constructor ve maaşı belirledik
        {
            this.Kangrubu = "ab-"; //insanada canlı classını bağladığımız için canlı classıda artık kullanılabilir
            //maaşlar farklı olduğu için miras almada kullanamayız
            Maaş = 1000;
        }

        public void Görev1()//çalışan la yöneticinin patronun görevleri aynı olmadığı için miras alma kullanılamaz
        {
            this.Adı = "Berkan";
            this.MaaşAl();
        }
    }

    class Yönetici : İnsan
    {
        //public string Ad { get; set; }
        //public string Soyad { get; set; }

       // public decimal Maaş { get; set; } //kod hepsinde olduğu için miras alma özelliğini kullanarak insan classında yazdık burada gerek yok

        public Yönetici()//ctor ile yani constructor ile maaşı belirledik
        {
            Maaş = 3000;
        }

        public void Görev1()
        {       
            this.Soyad = "Şaşmaz";
            this.MaaşAl();
        }
    }

    class Patron : İnsan
    {
        //public string Ad { get; set; }
        //public string Soyad { get; set; }

        //public decimal Maaş { get; set; }//kod hepsinde olduğu için miras alma özelliğini kullanarak insan classında yazdık burada gerek yok

        public Patron()//ctor ile yani constructor ile maaşı belirledik
        {
            Maaş = 8000;
        }

        public void Görev1()
        {
            this.MaaşAl();  
        }
    }
}
