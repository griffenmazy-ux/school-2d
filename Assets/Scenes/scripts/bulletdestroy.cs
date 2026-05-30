using UnityEngine;

public class bulletdestroy : MonoBehaviour
{
public playerhealth playerhealth;
public int damage = 25;
   private void OnCollisionEnter2D(Collision2D collision)
   {
    // taking damage if the enemy collides with the any gamerobject
      if (collision.gameObject.tag == "Player")
      {
         playerhealth.TakeDamage(damage);
      }
      
   }
}