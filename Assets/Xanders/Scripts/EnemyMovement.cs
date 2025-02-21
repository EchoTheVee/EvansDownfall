using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float EnemyMoveSpeed;
    private Rigidbody2D enemyRb;
    private GameObject player;
    private GameObject Projectile;
    public PlayerHealth ph;
    public Animator anim;

    [SerializeField] SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
        ph = GetComponent<PlayerHealth>();

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 lookDirection = (player.transform.position - transform.position).normalized;

        //enemy track
        if (ph.isDead == false)
        {
            enemyRb.AddForce(lookDirection * EnemyMoveSpeed);
        }
        else
        {
            EnemyMoveSpeed = 0;
            anim.SetBool("isDeadP", ph.isDead);
        }
       

        //sprite flip
        if (lookDirection.x > 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (lookDirection.x < 0)
        {
            spriteRenderer.flipX = false;
        }
    }

}

