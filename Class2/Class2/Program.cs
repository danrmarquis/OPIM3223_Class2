using System;

namespace Class2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            // STRINGS

            // The most simple example of C#: Hello World!
            Console.WriteLine("Hello World!");

            // strings and variables
            string newString = "Hey there!";
            Console.WriteLine(newString);

            // string interpolation
            string longerString = newString + "what's up?";

            Console.WriteLine($"Longer string: {longerString}");

            // methods and parameters
            void newMethod()
            {
                Console.WriteLine("Called the function");
            }

            newMethod();

            string location = "UConn";
            Console.WriteLine(location.ToUpper());

            // searching strings

            bool value = location.Contains("on");
            Console.WriteLine(value);


            // LOGIC

            // if statements
            bool decision = true;

            if(decision)
            {
                Console.WriteLine("The value was true!");
            }


            // else
            bool anotherDecision = false;

            if(anotherDecision)
            {
                Console.WriteLine("The value was true");
            } else
            {
                Console.WriteLine("The value was false");
            }

            // operators
            // AND &&
            // OR ||

            bool value1 = true;
            bool value2 = false;

            if(value1 || value2)
            {
                Console.WriteLine("Block 1");
            } else
            {
                Console.WriteLine("Block 2");
            }

            int int1 = 3;
            int int2 = 6;

            if(int1 == int2)
            {

            } else
            {

            }

            // loops (while and for)
            int whileInt = 5;

            while(whileInt < 10)
            {
                Console.WriteLine("Looped again!");
                whileInt++;
            }

            for(int i = 10; i < 20; i++)
            {
                Console.WriteLine(i);
            }


            // NUMBERS

            // basic math
            int newInteger = 5;
            Console.WriteLine(newInteger);

            decimal newDec = 6.666666M;


            // order of operations
            int math = (1 + 2) - 4 * 4 / 5;
            Console.WriteLine(math);

            // integers and min/max

            // doubles
            double newDouble = 5.5;
            Console.WriteLine(newDouble);

            // C# built in values
            double pi = Math.PI;


        }
    }
}
