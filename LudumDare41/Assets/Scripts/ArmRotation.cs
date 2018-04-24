using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmRotation : MonoBehaviour {
    private Vector3 difference;
    private float rotZ;
    public int rotationOffset = 0;
    public Transform target;
    private Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponentInParent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.CompareTag("Player"))
        {
            // subtracting the position of the player from the mouse position
            difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            Rotation();
            
        }

        if(target != null)
        {
            // subtracting the position of the player from the target position
            difference = target.position - transform.position;
            Rotation();
        }
    }

    void Rotation()
    {
        // normalizing the vector. Meaning that the sum of the vector (x + y + z) will equal to 1.
        difference.Normalize();
        rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;   // find the angle in degrees
        if (rb.velocity.x < 0)
        {
            transform.localScale = new Vector2(-Mathf.Abs(transform.localScale.x), -Mathf.Abs(transform.localScale.y));

        }else if(rb.velocity.x > 0)
        {
            transform.localScale = new Vector2(Mathf.Abs(transform.localScale.x), Mathf.Abs(transform.localScale.y));
        }
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + rotationOffset);
    }
}
