using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine(MaxChar("abeeeeeeed"));
        Console.WriteLine(MaxChar("apple 1234444"));
    }

    static char MaxChar(string str)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char ch in str)
        {
            if (charCount.ContainsKey(ch))
            {
                charCount[ch]++;
            }
            else
            {
                charCount[ch] = 1;
            }
        }

        char maxChar = '\0';
        int maxCount = 0;

        foreach (var kvp in charCount)
        {
            if (kvp.Value > maxCount)
            {
                maxChar = kvp.Key;
                maxCount = kvp.Value;
            }
        }

        return maxChar;
    }
}