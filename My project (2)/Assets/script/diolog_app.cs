using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class diolog_app : MonoBehaviour
{

    public GameObject pleer;
    public GameObject camer;
    public Animator anim;
    public GameObject cub;

    void Start()
    {

        anim = cub.GetComponent<Animator>();

    }
    public void clous()
    {
        anim.SetBool("anim", false);
        Cursor.lockState = CursorLockMode.Locked;
       
        pleer.SetActive(true);
        camer.SetActive(false);
       

    }


 
}
