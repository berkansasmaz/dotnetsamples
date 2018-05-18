using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_8_Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
             
            //BOXİNG yani object i değişkene eşitlemek.
            int a = 10;
            float f = 12.5f;//float sonuna f koymayı unutma
            string m = "berkan";
            //null boş demek
            object obj = null; //object bir nesne tabanlı pencere gibi düşün ve bu pencerenin içine her şey koyabilirim null ise boş demek 

            obj = a;//kutunun içine int a değeri attık
            obj = f;//kutunun içine int f değeri attık
            obj = m;//kutunun içine int m değeri attık

            //UNBOXİNG yani object ten bir değişken çıkarmak

            obj = a; //kutunun içine int değere sahip değişken var şuan

            a = (int)obj;// çıkarma işleminde neyi çıkartıcaksak onun classını obj nin başına yazmak zorundayiz

            obj = f;
            f = (float)obj;

            obj = m;
            m = (string)obj;//alttaki satırla bu satır aynı anlama gelir
            m = obj.ToString();//üsteki satırla bu satır aynı anlama gelir

            Console.WriteLine(m);
            Console.WriteLine(f);
            Console.WriteLine(a);


                             

            Console.ReadKey();
        }
    }
}
