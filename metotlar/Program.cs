using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            double fiyati = 15;
            string aciklama = "amasya elması";

            string[] meyveler = new string[] { };
            
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "çilek";
            urun2.Fiyati = 10;
            urun2.Aciklama = "çilek gibi çilek";

            Urun[] urunler = new Urun[] {urun1,urun2 };
            foreach (Urun urun in urunler)
            {       
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("----------Metodlar--------------");
            //intsance - örnek
            Sepetmanager sepetmanager = new Sepetmanager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2("ARMUT", "yeşil armut", 12);
            sepetmanager.Ekle2("ARMUT", "sarı armut", 10);

        }   
    }
}
