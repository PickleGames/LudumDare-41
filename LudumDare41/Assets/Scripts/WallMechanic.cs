using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMechanic : MonoBehaviour {
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
            Debug.Log("Player Dieeedddd");
            moveSpeed = 0;
        }
    }


}
