using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interfacelerde o interface i implemente eden class ın referans numarasını tutabiliyormuş.
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            IKrediManager tasitKrediManager = new TasitKrediManager();

            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();
            
            BasvuruManager basvuruManager = new BasvuruManager();
            //IKredi manager bir interface o new lenemez onu veremezsin

            //basvuruManager.BasvuruYap(ihtiyacKrediManager,new DatabaseLoggerService());
            //  basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);

            //  basvuruManager.BasvuruYap(new EsnafKredisiManager(), fileloggerService);

            //  basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());

            //basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService() });
            //yada buna alternatif olarak
            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);
            


            //liste yolladım istediğim kadar eleman ekleye biliyorum
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
          //  basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
