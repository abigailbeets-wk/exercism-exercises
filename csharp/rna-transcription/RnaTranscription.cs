using System;
using System.Collections.Generic;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {   
        Dictionary<char, char> dict = new Dictionary<char, char>();
        dict.Add('G', 'C');    
        dict.Add('C', 'G');    
        dict.Add('A', 'U');    
        dict.Add('T', 'A');

        string transcribed = "";
        for(int i = 0; i < nucleotide.Length; i++) {
            transcribed += dict[nucleotide[i]];
        }

        return transcribed;    
    }
}
