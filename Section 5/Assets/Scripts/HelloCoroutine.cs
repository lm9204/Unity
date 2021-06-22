using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCoroutine : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine("HelloUnity");
        StartCoroutine("HiCSharp");
    }

    IEnumerator HelloUnity()
    {
        Debug.Log("Hello");

        yield return new WaitForSeconds(3f);
        Debug.Log("Unity");
    }

    IEnumerator HiCSharp()
    {
        Debug.Log("Hi");
        yield return new WaitForSeconds(5f);
        Debug.Log("CSharp");
    }
    
}
