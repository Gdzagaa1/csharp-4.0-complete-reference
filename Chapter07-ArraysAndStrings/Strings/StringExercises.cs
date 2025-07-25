namespace Chapter07_ArraysAndStrings.Strings;

public class StringExercises
{
    // Leetcode problem: https://leetcode.com/problems/valid-palindrome/description/
    // A phrase is a palindrome if, after converting all uppercase
    // letters into lowercase letters and removing all non-alphanumeric
    // characters, it reads the same forward and backward.
    // Alphanumeric characters include letters and numbers.
    // Given a string s, return true if it is a palindrome, or false otherwise.
    public static bool IsPalindrome(string s) {
        string newStr = "";
        foreach(char c in s) {
            if (char.IsLetterOrDigit(c)) {
                newStr += char.ToLower(c);
            }
        }

        for (int i = 0; i < newStr.Length / 2; i++) {

            if (newStr[i] != newStr[newStr.Length - i - 1]) {
                return false;
            }
        }
    
        return true;
    }


    // Goal: Check if two strings are anagrams (ignore case, spaces).
    // Example:
    // Input: "Listen", "Silent" → Output: true
    public static bool isAnagram(string s1, string s2)
    {
        string first = s1.Replace(" ", "").ToLower();
        string second = s2.Replace(" ", "").ToLower();

        if (first.Length != second.Length) return false;

        char[] chars1 = first.ToCharArray();
        char[] chars2 = second.ToCharArray();
        
        Array.Sort(chars1);
        Array.Sort(chars2);

        return new string(chars1) == new string(chars2);
    }


}