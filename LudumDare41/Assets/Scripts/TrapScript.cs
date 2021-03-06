﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour {
    public float spinSpeed;
    public GameObject loseScreen;
    public WallMechanic wall;
    public GameObject blood;
    // Update is called once per frame
    void Update () {
        this.transform.Rotate(0,0,spinSpeed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Instantiate(blood, this.transform.position, Quaternion.identity);
            Instantiate(blood, this.transform.position, Quaternion.identity);
            Instantiate(blood, this.transform.position, Quaternion.identity);
        }

        if (other.gameObject.tag == "Player")
        {
            wall.moveSpeed = 0;
            Debug.Log("Wall Stop Moving...");
            other.gameObject.GetComponent<Transform>().Rotate(0,0, 90);
            other.gameObject.GetComponent<PlayerMovement>().enabled = false;
            other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            other.gameObject.GetComponentInChildren<Weapon>().enabled = false;
            other.gameObject.GetComponentInChildren<ArmRotation>().enabled = false;
            loseScreen.SetActive(true);
            Debug.Log("Player Dieeedddd");
            Instantiate(blood, this.transform.position, Quaternion.identity);


        }
    }
}
