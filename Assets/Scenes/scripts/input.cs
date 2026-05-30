using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEmptyCSharpScript : MonoBehaviour
{
    void Start() {
        
    }

     void Update()
    {
        //scale axis debug
         Debug.Log("scale axis: " + Input.GetAxis("scale"));
         Debug.Log("quit axis: " + Input.GetAxis("quit"));
    }
}