using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTarget : MonoBehaviour
{
    private float health;
    public float startHealth;



    void start()
    {
        health = startHealth;
    }

    public void PlayerTakesDamage(float damageAmount)
    {
        health -= damageAmount;


        if (health <= 0f)
        {
            Death();
        }

    }

    void Death()
    {
        SceneManager.LoadScene("MainMenu");
    }


}


