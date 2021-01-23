using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kampı";
            string kurs2 = "programlamaya başlangıç temel kurs";
            string kurs3 = "java";
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı", "programlamaya başlangıç temel kurs", "java", "python" };



            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
                Console.WriteLine("for bitti");
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            
            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
