 using UnityEngine;

public class playerhealth : MonoBehaviour
// creating a health class to be used in the player and enemy scripts
{
// health and maximum health variables
public int health;
public int maxHealth = 100;
//starting with full health
void Start()
{
    health = maxHealth;
}
//taking damage function that will be called in the enemy damage script
public void TakeDamage(int amount)
{
    health -= amount;
    if (health <= 0)
    {
        Destroy(gameObject);
    }

}
}