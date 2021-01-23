using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety =tip güvenliği
            string kategorietiketi = "kategori";
            Console.WriteLine("kategorietiketi");
            int ogrencisayisi = 320000;
            double fizorani = 1.45;
            bool sistemegirisyapmismi = true;
            double dolardun = 7.35;
;           double dolarbugun = 7.35;
            if (dolardun > dolarbugun) 
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolardun<dolarbugun)
            {
                Console.WriteLine("artış butonu");
            }

            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            if (sistemegirisyapmismi == true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }

            else
            {
                Console.WriteLine("giriş yap butonu");
            }

        }
             
            
            
                    
    }
    
}
