using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kur1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Proglamlamaya Başlangıç Kursu";
            string kurs3 = "JAVA";

            //array - dizi
            string[] kurslar = new string[] {"C#", "Python", "Yazılım Geliştirici Yetiştirme Kampı", "Proglamlamaya Başlangıç Kursu", "JAVA" };



            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("__________");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);            }
        }
    }
}
