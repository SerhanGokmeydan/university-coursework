//***************************************************************************
//************** STUDENT NAME: SERHAN GÖKMEYDAN *****************************
//************** STUDENT NUMBER: B241202003     *****************************
//***************************************************************************

namespace b241202003.classes;

public interface IShape
{
    // method to calculate coordinates of the edges of the polygon
    void CalculateVertexes();

    // method to rotate the polygon: angle is in degrees, and ccw is true if the rotation is counter-clockwise
    void RotatePolygon(float angle, bool ccw);
}