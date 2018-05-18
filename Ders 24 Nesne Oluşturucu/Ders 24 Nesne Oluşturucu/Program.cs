using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_24_Nesne_Oluşturucu
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi K1=new Kisi();//burada new kisi derken bir .net görünmez constructur oluşturur 

            K1.Ad = "Berkan";//adı tanımladım
            
            /*yaşı burada tanımlamadım epostayıda ama constructur içinde tanımladığım için
            ve constructur içinde ad soyad tanımladım ama adı burada da tanımladığım için
            constuructur da ki adı ezmiş oldum ve buradaki geçerli oldu.
             */
            Console.Clear();
            Console.WriteLine(K1.Ad);
            Console.WriteLine(K1.Soyad);
            Console.WriteLine(K1.Yas);
            Console.WriteLine(K1.Eposta);
            Console.ReadKey();

        }
    }
}
