using System;
using System.Collections.Generic;

public class Robot
{
    public string Name;
    private static Random rng = new Random();
    private static List<string> Names = new List<string>();

    public Robot() {
        Reset();
    }
    public void Reset()
    {
        while (Name == null || Names.Contains(Name)) {
            Name = "";
            Name += (char)('A' + rng.Next(26));
            Name += (char)('A' + rng.Next(26));
            Name += rng.Next(1000).ToString();
        }

        Names.Add(Name);
    }
}
