using System;

namespace cube
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please Enter a Integer Number..");
            // Int32.Parse(String) Method is used to convert the string representation of a number to its 32-bit signed integer equivalent.
            //@ Linc:https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int
            int i = Int32.Parse(Console.ReadLine());
            // Show the user we collected the number.
            Console.WriteLine("You have entered:"+ i);
            //Display the cube of the number which user enter
            // Here we convert our output in to integer
            //pow() function takes two numbers arguments and returns their powers.  
            Console.WriteLine("Cube :"+ (int)Math.Pow(i,3));

            Console.WriteLine("Please enter a 4 Digits Number..");
            // Console. ReadLine reads input from the console... It means we are converting user input value(which is a string) in to a integer...
            //Int32.Parse(String) Method is used to convert the string representation of a number to its 32-bit signed integer equivalent.
            int number = Int32.Parse(Console.ReadLine());
    
            // Show the user we collected the number.
            Console.WriteLine("Your Number is:"+ number);
            //  getSum() is a function that returns the sum of all the items that have been added to the dataset
            Console.WriteLine("Sum of the Digits is:"+ getSum(number));
            
            
        }

        // @ Link: https://www.geeksforgeeks.org/program-for-sum-of-the-digits-of-a-given-number/
        // Just took a logic from this website.
        // Calaulate the Sum and return value to the main function
        //  getSum() is a function that returns the sum of all the items that have been added to the dataset
        static int getSum(int number)
        {
            // Declare a Integer variable that stores our sum..
            int sum ;
            // For loop has 3 parts: initialization, condition, and change
            // Here we Initialize variable sum to zero..
            //Get the modulus/remainder of the number and sum the remainder of the number
            //number divided by 10 
            // Repeat the loop until number is greater than 0.
            for (sum = 0; number > 0; sum += number % 10,number/= 10); 

            // return sum 
            return sum; 
        }
        
    }
}
