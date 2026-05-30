using UnityEngine;

//random teleportation script for testing purposes, not used in the final game
public class teleport: MonoBehaviour
{
    private Transform tf;
    
    public float maxhorizontaldistance =10f;
    public float speed = 10f;
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Vector3 newPos = new Vector3(Random.Range(-maxhorizontaldistance, maxhorizontaldistance), Random.Range(-maxhorizontaldistance, maxhorizontaldistance), Random.Range(-maxhorizontaldistance, maxhorizontaldistance));
            tf.position = newPos;
        }
    }
}