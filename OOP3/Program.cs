using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            // subedeki arkadasin ekranı gibi düsün

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            

            IKrediManager tasitKrediManager = new TasitKrediManager();
            

            IKrediManager konutKrediManager = new KonutKrediManager();
            //Interfacelerde altındaki managerlerin ref numarasını tutabilir demek.

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager,fileLoggerService); //adam ekranda ihtiyacı secti onu gönderdik. Hangi kredi secildiyse onun kredi hesaplaması calisir. "Important info!"

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler); 

            //Interface bir ref tutucudur unutma. Ne işe yaradıgını anlarsan must oldugunu anlarsın. If lerin icinde kaybolmadan yeni logger ya da yeni kredi ekleyebilirsin kolayca.




        }
    }
}
