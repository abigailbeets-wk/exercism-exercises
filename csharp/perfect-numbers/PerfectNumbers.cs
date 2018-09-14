using System;
using System.Collections.Generic;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers {
    public static Classification Classify(int number) {
        if(number <= 0) {
            throw new ArgumentOutOfRangeException();
        }

        var sum = 0;
        var factors = getFactors(number);
        foreach(int factor in factors) {
            sum += factor;
        }

        return sum == number ? Classification.Perfect : 
        sum > number ? Classification.Abundant : 
        Classification.Deficient; 
    }

    private static List<int> getFactors(int number) {
        List<int> factors = new List<int>();
        for (int i = 1; i <= number / 2; i++) {   
            if(number % i == 0) {
                factors.Add(i);
            }
        }

        return factors;
    }
}
