using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadraticBezier : MonoBehaviour
{
    public Transform[] Points;
    public Transform[] QPoints;
    public Transform BezierPoint;
    
    private LineRenderer lineRenderer;
    private float time = 0f;
    private float limit = 5f;
    private float magnification;

    // Start is called before the first frame update
    void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        magnification = 1f / limit;
    }
    
    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time > limit) time = 0f;

        for (int i = 0; i < Points.Length; i++)
        {
            lineRenderer.SetPosition(i,Points[i].position);
        }

        BezierPoint.position = Bezier(time * magnification, Points, QPoints);
    }

    private Vector3 Bezier(float t, Transform[] points, Transform[] qPoints)
    {
        qPoints[0].position = Vector3.Lerp(points[0].position, points[1].position, t);
        qPoints[1].position = Vector3.Lerp(points[1].position, points[2].position, t);

        return Vector3.Lerp(qPoints[0].position,qPoints[1].position, t);
    }
}
