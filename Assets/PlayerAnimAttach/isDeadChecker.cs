using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isDeadChecker : MonoBehaviour
{
    public PlayerHealth ph;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("isDeadP", ph.isDead);
    }
}
