using System;

namespace CSharpFundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 123;
            Console.WriteLine(x);
            int y = 321;
            double height = 174.5;
            bool alive = true;
            char myChar = 'A';
            string myName = "John";
            string myName2 = "John2";
            Console.WriteLine("Your number is " + height);
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("My name is " + myName);
            Console.WriteLine("My name is " + myName2);
            Console.WriteLine("My name is {0} and {1} and {2}", myName, myName2, myChar);
        }
    }
}