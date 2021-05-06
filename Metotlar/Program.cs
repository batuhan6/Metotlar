using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string urunAdi2 = "Kavun";
            double fiyatı2 = 15;
            string aciklama2 = "Amasya elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 1;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.ekle(urun2);
            sepetManager.ekle(urun1);
        }
    }
}
