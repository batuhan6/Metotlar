using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //dependency injection, Method injection
        //Sadece soyut halleri var ben somut hallerini enjekte ediyorum

        //Bu tek logger yollamak için
        //public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        //{
        //    krediManager.Hesapla();
        //    loggerService.Log();
        //}


    //birçok işlem yapmak için. Birden fazla logger yollayacam.
    public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }



        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        } 
    }
}
