using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            //string kurs1 = "Yazılım Geliştirici Yetiştirme Kursu";
            //string kurs2 = "Programlamaya Başlamak İçin Temel Kurs";
            //string kurs3 = "Java Kursu";

            //array - dizi 

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kursu", "Programlamaya Başlamak İçin Temel Kurs" , "Java Kursu", "Python", "C$#"};

            /*
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            */


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


        }
    }
}
