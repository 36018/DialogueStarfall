using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenemanager : MonoBehaviour
{
    GameObject Button;

    GameObject NPC;

    GameObject Player;
    void Start()
    {
        
    }

    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "NPC")
        {
            if (Input.GetKeyDown(KeyCode.F)) 
            {
                Interaction();
            }
            
        }

       
    }
    private void Interaction()
    {
      SceneManager.LoadScene("ShopKeeper");
      Debug.Log("Press");

    }

}




