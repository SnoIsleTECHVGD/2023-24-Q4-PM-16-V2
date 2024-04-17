using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerattack : MonoBehaviour
{
    private GameObject attackArea = default;

    private bool attacking = false;
    private float timer = 0f;

    private float timeoAttack = 0.25f;
    void Start()
    {
        attackArea = transform.GetChild(0).gameObject; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }

        if (attacking)
        {

            timer += Time.deltaTime;

            if(timer >= timeoAttack)
            {
                timer = 0;
                attacking = false;
                attackArea.SetActive(attacking);
            }
        }
    }



    private void Attack()
    {
        attacking = true;
        attackArea.SetActive(attacking);
    }
}

