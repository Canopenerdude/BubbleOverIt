using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{
    private float health = 0f;
    private float maxHealth = 3f;
    
    private void Start()
    {
        gameObject.SetActive(true);
        health = maxHealth;
    }

    private void OnCollisionEnter2d(Collision2D collision)
    {
        Debug.Log("Collided with collision object.");

        if (collision.gameObject.CompareTag("Spike"))
        {
            health -= 1f;
            Debug.Log("Took dmg");


        }
        if (health <= 0f)
        {
            health = 0f;
            PlayerDied();
            //Add AudioSource.
        }
    }
        // Update is called once per frame
 
    private void PlayerDied()
    {
        Debug.Log("Player has died.");
        LevelManager.instance.GameOver();
        gameObject.SetActive(false);
    }
}

