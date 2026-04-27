//***************************************************************************
//************** STUDENT NAME: SERHAN GÖKMEYDAN *****************************
//************** STUDENT NUMBER: B241202003     *****************************
//***************************************************************************

namespace b241202003.classes;

public abstract class BaseShape : IShape
{
    // center of the shape, it must have Point2D type
    public Point2D Center { get; set; }

    // the color of the shape, it must have Color type
    public ColorRgb Color { get; set; }

    // the length of the shape
    public int EdgeLength { get; set; }

    // the number of edges of the shape
    public int NumberOfEdges { get; set; }


    // abstract methods that must be implemented by the derived classes
    public abstract void CalculateVertexes();
    public abstract void RotatePolygon(float angle, bool ccw);

    protected BaseShape()
    {
        // default values that are randomly generated
        Center = new Point2D();
        Color = new ColorRgb();
        EdgeLength = Random.Shared.Next(3, 10);
        NumberOfEdges = Random.Shared.Next(3, 11);
    }
}