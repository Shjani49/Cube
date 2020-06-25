using System;

namespace cube
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Please Enter a Integer Number:");
            // Convert String to Integer number.
            //@ Linc:https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int
            int i = Int32.Parse(Console.ReadLine());
            // Show the user we colleted the name.
            Console.WriteLine("You have entered:"+ i);
            //Display the cube of the number which user enter
            // Here we convert our output in to integer
            //pow() function takes two numbers arguments and returns their powers.  
            Console.WriteLine("Cube :"+ (int)Math.Pow(i,3));
        }
    }
}
