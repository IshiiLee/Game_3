using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANIMATION_COLLISSION : MonoBehaviour
{
    public GameObject Player;
    public AnimationClip attack;

    private Animation myAnimation;

    /*  IEnumerator Wait()
      {

          myAnimation = GetComponent<Animation>();
          myAnimation.Play(attack.name);
          yield return new WaitForSeconds(3);

      }
  */
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered Trigger");
        myAnimation = GetComponent<Animation>();
        myAnimation.Play(attack.name);
        // StartCoroutine(Wait());
    }
    // Use this for initialization

    // Update is called once per frame
    void Update()
    {

    }
}
