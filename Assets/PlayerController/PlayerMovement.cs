using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    private Rigidbody2D playerRB;
    public float moveForce;
    public float turnForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerRB = GetComponent<Rigidbody2D>();
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        playerRB.AddRelativeForce(Vector2.up * moveForce * verticalInput);
        transform.Rotate(Vector3.back * turnForce * horizontalInput * Time.deltaTime);
    }
}
