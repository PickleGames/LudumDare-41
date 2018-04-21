using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour {
    public GameObject leftWall;
    public GameObject rightWall;
    public float moveSpeed;
    private Transform target;



    void Start()
    {
        target = GameObject.Find("MainCharacter").transform;
    }

    void Update () {
        leftWall.transform.Translate(moveSpeed, 0 , 0);
        rightWall.transform.Translate(-moveSpeed, 0, 0);
    }

    void LateUpdate()
    {
        leftWall.transform.position = new Vector2(leftWall.transform.position.x, target.transform.position.y);
        rightWall.transform.position = new Vector2(rightWall.transform.position.x, target.transform.position.y);

 //       if (leftWall.transform.position.x == rightWall.transform.position.x)
 //       {
 //         leftWall.transform.position.x = rightWall.transform.position.x;
 //       }
    }

}
