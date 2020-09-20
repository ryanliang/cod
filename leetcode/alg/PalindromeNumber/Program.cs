using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 122421;
            Console.WriteLine(IsPalindrome(num));
        }

        public static bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            var s = x.ToString();

            for(int i = 0, j = s.Length -1; i <= j; i++, j--)
            {
                if(s[i] != s[j]) return false;
            }
            
            return true;
        }
    }
}
