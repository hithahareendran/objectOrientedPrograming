using System;

namespace Generics2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Peter");
            int[] integers = ArrayCreator.Create(10, 33);

            Console.WriteLine(String.Join(",", strings));
            Console.WriteLine(String.Join(",", integers));
        }
    }

}
