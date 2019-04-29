using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTracks : MonoBehaviour
{
    public float maxSpeed = 10f;
    public Animator animator;
    public ParticleSystem particleTracks;
    bool facingRight = true;
    float Speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EmitParticle()
    {
        if (Speed > 0 && !facingRight)
        {

            particleTracks.Play();
            Debug.Log("particleTracks");
            Flip();
        }

        else if (Speed < 0 && facingRight)
        {
            particleTracks.Play();
            Debug.Log("particleTracks");
            Flip();
        }

    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}