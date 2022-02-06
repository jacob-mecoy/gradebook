//Our application is a console application i.e. it is run from the command line
using System;

namespace GradeBook
{
    class Program
    {
        //entry point of our application. When running the program this is what is executed
        //our methods parameter is an array of strings called 'args'
        static void Main(string[] args)
        {
            //define a variable of type double and instantiate it by assigning a value to it
            double x = 34.1;
            //we can use the var keyword when defining a variable and initialising it
            //on the same line. When using the var keyword we take advantage of implicit
            //typing in C#. The compiler figures out the type of our variable.
            var y = 90.1;
            var z = x + y;

            Console.WriteLine($"The result of our addition is {z}");

            //set up a conditional statement that checks whether or not an argument is
            //passed when running the program
            if(args.Length > 0)
            { 
                //string interpolation used in the writeline method
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            { 
                //if there is no argument then we will default to the message below
                Console.WriteLine("Hello!");
            }

            
        }
    }
}
