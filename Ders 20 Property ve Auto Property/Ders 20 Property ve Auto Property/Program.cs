using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ders_20_Property_ve_Auto_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            AlanKodu A=new AlanKodu();
            Tel T=new Tel();

            T.Telno = "544 30 828 30";
            A.alankodu = "5443082830";
            
            Console.WriteLine(T.Telno);
            Console.WriteLine(A.alankodu);
            

            Console.ReadKey();
        }

        //Property
        class Tel //bu class içinde property yaptık bu bir kalıptır ezberle
        {
            private string _Telno;//dışarıdan engelli olduğu halde kulanabiliriz property sayesinde

            public string Telno
            {
                get
                {
                    return _Telno;
                }

                set
                {
                    _Telno = value;
                }
            }


        }
        //aslında propety auto property aynı sadece auto da birazda ha kolay ama işlenişi property ile aynı hiç bir fark yok
        //Auto Property
        class AlanKodu
        {
            public string alankodu { get; set; }
        }

       
    }
}
