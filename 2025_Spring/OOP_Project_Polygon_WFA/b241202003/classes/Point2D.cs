//***************************************************************************
//************** STUDENT NAME: SERHAN GÖKMEYDAN *****************************
//************** STUDENT NUMBER: B241202003     *****************************
//***************************************************************************

namespace b241202003.classes;

public class Point2D
{
    // x and y values of the point for cartesian coordinates
    public float X { get; private set; }
    public float Y { get; private set; }

    // r and angle values of the point for polar coordinates
    public float R { get; private set; }
    public float Theta { get; private set; }

    // default constructor with no parameters
    public Point2D()
    {
        // generate random x and y values between -100 and 100
        X = Random.Shared.Next(0, 4);
        Y = Random.Shared.Next(0, 4);
        CalculatePolarCoords();
    }

    // constructor with x and y values
    // @param x: x value of the point
    // @param y: y value of the point
    public Point2D(float x, float y)
    {
        X = x;
        Y = y;
        CalculatePolarCoords();
    }

    // method to set polar coordinates
    // @param r: radius of the point
    // @param theta: angle of the point in radians
    public void SetPolar(float r, float theta)
    {
        R = r;
        Theta = theta;
        CalculateCartesianCoords();
    }

    // method to calculate polar coordinates from cartesian coordinates
    public void CalculatePolarCoords()
    {
        R = (float)Math.Sqrt(X * X + Y * Y);
        Theta = (float)Math.Atan2(Y, X);
    }

    // method to calculate cartesian coordinates from polar coordinates
    public void CalculateCartesianCoords()
    {
        X = (float)(R * Math.Cos(Theta));
        Y = (float)(R * Math.Sin(Theta));
    }

    // method to print the polar and cartesian coordinates
    public void PrintPolarCoords()
    {
        Console.WriteLine($"R: {R}, Theta: {Theta * 180 / Math.PI}");
    }

    public void PrintCartesianCoords()
    {
        Console.WriteLine($"X: {X}, Y: {Y}");
    }
}