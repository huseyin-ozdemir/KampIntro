using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManger
    {
        //Method injection
        //List yapıp birden fazla loglama yapabilirsin.
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvuru bilgileri değerlendirme ...

            //Tek bir manageer a  bağımlı olmadı hepsini referans verdik 
            //Hangi krediyi gönderirsen o çalışır..

            krediManager.Hesapla();
            loggerService.Log();        }
        
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
                
            }
        }
    }
}
