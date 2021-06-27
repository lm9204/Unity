using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calcurator : MonoBehaviour
{
    delegate float Calcurate(float a, float b);

    private Calcurate onCalcurate;

    private void Start()
    {
        onCalcurate = Sum;
    }

    public float Sum(float a, float b)
    {
        Debug.Log(a + b);
        return a + b;
    }

    public float Subtract(float a, float b)
    {
        Debug.Log(a - b);
        return a - b;
    }

    public float Multiply(float a, float b)
    {
        Debug.Log(a * b);
        return a * b;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("결과값: " + onCalcurate(1,10));
        }
    }
}
