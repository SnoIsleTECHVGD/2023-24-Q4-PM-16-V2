using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{

    private Transform target;
    public float speed;
    private float direction;

   void Start()

    {

        target = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void FixedUpdate()
    {

        float moveHorizontal = direction;

        Vector3 movement = new Vector3(moveHorizontal * speed, GetComponent <Rigidbody2D>().velocity.y);

        if (Vector2.Distance(target.position, transform.position) < 5)
        {
            movement.x = 0;
        }

        GetComponent<Rigidbody2D>().velocity = movement;

        if (target.position.x > transform.position.x)
        {

            direction = 1;

        }

        if (target.position.x < transform.position.x)
        {

            direction = -1;

        }
    }

}