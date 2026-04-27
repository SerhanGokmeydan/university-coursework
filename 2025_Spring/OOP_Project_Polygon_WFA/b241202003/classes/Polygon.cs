//***************************************************************************
//************** STUDENT NAME: SERHAN GÖKMEYDAN *****************************
//************** STUDENT NUMBER: B241202003     *****************************
//***************************************************************************

namespace b241202003.classes;

public class Polygon : BaseShape
{
    // vertexes of the polygon
    public readonly List<Point2D> Vertexes = [];

    // private fields for radius and external angle
    private readonly float _radius;
    private readonly float _externalAngle;

    // default constructor with no parameters
    public Polygon()
    {
        // calculate radius and external angle based on the edge length and number of edges
        _radius = (float)(EdgeLength / (2 * Math.Sin(Math.PI / NumberOfEdges)));
        _externalAngle = (float)(Math.PI * 2 / NumberOfEdges);

        CalculateVertexes();
    }

    // constructor with parameters
    // @param center: center of the polygon
    // @param color: color of the polygon
    // @param edgeLength: length of the edges of the polygon
    // @param numberOfEdges: number of edges of the polygon
    public Polygon(Point2D center, ColorRgb color, int edgeLength, int numberOfEdges)
    {
        Center = center;
        Color = color;
        EdgeLength = edgeLength;
        NumberOfEdges = numberOfEdges;

        _radius = (float)(EdgeLength / (2 * Math.Sin(Math.PI / NumberOfEdges)));
        _externalAngle = (float)Math.PI * 2 / NumberOfEdges;

        CalculateVertexes();
    }

    // method to calculate the coordinates of the vertexes
    public override void CalculateVertexes()
    {
        // clear the vertex list before recalculating
        Vertexes.Clear();

        // call SetPolar on each vertex to calculate the coordinates
        for (int i = 0; i < NumberOfEdges; i++)
        {
            Point2D vertex = new();
            vertex.SetPolar(_radius, _externalAngle * i);
            Vertexes.Add(vertex);
        }
    }


    // method to rotate the polygon
    // @param angle: angle to rotate the polygon by
    // @param ccw: true if the rotation is counter-clockwise, false if clockwise
    public override void RotatePolygon(float angle, bool ccw)
    {
        // rotate each vertex by the specified angle
        for (int i = 0; i < NumberOfEdges; i++)
        {
            float currentTheta = Vertexes[i].Theta;
            float delta = (float)((ccw ? -1 : 1) * angle * Math.PI / 180);

            Vertexes[i].SetPolar(_radius, currentTheta + delta);
        }
    }
}