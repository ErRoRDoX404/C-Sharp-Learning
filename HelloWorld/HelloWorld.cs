namespace HelloWorld
{
    class HelloWorld
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            //Ints
            int num1 = 10;
            int num2 = 15;
            int num3 = num1 + num2;
            int castInt;

            //Doubles
            double d1 = 3.5;
            double d2 = 1.23456789123456789;
            double d3 = d1 + d2;
            double num1_and_d2 = num1 + d2;

            //Floats
            float f1 = 3.5f;
            float f2 = 1.23456789f;
            float f3 = f1 + f2;

            //Implicit Conversion
            int impIntNum = 12345678;
            long impLongNum = impIntNum;

            //Strings
            string name = "User";
            string greeting = "Welcome to C#, " + name;
            string stringFirstNumber = "15";
            string stringSecondNumber = "10";

            //Upper case
            string uppercaseGreeting = greeting.ToUpper();
            //Lower Case
            string lowercaseGreeting = greeting.ToLower();

            //Booleans
            bool skyIsBlue = true;

            //Constants
            const string birthdayDate = "01/01/2000";

            //-----CONSOLE PRINTS-----

            //String Write
            Console.WriteLine("Greetings:");
            Console.WriteLine(greeting);
            Console.WriteLine(uppercaseGreeting);
            Console.WriteLine(lowercaseGreeting);

            //Int, Double, Float Write
            Console.WriteLine("\nIntegers:");
            Console.WriteLine(num1 + " + " + num2 + " = " + num3);
            Console.WriteLine("\nDoubles:");
            Console.WriteLine(d1 + " + " + d2 + " = " + d3);
            Console.WriteLine("\nIntegers + Double:");
            Console.WriteLine(num1 + " + " + d2 + " = " + num1_and_d2);
            Console.WriteLine("\nFloats:");
            Console.WriteLine(f1 + " + " + f2 + " = " + f3);

            //Cast - Explicit Conversion Write
            castInt = (int)d2;
            Console.WriteLine("\nCasts:");
            Console.WriteLine(castInt);

            //Type Conversion Write
            string convertDoubleToString = d2.ToString(); // "1.2345678912345678"
            string convertFloatToString = f1.ToString(); // "3.5"
            string convertBooleanToString = skyIsBlue.ToString();

            int firstStringToInt = Int32.Parse(stringFirstNumber);
            int secondStringToInt = Int32.Parse(stringSecondNumber);
            int resultInt = firstStringToInt + secondStringToInt;

            Console.WriteLine("\nType Conversions:");
            Console.WriteLine(convertDoubleToString);
            Console.WriteLine(convertFloatToString);
            Console.WriteLine(convertBooleanToString);
            Console.WriteLine(firstStringToInt + " + " + secondStringToInt + " = " + resultInt);

            //Constant Write
            Console.WriteLine("\nMy birthday will always be on the: {0}", birthdayDate);

            Console.Read();
        }
    }
}
