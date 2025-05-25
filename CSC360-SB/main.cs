using System;

namespace CSC360_SB
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" -- Start Program -- \n");

            // -- CREATIONAL Design Pattern --
            Console.WriteLine(">> CREATIONAL Design Pattern");

            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            if (singleton1 == singleton2) Console.WriteLine("Singleton implementation succeeded!\n");
            else Console.WriteLine("Singleton implementation failed.\n");

            Console.WriteLine(" --  End Program  -- \n");
        }
    }
}
