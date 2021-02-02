using System;
using System.Collections.Generic;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Create an anonymous function that allows us know if a string if palindrome or not

            Func<string, string> invertText = (text) =>
            {
                string invert = "";
                foreach (char letter in text)
                {
                    invert = letter + invert;
                }
                return invert;
            };

            Func<string, bool> isPalindrome = (text) => (text == invertText(text));
            Console.WriteLine(isPalindrome("ojo"));

            /// Create a list (strings).
            /// Create an anonymous function that allows us know if all the elements of the list is palindrome or not.

            List<string> words = new List<string> { "ojo", "somos", "oso" };

            Func<List<string>, bool> arePalindrome = (word) =>
            {
                foreach (var item in word)
                {
                    if (item != invertText(item))
                        return false;
                }
                return true;
            };

            Console.WriteLine("Are palindrome? {0}", arePalindrome(words));
        }
    }
}
