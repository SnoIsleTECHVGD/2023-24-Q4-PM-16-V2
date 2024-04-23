using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject deathEffect;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Meteor")
        {
            Instantiate(deathEffect, transform.position, transform.rotation);

            FindObjectOfType<AudioManager>().play("PlayerDeath");
            
            Destroy(gameObject);


        }
    }
}
        
   

    
  
        
   