using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_21_Üye_Erişim_Belirleyicileri
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        class arac
        {
            //public ve privete aslında bir üye erişim belirleyicisidir 
            //çok üye erişim belirleyicisi vardır ilerleyen derslerde göstericem.
            
            private string Model;
            public string Plaka;

            private string Yılı { get; set; }
            public string Durumu { get; private set; }  
        }

    }
}
