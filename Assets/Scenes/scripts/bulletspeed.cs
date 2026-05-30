using UnityEngine;

public class bulletspeed : MonoBehaviour
{
    public float speed = 4f;
     //the object is always going forward with the speed variable that can be changed in the inspector
    void Update()
    {        transform.position += Vector3.up * speed * Time.deltaTime;  


    }
}
