using UnityEngine;

public class spritescale: MonoBehaviour
{
    private Transform tf;
    public float maxScale;
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    void Update()
    {
    float axisValue = Input.GetAxis("scale");
    
    float scaleamount = axisValue * maxScale;
tf.localScale += Vector3.one * scaleamount; 
    }
}
