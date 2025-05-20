using System;

namespace PalindromeExercise
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            
            var pc = new PalindromeChecker();
            
            bool isPalindrome = pc.CheckPalindrome(userInput);
            
            if (isPalindrome == true)
            {
                Console.WriteLine("This is a Palindrome");
            }
            else
            {
                Console.WriteLine("This is not a Palindrome");
            }
            //Console.WriteLine(isPalindrome == true ? "Palindrome" : "Not Palindrome");
        }
    }
}
