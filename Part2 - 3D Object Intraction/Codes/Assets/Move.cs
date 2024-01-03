using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Animator animator;
    float speedFactor =  1f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetFloat("valY", 1f);
            animator.SetFloat("valX", 0f);
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetFloat("valX", 0f);
            animator.SetFloat("valY", -1f);
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetFloat("valY", 0f);
            animator.SetFloat("valX", -1f);
        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animator.SetFloat("valY", 0f);
            animator.SetFloat("valX", 1f);
        }

        else if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetFloat("valY", 2f);
            animator.SetFloat("valX", 0f);
        }
        else if(Input.GetKeyUp(KeyCode.RightArrow) ||
            Input.GetKeyUp(KeyCode.DownArrow) ||
            Input.GetKeyUp(KeyCode.LeftArrow) ||
                Input.GetKeyUp(KeyCode.UpArrow) ||
                 Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetFloat("valY", 0f);
            animator.SetFloat("valX", 0f);
        }
    }
}
