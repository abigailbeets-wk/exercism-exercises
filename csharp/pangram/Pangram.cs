using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>{
            {'a', 0}, {'b', 0}, {'c', 0}, {'d', 0}, {'e', 0},
            {'f', 0}, {'g', 0}, {'h', 0}, {'i', 0}, {'j', 0},
            {'k', 0}, {'l', 0}, {'m', 0}, {'n', 0}, {'o', 0},
            {'p', 0}, {'q', 0}, {'r', 0}, {'s', 0}, {'t', 0},
            {'u', 0}, {'v', 0}, {'w', 0}, {'x', 0}, {'y', 0},
            {'z', 0},
        };

        var cleanedInput = Regex.Replace(input.ToLower(), "[^a-z]", "");

        foreach(char letter in cleanedInput) {
            if(dict[letter] == 0) {
                dict[letter]++;
            }
        }

        if(dict.ContainsValue(0)) {
            return false;
        }

        return true;
    }
}
