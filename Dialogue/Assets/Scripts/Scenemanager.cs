using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        Interaction();
    }

    private void Interaction()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("ShopKeeper");
            Debug.Log("werkt het");
        }
    }
}
