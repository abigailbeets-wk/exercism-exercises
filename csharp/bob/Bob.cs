using System;

public static class Bob
{
    public static string Response(string statement)
    {
        if(string.IsNullOrWhiteSpace(statement)) {
            return "Fine. Be that way!";
        } else if(IsAllUpper(statement) && IsQuestion(statement)) {
            return "Calm down, I know what I'm doing!";
        } else if(IsAllUpper(statement)) {
            return "Whoa, chill out!";
        } else if(IsQuestion(statement)) {
            return "Sure.";
        }

        return "Whatever.";
    }

    private static bool IsAllUpper(string input)
    {
        var letterCount = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if(Char.IsLetter(input[i])) {
                letterCount ++;
                if(!Char.IsUpper(input[i])) {
                    return false;
                }
            }
        }

        // if no letters, cannot be all upper
        if(letterCount == 0) {
            return false;
        }

        return true;
    }

    private static bool IsQuestion(string input) {
        return input.TrimEnd().EndsWith("?");
    }
}
