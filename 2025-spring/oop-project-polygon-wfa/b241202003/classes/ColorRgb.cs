//***************************************************************************
//************** STUDENT NAME: SERHAN GÖKMEYDAN *****************************
//************** STUDENT NUMBER: B241202003     *****************************
//***************************************************************************

namespace b241202003.classes;

public class ColorRgb
{
    // private fields for RGB values
    private int _r;
    private int _g;
    private int _b;

    // fields that don't allow value get lower than 0 and higher than 255 for RGB values
    public int R
    {
        get => _r;
        set => _r = (value >= 0 && value <= 255) ? value : 0;
    }

    public int G
    {
        get => _g;
        set => _g = (value >= 0 && value <= 255) ? value : 0;
    }

    public int B
    {
        get => _b;
        set => _b = (value >= 0 && value <= 255) ? value : 0;
    }

    // default constructor with no parameters, and generates random RGB value
    public ColorRgb()
    {
        R = Random.Shared.Next(0, 255);
        G = Random.Shared.Next(0, 255);
        B = Random.Shared.Next(0, 255);
    }

    // constructor with RGB values
    public ColorRgb(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }
}