using System;

namespace Generics1
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();

            box.Add(1);
            Console.WriteLine( "Added with count {0}",box.count);
            box.Add(2);
            Console.WriteLine("Added with count {0}", box.count);
            box.Add(3);
            Console.WriteLine("Added with count {0}", box.count);
            Console.WriteLine(box.Remove());
            Console.WriteLine("Removed with count {0}", box.count);
            box.Add(4);
            Console.WriteLine("Added with count {0}", box.count);
            box.Add(5);
            Console.WriteLine("Added with count {0}", box.count);
            Console.WriteLine(box.Remove());
            Console.WriteLine("Removed with count {0}", box.count);
        }
    }
}
