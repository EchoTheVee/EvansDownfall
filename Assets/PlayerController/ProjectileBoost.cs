using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBoost : MonoBehaviour
{
    public float boostForce;
    private Rigidbody2D projectileRB;
    // Start is called before the first frame update
    void Start()
    {
        projectileRB = GetComponent<Rigidbody2D>();
        projectileRB.AddRelativeForce(Vector2.up * boostForce, ForceMode2D.Impulse);
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
