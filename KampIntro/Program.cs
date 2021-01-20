using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 320000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.56;
            //dolar hesap
            if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");

            }
            else if (dolarBugun<dolarDun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            //sistem girişi
            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("sistemeGirisYapmismi yap butonu");
            }
            
        }
    }
}
