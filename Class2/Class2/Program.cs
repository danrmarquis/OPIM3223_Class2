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
            string sentence = "I am a sentence.";
            Console.WriteLine(sentence);

            // string interpolation

            //Creates a new string that removes the last two characters of the string
            string shorterString = sentence.Remove(sentence.Length - 2, 2);
            Console.WriteLine(shorterString);

            string longerString = sentence + " what's up?";
            Console.WriteLine($"Longer string: {longerString}");

            // methods and parameters
            double Square(double num)
            {
                return num * num;
            }

            Console.WriteLine(Square(2));

           
            string location = "UConn";
            Console.WriteLine(location.ToUpper());

            // searching strings
            Console.WriteLine(location.Contains("UC"));
            Console.WriteLine(location.IndexOf("o"));
            Console.WriteLine(location.Replace("n", "u"));

            // LOGIC

            // if statements
            int x = 3;
            int y = 4;

            if(x > y)
            {
                Console.WriteLine(x + " > " + y);
            }
            else
            {
                Console.WriteLine(x + " <= " + y);
            }

            // else 

            // operators
            bool yes = true;
            bool yeah = true;
            bool no = false;

            if((yes && yeah) || no)
            {
                Console.WriteLine(yes);
            }
            else
            {
                Console.WriteLine(no);
            }

            // loops (while and for)
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.Write("\n");

            int j = 10;
            do
            {
                Console.Write(j + " ");
                j++;
            }
            while (j < 20);
            Console.Write("\n");

            while (j < 30)
            {
                Console.Write(j + " ");
                j++;
            }

            Console.Write("\n");

            // NUMBERS

            // basic math
            int five = 5;
            Console.WriteLine(five);
            
            decimal e = 2.71828M;
            Console.WriteLine(e);

            // order of operations
            int math = (1 + 2) - 4 * 4 / 5;
            Console.WriteLine(math);

            // integers and min/max

            // doubles
            double pi = 3.14159;

            Console.WriteLine(pi);
            Console.WriteLine(double.NegativeInfinity);

            // C# built in values
            Console.WriteLine("pi " + Math.PI);

        }
    }
}
