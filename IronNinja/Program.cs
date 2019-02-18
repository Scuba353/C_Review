using System;
using System.Collections.Generic;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Ninga A= new Ninga();
            Buffet B= new Buffet();
            Console.WriteLine(A);
            Console.WriteLine(B);
            Food yums= B.Serve();
            A.Eat(yums);
            Console.WriteLine(A);
            Food yums2= B.Serve();
            A.Eat(yums2);
            Console.WriteLine(A);
        }
    }
}
