using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Container<string> container = new Container<string>();
        container.messages = new string[3];

        container.messages[0] = "Hello";
        container.messages[1] = "World";
        container.messages[2] = "Generic";

        for (int i = 0; i < container.messages.Length; i++)
        {
            Debug.Log(container.messages[i]);
        }
        
        Container<int> container2 = new Container<int>();
        container2.messages = new int[3];

        container2.messages[0] = 1;
        container2.messages[1] = 2;
        container2.messages[2] = 3;

        for (int i = 0; i < container2.messages.Length; i++)
        {
            Debug.Log(container2.messages[i]);
        }

    }

}

public class Container<T>
{
    public T[] messages;
}
