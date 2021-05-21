using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Batu");
            isimler.Add("Murat");
            isimler.Add("Buket");
            isimler.Add("Ayde");

            Console.WriteLine(isimler.Length);

            foreach(var x in isimler.Items)
            {
                Console.WriteLine(x);
            }

            

        }
    }
}
