using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string that is a potential palindrome: ");
            var input = Console.ReadLine();
            Console.WriteLine(Palindrome.IsPalindrome(input)
                ? "Your string was a palindrome!"
                : "Your string was not a palindrome.");
            Console.ReadLine();
        }
    }
}
