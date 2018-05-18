using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_27_Encapsulation_Kapsülleme
{
    class Program
    {
        /*
        Encapsulation değişkenleri  saklamak başka kullanıcıların görmesini istemediğimiz başka kullanıcıların
        değiştirmesini istemediğimizde gizleme işlemine denir.
        */
        static void Main(string[] args)
        {
            kisi k=new kisi();//nesneyi oluşturduk
            k.Ad = "Berkan";//Adı tanımladık
            Console.WriteLine(k.Ad);

            Console.ReadKey();
        }
    }

    class kisi
    {
        //Property
        //Property aslında bir gizleme işlemidir yani private string _Ad gizlemiş olduk yararı ise diğer kullanıcılar değiştirmesin diye 
                        //private string _Ad;

                        //public string Ad
                        //{
                        //    get { return _Ad; }
                        //    set { _Ad = value; }
                        //}

       //Auto Property oluşturduk aslında property ile aynı .net bize kolaylık sağlamış aslında auto property işlenirken normal propertye dönüşür
        public string Ad { get; set; }

    }

}
