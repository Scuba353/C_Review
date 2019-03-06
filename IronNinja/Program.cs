using System;
using System.Collections.Generic;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Ninja A= new SweetTooth();
            Ninja A2= new SpiceHound();
            Buffet B= new Buffet();
            Console.WriteLine(A);
            Console.WriteLine(A2);
            Console.WriteLine(B);
            IConsumable yums= B.Serve();
            A.Eat(yums);
            Console.WriteLine(A);
            IConsumable yums2= B.Serve();
            A2.Eat(yums2);
            Console.WriteLine(A2);
            IConsumable yums3= B.Serve();
            IConsumable yums4= B.Serve();
            IConsumable yums5= B.Serve();
            A.Eat(yums3);
            A.Eat(yums4);
            A2.Eat(yums5);

            
        
        }
    }
}
