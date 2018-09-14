using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        var sum = 0;
        while(max > 0) {
            sum += max;
            max--;
        }

        return sum * sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        var sumOfSquares = 0;
        while(max > 0) {
            sumOfSquares += max * max;
            max--;
        }

        return sumOfSquares;
    }

    // square of sum - sum of squares
    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}
