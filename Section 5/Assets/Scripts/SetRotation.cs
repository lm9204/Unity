using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRotation : MonoBehaviour
{

    // /*public Transform targetTransform;

    void Start()
    {
        // Quaternion aRotation = Quaternion.Euler(new Vector3(30, 0, 0));
        // Quaternion bRotation = Quaternion.Euler(new Vector3(60, 0, 0));

        // Vector3 direction = targetTransform.position - transform.position;
        // Quaternion newRotation = Quaternion.Euler(new Vector3(45,0,0));

        // transform.rotation = Quaternion.Euler(new Vector3(45, 0, 0));
        //
        // transform.Rotate(new Vector3(30, 0, 0));
        
        
        // Vector3 originalRotationInVector3 = originalRotation.eulerAngles;
        // Vector3 targetRotationVec = originalRotationInVector3 + new Vector3(30, 0, 0);
        //
        // Quaternion targetRotation = Quaternion.Euler(targetRotationVec);
        // Quaternion originalRotation = Quaternion.Euler(new Vector3(45,0, 0));
        //
        // Quaternion plusRotation = Quaternion.Euler(new Vector3(30, 0, 0));
        //
        // Quaternion targetRotation = originalRotation * plusRotation;
        //
        // transform.rotation = targetRotation;
        transform.Rotate(new Vector3(30,0,0));
    }

    void Update()
    {
        
    }
}
