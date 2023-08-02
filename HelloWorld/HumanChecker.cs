using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class HumanChecker
    {
        static void NotMain(string[] args) // Change from "NotMain" to "Main" to use
        {
            //Human instance - From Human.cs - All Paramaters
            Human bilbo = new Human("Bilbo", "Baggins", 124, "Blue");
            bilbo.IntroduceMyself();

            //No last name
            Human kat = new Human("Katarina", 300, "Hazel");
            kat.IntroduceMyself();

            //No age
            Human maggie = new Human("Maggie", "Simpson", "Black");
            maggie.IntroduceMyself();

            //No eye colour
            Human geralt = new Human("Geralt", "Rivea", 47);
            geralt.IntroduceMyself();

            //No first name
            Human anderson = new Human(30, "Anderson", "Brown");
            anderson.IntroduceMyself();

            //No paramaters
            Human empty = new Human();
            empty.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
