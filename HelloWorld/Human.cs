using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Human
    {
        //Member variables
        private string firstName = "";
        private string lastName = "";
        private int age = 0;
        private string eyeColour = "";

        //Empty Constructor
        public Human()
        {
            Console.WriteLine("\nConstructor Called. Object Created.");
        }

        //No Age Constructor
        public Human(string firstName, string lastName, string eyeColour)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColour = eyeColour;
        }

        //No Eye Colour Constructor
        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        //No lastName Constructor
        public Human(string firstName, int age, string eyeColour)
        {
            this.firstName = firstName;
            this.age = age;
            this.eyeColour = eyeColour;
        }

        //No firstName Constructor
        public Human(int age, string lastName, string eyeColour)
        {
            this.lastName = lastName;
            this.age = age;
            this.eyeColour = eyeColour;
        }

        //Paramaterized Constructor
        public Human(string firstName, string lastName, int age, string eyeColour)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.eyeColour = eyeColour;
        }

        public void IntroduceMyself()
        {
            if (age == 0 && firstName.Equals("") && lastName.Equals("") && eyeColour.Equals("")) // No info added
            {
                Console.WriteLine("Empty (No information entered for this person...)");
            }
            else if (firstName.Equals("")) // No first name
            {
                Console.WriteLine("Hi, my last name is {1}. I'm {0} years old and I have {2} coloured eyes.", age, lastName, eyeColour);
            }
            else if (lastName.Equals("")) // No last name
            {
                Console.WriteLine("Hi, my first name is {0}. I'm {1} years old and I have {2} coloured eyes.", firstName, age, eyeColour);
            }
            else if (eyeColour.Equals("")) // No eye colour
            {
                Console.WriteLine("Hi, my name is {0} {1}. I'm {2} years old.", firstName, lastName, age);
            }
            else if (age == 0) // No age
            {
                Console.WriteLine("Hi, my name is {0} {1}. I have {2} coloured eyes.", firstName, lastName, eyeColour);
            }
            else //All info entered
                Console.WriteLine("Hi, my name is {0} {1}. I'm {2} years old and I have {3} coloured eyes.", firstName, lastName, age, eyeColour);
        }
    }
}
