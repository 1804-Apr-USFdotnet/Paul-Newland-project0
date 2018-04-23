using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Palindrome
    {
        public static bool IsPalindrome(string input)
        {
            input = input.Replace(" ", string.Empty);
            input = Regex.Replace(input, @"[\W_]", string.Empty);
            return input.ToLower() == string.Join("", input.ToLower().ToCharArray().Reverse());
        }
    }
}
