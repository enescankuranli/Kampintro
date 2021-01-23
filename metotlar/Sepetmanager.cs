using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar
{
    class Sepetmanager
    {
        //naming -convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("sepete eklendi : " + urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat);
        {
             Console.WriteLine("tebrikler. sepete eklendi: " + urunAdi);
        }



    }
}