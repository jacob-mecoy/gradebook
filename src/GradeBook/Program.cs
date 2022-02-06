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
