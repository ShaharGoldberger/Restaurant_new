using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class JoeBehaviour : MonoBehaviour
{
    public GameObject target;
    NavMeshAgent agent;
    Animator animator;
    public GameObject point1;
    public GameObject point2;
    bool goingUp = true;
    
    // Start is called before the first frame update

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, target.transform.position);
        if(Input.GetKey(KeyCode.Q))
        {
            //automatically computes the path and moves NPC to the target
            agent.SetDestination(target.transform.position);
            animator.SetInteger("State", 1);
        }
        if(distance < 2)
        {
            //agent.isStopped = true;
            //animator.SetInteger("State", 0); //Idle animation

            if(goingUp)
            {
                target.transform.position = point1.transform.position;
                agent.SetDestination(target.transform.position);
                goingUp = false;
            }
            else
            {
                target.transform.position = point2.transform.position;
                agent.SetDestination(target.transform.position);
                goingUp=true;   
            }
        }
    }


}
