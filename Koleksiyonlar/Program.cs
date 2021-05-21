using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> isimler2 = new List<string> { "zelis","minik"};
            isimler2.Add("ayde");

            foreach(var x in isimler2)
            {
                Console.WriteLine(x);
                
            }
        }
    }
}
