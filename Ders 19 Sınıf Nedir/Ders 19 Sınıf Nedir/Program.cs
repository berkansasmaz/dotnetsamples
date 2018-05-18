using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_19_Sınıf_Nedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Kişi k =new Kişi();
            
            k.ad ="Berkan";
            k.soyad ="ŞAŞMAZ";
            k.yaş =20; 
            k.T. Doğum_Tarihi="1997";
            k.T.Kimlik_No ="38156871985";
            k.T.Sicil_NO = "5645846";
            
          

            k.T.Kimlikbilgileri();
            k.AdSoyadYaz();

            Console.ReadKey();
        }
    }

    class Kişi
    {
        public TC T=new TC();

        private int id;        //ulaşılamaz private çünkü
        public string ad;
        public string soyad;
        public int yaş;

        public void AdSoyadYaz()
        {
            Console.WriteLine(ad+" "+soyad+" "+yaş);
        }

        private int yaşgetir()         //public olmadğı için bu class dışında kullanılamaz 
        {
            return yaş;
        }

    }

    class TC
    {
        public string Kimlik_No;
        public string Sicil_NO;
        public string Doğum_Tarihi;

        public void Kimlikbilgileri()
        {
           Console.WriteLine("Tc"+" : "+Kimlik_No+" "+"Sicil No"+" : "+Sicil_NO+" "+"Doğum Tarihi"+" : "+Doğum_Tarihi);
        }
       
    }
   
}
