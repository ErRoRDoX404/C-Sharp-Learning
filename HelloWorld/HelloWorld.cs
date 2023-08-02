using System.Diagnostics.Metrics;
using System.Transactions;

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

            //Input Strings
            Console.WriteLine("Please enter your name: ");
            string userInput = Console.ReadLine();

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
            Console.WriteLine("Greetings: " + userInput);
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
            Console.WriteLine("\nMy birthday will always be on the: {0}", birthdayDate, "\n");


            //Method calling
            WriteSomething();
            WriteSomethingSpecific("\nArgument for a method\n");

            //Addition method write
            Console.WriteLine("\nMethods:");
            Console.WriteLine(num1 + " + " + num2 + " = " + Addition(num1,num2)); // 10 + 15 = 25
            Console.WriteLine(Addition(Addition(num1, num1), Addition(num2, num2))); // (10 + 10) + (15 + 15) = 50

            //Multiply method write
            Console.WriteLine(num1 + " x " + num2 + " = " + Multiply(num1, num2)); // 10 x 15 = 150
            Console.WriteLine(Multiply(Multiply(num1, num2), Multiply(num1, num2))); // (10 x 15) x (10 x 15) = 22500

            //Division method write
            Console.WriteLine(num1 + " / " + num2 + " = " + Divide(num1, num2)); // 10 x 15 = 150
            Console.WriteLine(Divide(Divide(num1, num2), Divide(num1, num2))); // (10 x 15) x (10 x 15) = 22500

            // UserCalculate(); // With validation

            // UserDivide(); // With validation

            Operators();

            Console.Read();
        }

        //Methods
        public static void WriteSomething()
        {
            Console.WriteLine("\nI am called from a method");
        }

        //Method with Parameter
        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        //Method with two parameters
        public static int Addition(int num1, int num2)
        {
            return num1 + num2; //Num1 = 10 , Num2 = 15
        }

        //Methods with two parameters
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2; //Num1 = 10 , Num2 = 15
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2; //Num1 = 10 , Num2 = 15
        }

        //User input method
        public static int UserCalculate()
        {
            int i = 0;

            //Asking the user to add two numbers together
            while (i < 1)
            {
                Console.WriteLine("\nAdd two numbers together (!!! ONLY ENTER NUMBERS !!!)"); //No validation so error will appear with any input other than numbers
                Console.WriteLine("Please enter your first number: ");
                string userNumberOne = Console.ReadLine();

                Console.WriteLine("Please enter your second number: ");
                string userNumberTwo = Console.ReadLine();

                try
                {
                    int userAdditionResult = Addition(Int32.Parse(userNumberOne), Int32.Parse(userNumberTwo));
                    Console.WriteLine(userNumberOne + " + " + userNumberTwo + " = " + userAdditionResult);
                    i = 1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Format exception, Please make sure you only enter numbers! (Int Type)");
                    i = 0;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Overflow exception, user inputs were either too long or too short for Int32");
                    i = 0;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Null exception, the user's input was empty (Null)");
                    i = 0;
                }
            }
            return 0;
        }

        public static double UserDivide()
        {
            int i = 0;

            //Asking the user to divide two numbers
            while (i < 1)
            {
                Console.WriteLine("\nDivide with two numbers (!!! ONLY ENTER NUMBERS !!!)"); //No validation so error will appear with any input other than numbers
                Console.WriteLine("Please enter your first number: ");
                string userNumberOne = Console.ReadLine();

                Console.WriteLine("Please enter your second number: ");
                string userNumberTwo = Console.ReadLine();

                try
                {
                    double userNumberOneConverted = Double.Parse(userNumberOne);
                    double userNumberTwoConverted = Double.Parse(userNumberTwo);
                    double userDivisionResult = Divide(Double.Parse(userNumberOne), Double.Parse(userNumberTwo));
                    Console.WriteLine("Your first number was " + userNumberOneConverted + " and the second number was " + userNumberTwoConverted);
                    Console.WriteLine(userNumberOne + " / " + userNumberTwo + " = " + userDivisionResult);
                    i = 1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Format exception, Please make sure you only enter numbers! (Int Type)");
                    i = 0;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Overflow exception, user inputs were either too long or too short for Int32");
                    i = 0;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Null exception, the user's input was empty (Null)");
                    i = 0;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Divide By Zero Exception, the user's input included a zero (undefined result)");
                }
            }
            return 0;
        }

        //Operators
        public static void Operators()
        {

            int num1 = 5;
            int num2 = 3;
            int num3;

            Console.WriteLine("\nOperators: ");
            Console.WriteLine("num1 is {0}", num1);
            Console.WriteLine("num2 is {0}", num2);

            //unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3); // Returns -5

            bool isNight = true;
            Console.WriteLine("Is it night time?: {0}", !isNight); // Returns false

            //increment operators
            Console.WriteLine("\nIncrement Operators: ");
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num); // Adds 1 to num = 1
            Console.WriteLine("num is {0}", num++); // Adds 1 to num = 2

            //pre-increment
            Console.WriteLine("num is {0}", ++num); // Adds 1 to num = 3

            //Decrement operators
            Console.WriteLine("\nDecrement Operators: ");
            num--;
            Console.WriteLine("num is {0}", num); // Removes 1 from num = 2
            Console.WriteLine("num is {0}", num--); // Removes 1 from num = 1

            //pre-Decrement
            Console.WriteLine("num is {0}", --num); // Removes 1 from num = 0
        }

    }
}
