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


            // -- BEHAVIORAL Design Pattern --
            Console.WriteLine("\n>> BEHAVIORAL Design Pattern  (Iterator)");

            Collection<int> intCollection = new Collection<int>();
            Iterator<int> ICIterator = intCollection.CreateIterator();

            intCollection.Add(300);
            intCollection.Add(20);
            intCollection.Add(1);

            Console.WriteLine("> Int Collection Traversal:");
            while (ICIterator.HasNext()) Console.WriteLine(ICIterator.Next().ToString());

            Collection<string> stringCollection = new Collection<string>();
            Iterator<string> SIterator = stringCollection.CreateIterator();

            stringCollection.Add("First");
            stringCollection.Add("Second");
            stringCollection.Add("Third");

            Console.WriteLine("> String Collection Traversal:");
            while (SIterator.HasNext()) Console.WriteLine(SIterator.Next().ToString());


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
