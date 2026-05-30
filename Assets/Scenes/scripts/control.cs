using UnityEngine;

//creating a controller for the movement of the player
public class control: MonoBehaviour
{
    public float speed =4; // Speed of movement
public float rotate = 1; // Speed of rotation
    void Update()
    {
    // Get input from the horizontal axis, 
        float up = Input.GetAxis("up");

        float side = Input.GetAxis("side");


// Calculate movement vector
        Vector3 movement = new Vector3(side, up, 0);
 //aply movement to the player
        transform.position += movement * speed * Time.deltaTime;
        
         if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, 0, 0.5f);
        }

        if (Input.GetKey(KeyCode.E))
       {
           transform.Rotate(0, 0, -0.5f);
        }
    }
    
       
}
