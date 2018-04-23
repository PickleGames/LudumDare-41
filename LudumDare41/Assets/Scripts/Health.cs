using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public GameObject blood;
    public float MAX_HEALTH;
    private float currentHealth;
    private float healthPercent;
    private SpriteRenderer spriteR;
    public Color defaultColor, damageColor;
    private bool isDead = false;
	// Use this for initialization
	void Start () {
        currentHealth = MAX_HEALTH;
        spriteR = GetComponentInChildren<SpriteRenderer>();
        defaultColor = spriteR.color;
	}

    float timer;
	// Update is called once per frame
	void Update () {
        healthPercent = currentHealth / MAX_HEALTH;

        if (healthPercent <= 0 && !isDead)
        {
            isDead = true;
            Blood();
        }
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

    public void Blood()
    {
        Instantiate(blood, this.transform.position, Quaternion.identity);
    }

    public void TakeDamage(float damage)
    {
        Blood();
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
