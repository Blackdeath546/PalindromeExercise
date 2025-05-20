using System;

namespace PalindromeExercise;

public class PalindromeChecker
{

    public bool CheckPalindrome(string input)
    {
        string isPalindrome = input.ToLower();
        
        for (int i = 0; i < isPalindrome.Length / 2; i++)
        {
            if (isPalindrome[i] != isPalindrome[isPalindrome.Length - 1 - i])
            {
                return false;
            }
           
        }
        return true;
        return false;
        //throw new NotImplementedException();
    }

    // public bool CheckPalindrome(int input)
    // {
    //     return false;
    // }
    //
    // public bool CheckPalindrome()
    // {
    //     return false;
    // }
    //
    // public void CheckPalindrome()
    // {
    //     for (int i = 0; i < 10; i++)
    // }

}