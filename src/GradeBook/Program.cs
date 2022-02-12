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
            //if we know what numbers are going to be added to our array then we can add
            //them in the initialisation statement by adding curly braces at the end of
            //"new[]". We also don't need to specify the size of the array or the type
            //of variables it holds. So we can get rid of "double" and just use "new[]"
            var numbers = new[] { 12.45, 90.1, 5.9090, 9.7789 };

            var result = 0.0;

            foreach(var number in numbers)
            { 
                result += number;
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
