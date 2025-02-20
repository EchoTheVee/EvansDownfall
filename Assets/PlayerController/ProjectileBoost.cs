using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBoost : MonoBehaviour
{
    public float boostForce;
    public GameObject player;
    private Rigidbody2D projectileRB;
    public Vector2 mousePlace;
    //private Cursor cursor;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        Vector3 currentMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePlace = ((Vector2)currentMousePos - (Vector2)player.transform.position).normalized;

        Debug.Log(mousePlace.magnitude);
        projectileRB = GetComponent<Rigidbody2D>();
        projectileRB.AddForce(mousePlace * boostForce, ForceMode2D.Impulse);
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
