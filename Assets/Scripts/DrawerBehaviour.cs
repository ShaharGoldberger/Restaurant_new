using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DrawerBehaviour : MonoBehaviour
{
    public GameObject Eye;
    public GameObject CrossHairRegular;
    public GameObject CrossHairTouch;
    public GameObject OpenText;
    public GameObject CloseText;
    public GameObject Chest;
    private Animator animator;
    AudioSource sound;
    bool isDrawerOpened = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = Chest.GetComponent<Animator>();
        sound = Chest.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // check it the sight is on this (drawer)
        RaycastHit hit;
        if(Physics.Raycast(Eye.transform.position, Eye.transform.forward, out hit))
        {
            // some collider has been hit
            // check if it is a Drawer collider
            if(hit.collider == GetComponent<Collider>())
            {
                CrossHairRegular.SetActive(false);
                CrossHairTouch.SetActive(true);
                if(!isDrawerOpened)
                {
                    OpenText.SetActive(true);
                    CloseText.SetActive(false);
                }
                else
                {
                    CloseText.SetActive(true);
                    OpenText.SetActive(false);
                }

                if(Input.GetKeyDown(KeyCode.O))
                {
                    animator.SetBool("OpenState", true);
                    sound.PlayDelayed(1);
                    isDrawerOpened = true;

                }
                if(Input.GetKeyDown(KeyCode.C))
                {
                    animator.SetBool("OpenState", false);
                    sound.PlayDelayed(1);
                    isDrawerOpened = false;

                }

            }
            else // the sight is not on drawer
            {
                CrossHairRegular.SetActive(true);
                CrossHairTouch.SetActive(false);
                OpenText.SetActive(false);
                CloseText.SetActive(false);

            }

        }

    }
}