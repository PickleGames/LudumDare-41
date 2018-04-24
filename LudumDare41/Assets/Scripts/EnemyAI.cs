using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {
    private Rigidbody2D rb;
    public float walkSpeed;
    public float patrolTime;

    private Health health;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        health = GetComponent<Health>();
	}
	
	// Update is called once per frame
	void Update () {
        Patrol();
        if (health.GetHealth() <= 0)
        {
            Destroy(this.gameObject);
        }
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

        if (rb.velocity.x < 0)
        {
            transform.localScale = new Vector2(-Mathf.Abs(transform.localScale.x), Mathf.Abs(transform.localScale.y));
        }
        else
        {
            transform.localScale = new Vector2(Mathf.Abs(transform.localScale.x), Mathf.Abs(transform.localScale.y));
        }

    }
}
