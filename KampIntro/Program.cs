using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği.
            //metinsel ifadeler tek tırnak ile tutulamaz.
            string kategoriEtiketi = "kategori";
            
            //Tam sayıları tutar. Belirli bir sınırı vardır.
            int ogrenciSayısı = 32000;

            //Ondalıklı sayıları tutar.
            double faizOranı = 1.45;

            // true ve false değerleri alır.
            bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Sisteme giriş yapılmış");
            }
            else
            {
                Console.WriteLine("Sisteme giriş yapılmamış");
            }

        }
    }
}
