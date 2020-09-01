using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Manager;

    public InputField InputField;
    public GameObject Quadratic;
    public GameObject Cubic;

    void Awake()
    {
        Manager = this;
    }
    
    public void UseQuadratic()
    {
        var quadratic = GameObject.FindWithTag("Quadratic");
        var cubic = GameObject.FindWithTag("Cubic");
        
        InputField.onEndEdit.RemoveAllListeners();
        if (quadratic == null)
        {
            if(cubic != null) Destroy(cubic);
            
            quadratic = Instantiate(Quadratic);
            Debug.Log(quadratic.name);
            InputField.onEndEdit.AddListener(delegate
            {
                quadratic.GetComponent<BezierCurve>().SetLimit(InputField.text);
            });
        }
        else
        {
            /*InputField.onEndEdit.RemoveListener(delegate
            {
                quadratic.GetComponent<BezierCurve>().SetLimit(InputField.text);
            });*/
            InputField.onEndEdit.RemoveAllListeners();
            Destroy(quadratic);
        }
    }

    public void UseCubic()
    {
        var quadratic = GameObject.FindWithTag("Quadratic");
        var cubic = GameObject.FindWithTag("Cubic");
        
        InputField.onEndEdit.RemoveAllListeners();
        if (cubic == null)
        {
            if(quadratic != null) Destroy(quadratic);
            cubic = Instantiate(Cubic);
            Debug.Log(Cubic.name);
            InputField.onEndEdit.AddListener(delegate
            {
                cubic.GetComponent<BezierCurve>().SetLimit(InputField.text);
            });
        }
        else
        {
            InputField.onEndEdit.RemoveAllListeners();
            Destroy(cubic);
        }
    }
    
    
}
