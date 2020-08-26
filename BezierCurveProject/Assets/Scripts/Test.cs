using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    private float sum = 0;
    private Text text; 

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        sum += Time.deltaTime;
        if (sum > 1f) sum = 0f;
        sum = (float) Math.Round(sum, 2);
        text.text = "현재 이동 거리 = " + sum.ToString();
    }
}
