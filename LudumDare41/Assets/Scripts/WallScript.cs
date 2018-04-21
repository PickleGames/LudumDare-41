using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour {
    public GameObject leftWall;
    public GameObject rightWall;
    public float moveSpeed;
	

	void Update () {
        leftWall.transform.Translate(moveSpeed, 0 , 0);
        rightWall.transform.Translate(-moveSpeed, 0, 0);
    }


}
