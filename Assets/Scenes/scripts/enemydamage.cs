using UnityEngine;

public class enemydamage : MonoBehaviour
{
public objecthealth objecthealth;
public int damage = 20;
   private void OnCollisionEnter2D(Collision2D collision)
   {
    // taking damage if the enemy collides with the player
      if (collision.gameObject.tag == "OBJECT")
      {
         objecthealth.TakeDamage(damage);
      }
      
   }

}