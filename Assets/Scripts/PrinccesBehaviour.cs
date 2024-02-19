using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PrinccesBehaviour : MonoBehaviour
{
    public GameObject target;
    NavMeshAgent agent;
    Animator animator;
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
        if(Input.GetKeyDown(KeyCode.Q))
        {
            agent.SetDestination(target.transform.position);
            animator.SetInteger("State",1);

        }
        //if(distance < 4)
        //{
          //  agent.isStopped = true;
          //  animator.SetInteger("State", 0); // idle
        //}
    }
}
