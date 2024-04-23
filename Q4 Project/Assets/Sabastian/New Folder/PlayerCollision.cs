using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject deathEffect;

    void OncollisionEnter(Collision col)
    {
        if (col.collider.tag == "Meteor")
        {
            Instantiate(deathEffect, transform.position, transform.rotation);
            GameManagerDependencyInfo.instance.EndGame();

            FindObjectOfType<AudioManager>().play("PlayerDeath");
            
            Destroy(gameObject);


        }
    }
}
        
   

    
  
        
   