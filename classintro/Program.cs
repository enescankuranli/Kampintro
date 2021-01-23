using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {

            kurs kurs1 = new kurs();
            kurs1.kursadi = "c#";
            kurs1.egitmen = "engin demiroğ";
            kurs1.ızlenmeoranı = 68;

            kurs kurs2 = new kurs();
            kurs2.kursadi = "java";
            kurs2.egitmen = "kerem demiroğ";
            kurs2.ızlenmeoranı = 64;


            kurs kurs3 = new kurs();
            kurs3.kursadi = "python";
            kurs3.egitmen = "enes demiroğ";
            kurs3.ızlenmeoranı = 6-74;

           Console.WriteLine(kurs1.kursadi + " " + kurs1.egitmen);

            kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursadi+ " " + kurs.egitmen);
                    
            }
            

            


            //Console.WriteLine("Hello World!");
        }
    }

    class kurs
    {
        public string kursadi { get; set; }
        public string egitmen { get; set; } 
        public int ızlenmeoranı { get; set; }
    }
    

    }

