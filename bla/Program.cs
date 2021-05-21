using System;

namespace bla
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 10;
            var result = Add(ref x, y);
            Console.WriteLine(x);
            Console.WriteLine(result);

            int number1 = 200;
            int number2 = 100;
            var result2 = Add1(out number1, number2);



            Console.WriteLine(result2);
            Console.WriteLine(number1);

        }

        static int Add(ref int x, int y)
        {
            x = 30;
            return x + y;
        }

        static int Add1(out int number1, int number2)
        {
            number1 = 20;
            return number1 + number2;
        }
    }
}
