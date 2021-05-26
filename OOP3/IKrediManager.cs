using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //log lama nedir? kimin ne zaman hangi operasyonu çağırdığıdır
    //Bir nevi olan hareketleri döktüğümüz dökümdür. Bunu ENJEKTE edeceğiz
    //Logramızı bir veri tabanında veya dosyada tutabiliriz. Yada SMS olarak atabiliriz.
    //Hepsi logluyor hepsinin imzası aynı.

    //Interface leri birbirinin alternatifi olan. Ama kod içerikleri farklı olan durumlar için kullanırız.
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}
