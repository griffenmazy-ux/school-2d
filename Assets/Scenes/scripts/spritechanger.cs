using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spritechanger : MonoBehaviour

{
  public SpriteRenderer spriteRender;
public Color splitColor;
    void Start()
    {
      splitColor.a = 1.0f; 
    
    if (spriteRender != null)
    {
        // change color of the sprite to new color
        spriteRender.color = splitColor;
    }
    
    



    }
}
