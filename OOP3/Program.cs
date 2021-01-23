using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyazKrediManager = new IhtiyacKrediManager();
            

            IKrediManager tasitKrediManager = new TasitKrediManager();
            

            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileBaseLoggerService();


            BasvuruManger basvuruManger = new BasvuruManger();
            basvuruManger.BasvuruYap(new EsnafKrediManager(), fileLoggerService);

            //Listeden başvuruya uyan kredileri seçip gösterir.

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyazKrediManager, tasitKrediManager };
            //basvuruManger.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
