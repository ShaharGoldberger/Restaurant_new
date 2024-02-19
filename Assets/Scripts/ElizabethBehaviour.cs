using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElizabethBehaviour : MonoBehaviour
{
    Animator animator;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance;
        distance = Vector3.Distance(transform.position, player.transform.position);    
        if(distance < 7)
        {
            animator.SetInteger("State", 1); // new animation
        }
        else
        {
            animator.SetInteger("State", 0); // idle
        }
        
    }

}
