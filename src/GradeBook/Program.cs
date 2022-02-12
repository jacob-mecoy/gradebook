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
            //define an array of doubles. We must assign a value to our variable by using
            //the word "new", otherwise our code will throw an error as unassigned variables
            //tend to cause problems in our code
            var numbers = new double[3];
            numbers[0] = 12.45;
            numbers[1] = 90.1;
            numbers[2] = 5.9090;

            double result = new double();

            for (int i=0; i < numbers.Length; i++) 
            { 
                result += numbers[i];
            }

            Console.WriteLine($"The result of our addition is {result}");

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
