using System;

public static class Triangle {
    public static bool IsScalene(double side1, double side2, double side3) {
        return !TwoSidesOfEqualLength(side1, side2, side3) && AddTwoSidesGreaterThanThirdSide(side1, side2, side3);
    }

    public static bool IsIsosceles(double side1, double side2, double side3)  {
        return TwoSidesOfEqualLength(side1, side2, side3) && AddTwoSidesGreaterThanThirdSide(side1, side2, side3);
    }

    public static bool IsEquilateral(double side1, double side2, double side3) {
        return side1 == side2 && side1 == side3 && side1 != 0;
    }

    private static bool TwoSidesOfEqualLength(double side1, double side2, double side3) {
        return side1 == side2 || side1 == side3 || side2 == side3;
    }

    private static bool AddTwoSidesGreaterThanThirdSide(double side1, double side2, double side3) {
        return side1 + side2 >= side3 && side1 + side3 >= side2 && side2 + side3 >= side1;
    }
    
}

public class TriangleException : Exception { }
