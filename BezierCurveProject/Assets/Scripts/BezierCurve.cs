using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierCurve : MonoBehaviour
{
    public Transform[] Points;
    public Transform[] QPoints;
    public Transform BezierPoint;

    protected LineRenderer lineRenderer;
    protected float time = 0f;
    protected float limit = 1f;
    protected float magnification;
    
    protected void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        magnification = 1f / limit;
    }
    
    protected void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time > limit) time = 0f;

        for (int i = 0; i < Points.Length; i++)
        {
            lineRenderer.SetPosition(i,Points[i].position);
        }
    }
}
