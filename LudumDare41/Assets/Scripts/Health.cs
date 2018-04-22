using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public float MAX_HEALTH;
    private float currentHealth;
    private float healthPercent;
    private SpriteRenderer spriteR;
    private Color defaultColor, damageColor;
	// Use this for initialization
	void Start () {
        currentHealth = MAX_HEALTH;
        spriteR = GetComponentInChildren<SpriteRenderer>();
        defaultColor = spriteR.color;
        damageColor = Color.red;
	}

    float timer;
	// Update is called once per frame
	void Update () {
        healthPercent = currentHealth / MAX_HEALTH;

        if (spriteR.color != defaultColor)
        {
            timer += Time.deltaTime;
            if (timer > 0.15)
            {
                spriteR.color = defaultColor;
                timer = 0;
            }
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        spriteR.color = damageColor;

    }

    public float GetHealth()
    {
        return currentHealth;
    }

    public float GetHealthPercentage()
    {
        return healthPercent;
    }
}
