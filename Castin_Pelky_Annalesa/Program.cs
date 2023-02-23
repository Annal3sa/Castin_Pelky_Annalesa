using System;

namespace Castin_Pelky_Annalesa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user to enter a whole number and assigns input to integer
            Console.WriteLine("Please enter a whole number!");
            int myFavNum = Convert.ToInt32(Console.ReadLine());

            // Prints faveorite number to console
            Console.WriteLine("Your Faveorite number is" + myFavNum);

            // Asks user a true/false question and assigns respose to a boolean
            Console.WriteLine("Do you like video games? (Please enter 'true' or 'false')");
            bool isTrue = Convert.ToBoolean(Console.ReadLine());

            // Print the result of question asked
            Console.WriteLine($"It is {isTrue} that I like video games!");


        }
    }
}
