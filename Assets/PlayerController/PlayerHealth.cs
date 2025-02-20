using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 1;
    public bool isDead;
    public bool isPlayer;
    public bool isEnemy;
    // Start is called before the first frame update
    void Start()
    {
        health = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            isDead = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && isPlayer)
        {
            health--;
        }

        if (collision.gameObject.CompareTag("Projectile") && isEnemy)
        {
            health--;
        }
    }
}
