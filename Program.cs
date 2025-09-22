/*
LeetCode 383. Ransom Note

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        
    }
}
*/

/*
Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.

    Example 1:
        Input: ransomNote = "a", magazine = "b"
        Output: false

    Example 2:
        Input: ransomNote = "aa", magazine = "ab"
        Output: false

    Example 3:
        Input: ransomNote = "aa", magazine = "aab"
        Output: true
*/

namespace Assignment_12._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ransomNote = "a";
            string magazine = "b";
            Console.WriteLine($"Input: ransomNote = \"{ransomNote}\", magazine = \"{magazine}\"");
            Console.WriteLine($"Output: {CanConstruct(ransomNote, magazine)}\n"); // false

            ransomNote = "aa";
            magazine = "ab";
            Console.WriteLine($"Input: ransomNote = \"{ransomNote}\", magazine = \"{magazine}\"");
            Console.WriteLine($"Output: {CanConstruct(ransomNote, magazine)}\n"); // false

            ransomNote = "aa";
            magazine = "aab";
            Console.WriteLine($"Input: ransomNote = \"{ransomNote}\", magazine = \"{magazine}\"");
            Console.WriteLine($"Output: {CanConstruct(ransomNote, magazine)}\n"); // true

            // Additional test cases
            ransomNote = "dog";
            magazine = "goodday";
            Console.WriteLine($"Input: ransomNote = \"{ransomNote}\", magazine = \"{magazine}\"");
            Console.WriteLine($"Output: {CanConstruct(ransomNote, magazine)}\n"); // true

            ransomNote = "cat";
            magazine = "table";
            Console.WriteLine($"Input: ransomNote = \"{ransomNote}\", magazine = \"{magazine}\"");
            Console.WriteLine($"Output: {CanConstruct(ransomNote, magazine)}\n"); // false
        }

        public static bool CanConstruct(string ransomNote, string magazine)
        {
            List<char> chars = magazine.ToList();

            foreach (char c in ransomNote)
            {
                if (chars.Contains(c)) chars.Remove(c);
                else return false;
            }
            return true;
        }
    }
}
