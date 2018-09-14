using System;
using System.Diagnostics;

public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r)
    {
        return r.Expreal(realNumber);
    }
}

public struct RationalNumber
{
    private int Numerator { get; set; }
    private int Denominator { get; set; }
    public RationalNumber(int numerator, int denominator)
    {
        if(denominator == 0) {
            throw new ArgumentException("Denominator cannot be zero!");
        }

        this.Numerator = numerator;
        this.Denominator = denominator;
    }

    public RationalNumber Add(RationalNumber r)
    {
        RationalNumber result = new RationalNumber(
            this.Numerator * r.Denominator + r.Numerator * this.Denominator,
            this.Denominator * r.Denominator);
       
        return result.Reduce();
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        return r1.Add(r2);
    }

    public RationalNumber Sub(RationalNumber r)
    {
        RationalNumber result = new RationalNumber(
           this.Numerator * r.Denominator - r.Numerator * this.Denominator,
           this.Denominator * r.Denominator);

        return result.Reduce();
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        return r1.Sub(r2);
    }

    public RationalNumber Mul(RationalNumber r)
    {
        RationalNumber result = new RationalNumber(
            this.Numerator * r.Numerator,
            this.Denominator * r.Denominator
        );

        return result.Reduce();
    }

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        return r1.Mul(r2);
    }

    public RationalNumber Div(RationalNumber r)
    {
        RationalNumber result = new RationalNumber(
            this.Numerator * r.Denominator,
            this.Denominator * r.Numerator
        );

        return result.Reduce();
    }

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {
        return r1.Div(r2);
    }

    public RationalNumber Abs()
    {
        if(this.Numerator < 0) {
            this.Numerator = -this.Numerator;
        }

        if(this.Denominator < 0) {
            this.Denominator = -this.Denominator;
        }

        return new RationalNumber(this.Numerator, this.Denominator);
    }

    private static int FindGCD(int a, int b) {
        while (a != 0 && b != 0) {
            if (a > b)
                a %= b;
            else
                b %= a;
        }

        return b == 0 ? a : b;
    }

    private static int Pow(int baseNumber, int power) {
        var result = 1;
        for(int i = 0; i < power; i++) {
            result *= baseNumber;
        }

        return result;
    }
    
    public RationalNumber Reduce()
    {
        if(Math.Sign(this.Numerator) == Math.Sign(this.Denominator)) {
            this = this.Abs();
        } else {
            if (Denominator < 0) {
                this.Numerator = -this.Numerator;
                this.Denominator = -this.Denominator;
            }
        }

        int gcd = FindGCD(Math.Abs(this.Numerator), Math.Abs(this.Denominator));
        this.Numerator /= gcd;
        this.Denominator /= gcd;

        return new RationalNumber(this.Numerator, this.Denominator);
    }

    public RationalNumber Exprational(int power)
    {
        if(power >= 0) {
            this.Numerator = Pow(this.Numerator, power);
            this.Denominator = Pow(this.Denominator, power);
        } else if(power < 0) {
            this.Numerator = Pow(this.Denominator, -power);
            this.Denominator = Pow(this.Numerator, -power);
        }

        return new RationalNumber(this.Numerator, this.Denominator).Reduce();
    }

    public double Expreal(int baseNumber)
    {
        return Math.Pow(baseNumber, (double)this.Numerator / (double)this.Denominator);
    }
}
