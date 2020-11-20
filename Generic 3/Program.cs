using System;
using System.Globalization;

namespace Generic_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var scale = new Scale<int>(10,20);
            Console.WriteLine(scale.GetHeavier());
            scale = new Scale<int>(10, 10);
            Console.WriteLine(scale.GetHeavier());
            var scale1 = new Scale<String>("cat", "dog");
            Console.WriteLine(scale1.GetHeavier());
            scale1 = new Scale<String>("cat", "cat");
            Console.WriteLine(scale1.GetHeavier());
        }
    }
}
