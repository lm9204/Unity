using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public bool isOveraped = false;
    private Renderer myRenderer;

    private Color originalColor;
    public Color touchColor;
    
    
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
    }
    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Endpoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
            Debug.Log("충돌 했음");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Endpoint")
        {
            isOveraped = false;
            myRenderer.material.color = originalColor;
            Debug.Log("충돌 했음");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Endpoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        }
    }
}
