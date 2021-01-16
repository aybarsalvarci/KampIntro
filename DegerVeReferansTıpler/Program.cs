using System;

namespace DegerVeReferansTıpler
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            // sayi 1 = 30 çıktısını verir.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            
            //sayilar1[0] = 999 cıktısını verir.
            //pointer işlemi.
            /* 
             * sayilar1 sayilar2 ye eşlendiğinde değerler değil adres numaraları eşlenir.
             * sayilar2 nin 0 indexi değiştigi zaman bu adresteki değer değişir.
             * sayilar1 de bu adresi kullandığı için son verilen değer geçerli olacacktır.
             */
        }
    }
}
