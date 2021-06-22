using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winUI;
    public ItemBox[] itemBoxes;
    
    public bool isGameOver;
    void Start()
    {
        isGameOver = false;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }
        if (isGameOver) return;
        
        int count = 0;
        for (int i = 0; i < itemBoxes.Length; i++)
        {
            if (itemBoxes[i].isOveraped == true)
            {
                count++;
            }

            if (count >= itemBoxes.Length)
            {
                isGameOver = true;
                Debug.Log("Win!");
                winUI.SetActive(true);
            }
        }
    }
}
