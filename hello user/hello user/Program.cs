using System;

namespace hello_user
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("hello {0}", name);  // or  Console.WriteLine("hello " + name);
        }
    }
}
