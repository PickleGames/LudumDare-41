using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    private Rigidbody2D rb;
    public float walkSpeed;
    public float patrolTime;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();	
	}
	
	// Update is called once per frame
	void Update () {
        Patrol();
	}

    float walkTimer = 0;
    void Patrol()
    {
      
        rb.velocity = new Vector2(walkSpeed, rb.velocity.y);
        walkTimer += Time.deltaTime;
        if (walkTimer > patrolTime)
        {
            walkSpeed *= -1;
            walkTimer = 0;
        }

    }
}
