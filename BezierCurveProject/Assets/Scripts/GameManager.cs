using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Manager;
    
    public GameObject Quadratic;
    public GameObject Cubic;

    void Awake()
    {
        Manager = this;
    }
    
    public void UseQuadratic()
    {
        var quadratic = GameObject.FindWithTag("Quadratic");
        if (quadratic == null)
        {
            Instantiate(Quadratic);
            Debug.Log(Quadratic.name);
        }
        else
        {
            Debug.Log("quad is not null");
        }
    }

    public void UseCubic()
    {
        var cubic = GameObject.FindWithTag("Cubic");
        if (cubic == null)
        {
            Instantiate(Cubic);
            Debug.Log(Cubic.name);
        }
        else
        {
            Debug.Log("cubic is not null");
        }
    }
    
    
}
