using System;

public class Palindrome
{
    public static bool IsPalindrome(string word)
    {
        var ary = word.ToCharArray();
        Array.Reverse(ary);
        return word.ToLower()
            .Equals((new string(ary).ToLower()));
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
    }
}