using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    Animator animator;
    float speedFactor = 1f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            animator.SetFloat("speed", Input.GetAxis("Vertical") * speedFactor);
        }
        /*else if (Input.GetKeyDown(KeyCode.C))
        {

        }*/
    }
}
