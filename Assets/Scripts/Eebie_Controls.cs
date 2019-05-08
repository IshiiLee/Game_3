using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eebie_Controls : MonoBehaviour
{
    public float maxSpeed = 10f;
    bool facingRight = true;

    Animator anim;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        float move = Input.GetAxis("Horizontal");

        anim.SetFloat("Speed", Mathf.Abs(move));

        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }


}
