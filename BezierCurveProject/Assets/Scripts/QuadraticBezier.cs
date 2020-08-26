using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadraticBezier : BezierCurve
{
    void Awake()
    {
        base.Awake();
    }
    
    void FixedUpdate()
    {
        base.FixedUpdate();
        BezierPoint.position = Bezier(time * magnification, Points, QPoints);
    }

    private Vector3 Bezier(float t, Transform[] points, Transform[] qPoints)
    {
        qPoints[0].position = Vector3.Lerp(points[0].position, points[1].position, t);
        qPoints[1].position = Vector3.Lerp(points[1].position, points[2].position, t);

        return Vector3.Lerp(qPoints[0].position,qPoints[1].position, t);
    }
}
