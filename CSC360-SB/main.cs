using System;

namespace CSC360_SB
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" -- Start Program -- \n");

            // -- CREATIONAL Design Pattern --
            Console.WriteLine(">> CREATIONAL Design Pattern  (Singleton)");

            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            Console.WriteLine("> Singleton #1 = Singleton #2: " + (singleton1 == singleton2).ToString());


            // -- STRUCTURAL Design Pattern
            Console.WriteLine("\n>> STRUCTURAL Design Pattern  (Facade)");

            SubsystemOne sub1 = new SubsystemOne();
            SubsystemTwo sub2 = new SubsystemTwo();

            Facade facade = new Facade(sub1, sub2);

            Client.ClientCode(facade);

            Console.WriteLine(" --  End Program  -- \n");
        }
    }
}
