using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class gamequit: MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetButtonDown("quit"))
        {
            Application.Quit(); 
            //EditorApplication.isPlaying = false;
        }
    }
}
