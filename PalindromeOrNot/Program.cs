using System;

namespace PalindromeOrNot
{
    class Program
    {
        // A recursive function that checks whether string is Palindrome or not
        static bool IsPalindromeRec(String str, int start, int end)
        {
         var check = (start == end) ? true : (str[start] != str[end]) ;

         //if there are more than two characters, check if middle substring is palindrome or not

         if (start < end + 1)
            return IsPalindromeRec(str, start + 1, end - 1);
            return true;
        }
        static bool isPalindrome(String str)
        {
         int sizeOfString = str.Length;

         //empty string is considered as palindrome
         var zeroString = sizeOfString == 0 ? true : false;
         return IsPalindromeRec(str , 0, sizeOfString - 1);
        }
        static void Main(String[]args)
        {
         string str = Console.ReadLine();
         if (isPalindrome(str))
             Console.WriteLine("Yes");
         else
             Console.WriteLine("No");

         Console.ReadLine();
        }
    }
}
