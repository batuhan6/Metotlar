using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayı1, int sayı2)
        {
            int toplam = sayı1 + sayı2;
            Console.WriteLine("Sonuç: " + toplam);
        }
        public void Cikarma(int sayı1, int sayı2)
        {
            int x = sayı1 - sayı2;
            Console.WriteLine("Sonuç: " + x);
        }
        public void Bolme(int sayı1, int sayı2)
        {
            int y = sayı1 / sayı2;
            Console.WriteLine("Sonuç: " + y);
        }
        public void Carpma(int sayı1, int sayı2)
        {
            int z = sayı1 * sayı2;
            Console.WriteLine("Sonuç: " + z);
        }
    }
}
