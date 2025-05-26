using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAnimation : MonoBehaviour
{
    GameObject Animation;
 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DestroySelf()
    {
        Destroy(Animation);
        Debug.Log("Destroy");
    }
}
