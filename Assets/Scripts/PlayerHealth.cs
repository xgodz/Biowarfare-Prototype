using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // creating an instance of the healthBar class to use its methods 
    public Health_Bar healthBar;
    public int maxHealth = 200;
    public float currentHealth;

    public GameObject GameOverScreen;


    // Start is called before the first frame update
    void Start()
    {
        // when the game is starting i am setting the value of currentHealth equals to maxHealth
        currentHealth = maxHealth;

        // also setting our player's max health as 200 (maxHealth variable)
        healthBar.SetMaxHealth(maxHealth);

        GameOverScreen.SetActive(false);
        // Time.timeScale = 1;
    }


    // I am calling this takeDamage function when ever the player is colliding with the barrels collision radius
    public void TakeDamage(int damage)
    {
        // subtracting the damage integer from the current health value
        currentHealth -= damage;

        // and setting the health of the player by calling the SetHealthValue(health) function and passing the currentHealth 
        healthBar.SetHealthValue(currentHealth);

        // if (currentHealth <= 0)
        // {
        //     Time.timeScale = 0;
        //     GameOverScreen.SetActive(true);
        // }
    }

    // public IEnumerator TakeDamageOverTime(float damageAmount, float duration)
    // {
    //     float amountDamaged = 0;
    //     float damageperloop = damageAmount / duration;
    //     while (amountDamaged < damageperloop)
    //     {
    //         currentHealth -= damageperloop;
    //         amountDamaged += damageperloop;
    //         yield return new WaitForSeconds(1f);
    //     }
    //     healthBar.SetHealthValue(currentHealth);

    // }

    // public IEnumerator HealOverTime(float healAmount, float duration)
    // {
    //     float amountHealed = 0;
    //     float healperloop = healAmount / duration;
    //     while (amountHealed < healAmount)
    //     {
    //         currentHealth += healperloop;
    //         amountHealed += healperloop;
    //         yield return new WaitForSeconds(1f);
    //         healthBar.SetHealthValue(currentHealth);
    //     }

    // }


}
