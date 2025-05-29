using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC360_SB
{
    // Facade
    public class Facade
    {
        private SubsystemOne subsystem1;

        private SubsystemTwo subsystem2;


        public Facade(SubsystemOne subsystem1, SubsystemTwo subsystem2)
        {
            this.subsystem1 = subsystem1;
            this.subsystem2 = subsystem2;
        }

        public string Operation()
        {
            string result = "> Facade: Start Subsystems:\n";
            result += subsystem1.Start() + "\n";
            result += subsystem2.Init() + "\n";

            result += "> Facade: Perform Subsystem Actions:\n";
            result += subsystem1.DoAction() + "\n";
            result += subsystem2.Engage() + "\n";

            return result;
        }
    }


    // Subsystem Class #1
    public class SubsystemOne
    {
        public string Start()
        {
            return "SubsystemOne: Ready!";
        }

        public string DoAction()
        {
            return "SubsystemOne: 1 + 1 = " + (1 + 1).ToString();
        }
    }


    // Subsystem Class #2
    public class SubsystemTwo
    {
        public string Init()
        {
            return "SubsystemTwo: Initialized!";
        }

        public string Engage()
        {
            return "SubsystemTwo: ENGAGED!!!";
        }
    }


    // Client
    public class Client
    {
        public static void ClientCode(Facade facade)
        {
            Console.WriteLine(facade.Operation());
        }
    }
}
