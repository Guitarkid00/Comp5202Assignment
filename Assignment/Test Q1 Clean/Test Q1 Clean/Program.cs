using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Layton Vincent-Stewart
//5202 Assignment
//Question 1

namespace Test_Q1_Clean
{
    class Program
    {
        static string CheckLength(string input) //Method to check if a variable is less than 8 characters
        {
            while (input.Length<8) // As long as whatever the input is is less than 8 characters, this loop will repeat
            {
                Console.WriteLine($"{input} is less than 8 characters");
                Console.Write("Please enter a new input: "); 
                input = Console.ReadLine();
            }
            Console.WriteLine("Your input is atleast 8 characters long and has been accepted");
            return input;
        }

        static bool PasswordChecker(string password1, string password2) //Method to check the two password variables and see if they match
        {
            while (password1 != password2)
            {
                Console.WriteLine("Your passswords do not match");
                Console.Write("Please confirm your password: ");
                password2 = Console.ReadLine();
            }
            return true;
        }

        static void Main(string[] args)
        {
            string username;
            string password1;
            string password2;

            Console.WriteLine("Welcome to Rotorua Thermal Holiday Park");
            Console.Write("Please enter a username: ");
            username = Console.ReadLine();
            CheckLength(username);

            Console.Write("Please enter a password: ");
            password1 = Console.ReadLine();
            CheckLength(password1);

            Console.Write("Please confirm the password: ");
            password2 = Console.ReadLine();
            CheckLength(password2);

            PasswordChecker(password1, password2); //Sending to the method that checks if the passwords match

            Console.WriteLine("Username and Password have been accepted and set");
            Console.ReadLine();
        }   
    }
}
