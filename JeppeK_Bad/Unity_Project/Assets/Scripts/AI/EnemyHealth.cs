﻿using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public static float startingHealth;
    float currentHealth;
    //public int scoreValue = 10;
    bool isDead;
    //public AudioController audioM;

    void Start()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(int amount)
    {
        if (isDead)
            return;
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Death();
        }
    }


    void Death()
    {
        isDead = true;
        GameMasterPublicVariables.killedAI++;
        Destroy(gameObject);
    }
}
