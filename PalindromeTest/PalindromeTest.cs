using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace PalindromeTest
{
    [TestClass]
    public class IsPalindromeTest
    {
        [TestMethod]
        public void IsPalindrome1()
        {
            var input = "racecar";
            var result = Palindrome.Palindrome.IsPalindrome(input);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void IsPalindrome2()
        {
            var input = "Racecar";
            var result = Palindrome.Palindrome.IsPalindrome(input);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void IsPalindrome3()
        {
            var input = "1221";
            var result = Palindrome.Palindrome.IsPalindrome(input);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void IsPalindrome4()
        {
            var input = "never Odd, or Even.";
            var result = Palindrome.Palindrome.IsPalindrome(input);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void IsPalindrome5()
        {
            var input = "1231";
            var result = Palindrome.Palindrome.IsPalindrome(input);
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void IsPalindrome6()
        {
            var input = "abc";
            var result = Palindrome.Palindrome.IsPalindrome(input);
            Assert.AreEqual(result, false);
        }
    }
}
