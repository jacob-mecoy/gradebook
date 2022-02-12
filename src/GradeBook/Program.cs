//Our application is a console application i.e. it is run from the command line
using System;
//namespace that holds the List type we use
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        //entry point of our application. When running the program this is what is executed
        //our methods parameter is an array of strings called 'args'
        static void Main(string[] args)
        {
            //using the List type allows us to have a dynamically sizeable array that we can easily add and remove from. This is preferred to using a standard array. We can initialise it in the same way as a regular array
            var grades = new List<double>() { 12.45, 90.1, 5.9090, 9.7789 };
            //we can use the .Add method on a list to add to it
            grades.Add(59.1);

            var total = 0.0;
            
            foreach(var number in grades)
            { 
                total += number;
            }

            Console.WriteLine($"The total of our addition is {total}");

            //Compute average of grades
            var average = total / grades.Count;
            
            Console.WriteLine($"Our average is {average}");

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
