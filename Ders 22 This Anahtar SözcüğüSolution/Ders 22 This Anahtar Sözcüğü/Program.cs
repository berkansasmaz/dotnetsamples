using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ders_22_This_Anahtar_Sözcüğü
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public string metin1 = "metin1";//string değişken tanımladık public
        private string metin2 = "metin2";//string değişken tanımladık private

        public string metin3 { get; set; }//auto property tanımladık

        //Classic property tanımladık
        private string _metin4 = "metin4";

        public string metin4
        {
            get
            {
                return _metin4;
            }
            
            set
            {
                _metin4 = value;
            }
        }
        
        private void EkranaYaz()//metot tanımladık
        {
            Console.WriteLine(this.metin1);//this class içindeki propertyleri değişkenleri daha kolay çağırmamıza yardım eder kullanmassakta olur
            Console.WriteLine(this.metin2);
            Console.WriteLine(metin3);//kullanmadık ve birşey olmadı
            Console.WriteLine(metin4);

            this.EkranaYaz2(this.metin4);//this kullanmak kolaylık sağlar ve okumayı kolaylaştırır
            //this kullan class içinde property arıcagına this. koy ve class için bütün propertyleri gör


        }

        private void EkranaYaz2(string metin)
        {
            Console.WriteLine(metin);
        }

    }
}
