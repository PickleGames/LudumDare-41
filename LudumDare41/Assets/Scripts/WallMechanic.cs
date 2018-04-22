using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallMechanic : MonoBehaviour {
    public GameObject loseScreen;
    public float moveSpeed;
    private Transform target;



    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    void Update()
    {
        this.transform.Translate(moveSpeed, 0, 0);
    }

    void LateUpdate()
    {
        this.transform.position = new Vector2(this.transform.position.x, target.transform.position.y);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            moveSpeed = 0;
            Debug.Log("Wall Stop Moving...");
            other.gameObject.GetComponent<PlayerMovement>().enabled = false;
            other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            loseScreen.SetActive(true);
            Debug.Log("Player Dieeedddd");
            
            

        }
    }

}
