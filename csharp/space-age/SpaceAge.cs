using System;

public class SpaceAge
{
    public long seconds;
    private static double earthSecondsPerYear = 31557600;
    private static double mercuryOrbitalFactor = 0.2408467;
    private static double venusOrbitalFactor = 0.61519726;
    private static double marsOrbitalFactor = 1.8808158;
    private static double jupiterOrbitalFactor = 11.862615;
    private static double saturnOrbitalFactor = 29.447498;
    private static double uranusOrbitalFactor = 84.016846;
    private static double neptuneOrbitalFactor = 164.79132;

    public SpaceAge(long seconds) => this.seconds = seconds;

    public double OnEarth()
    {
        return this.seconds / earthSecondsPerYear;
    }

    public double OnMercury()
    {
        return this.seconds / (earthSecondsPerYear * mercuryOrbitalFactor);
    }

    public double OnVenus()
    {
        return this.seconds / (earthSecondsPerYear * venusOrbitalFactor);
    }

    public double OnMars()
    {
        return this.seconds / (earthSecondsPerYear * marsOrbitalFactor);
    }

    public double OnJupiter()
    {
        return this.seconds / (earthSecondsPerYear * jupiterOrbitalFactor);
    }

    public double OnSaturn()
    {
        return this.seconds / (earthSecondsPerYear * saturnOrbitalFactor);
    }

    public double OnUranus()
    {
        return this.seconds / (earthSecondsPerYear * uranusOrbitalFactor);
    }

    public double OnNeptune()
    {
        return this.seconds / (earthSecondsPerYear * neptuneOrbitalFactor);
    }
}
