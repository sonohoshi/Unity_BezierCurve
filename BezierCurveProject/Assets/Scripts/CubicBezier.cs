using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubicBezier : BezierCurve
{
    public Transform[] RPoints;

    new void Awake()
    {
        base.Awake();
    }

    new void FixedUpdate()
    {
        base.FixedUpdate();
        BezierPoint.position = Bezier(time * magnification, Points, QPoints, RPoints);
    }

    private Vector3 Bezier(float t, Transform[] points, Transform[] qPoints, Transform[] rPoints)
    {
        qPoints[0].position = Vector3.Lerp(points[0].position, points[1].position, t);
        qPoints[1].position = Vector3.Lerp(points[1].position, points[2].position, t);
        qPoints[2].position = Vector3.Lerp(points[2].position, points[3].position, t);

        rPoints[0].position = Vector3.Lerp(qPoints[0].position, qPoints[1].position, t);
        rPoints[1].position = Vector3.Lerp(qPoints[1].position, qPoints[2].position, t);

        return Vector3.Lerp(rPoints[0].position, rPoints[1].position, t);
    }
}
