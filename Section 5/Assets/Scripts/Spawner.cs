using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject target;

    public Transform spawnPosition;
    
    void Start()
    {
        
        GameObject instance = Instantiate(target,spawnPosition.position,spawnPosition.rotation);
        Debug.Log(instance.name);
    }
    
    void Update()
    {
        
    }
}
