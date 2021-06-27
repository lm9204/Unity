﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{

    public string name;
    public float weight;
    public int year;

    public void Print()
    {
        Debug.Log(name + "| 몸무게: " + weight + "| 나이: " + year);
    }

    protected float GetSpeed()
    { 
        return CalcSpeed();
    }

    private float CalcSpeed()
    {
        return 100f / (weight * year);
    }
    
    

}

public class Dog: Animal
{
    public void Hunt()
    {
        float speed = GetSpeed();
        Debug.Log(speed + " 의 속도로 달려가서 사냥했다");

        weight += 10f;
    }
}

public class Cat : Animal
{
    public void Stealth()
    {
        Debug.Log("숨음");
    }
}
