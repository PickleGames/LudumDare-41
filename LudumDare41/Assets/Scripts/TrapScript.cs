using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour {
    public float spinSpeed;
    // Update is called once per frame
    void Update () {
        this.transform.Rotate(0,0,spinSpeed);
    }
}
