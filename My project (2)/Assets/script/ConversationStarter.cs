using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;


public class ConversationStarter : MonoBehaviour
{
     [SerializeField] private NPCConversation myCanversation;
     public GameObject pleer;
     public GameObject camer;
     public Animator anim;
    public GameObject cub;
    void Start()
    {

        anim = cub.GetComponent<Animator>();

    }

    //void OnTriggerStay(Collider other)
    void OnMouseOver()
    {         

        if (Input.GetKeyDown(KeyCode.E))
        {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                ConversationManager.Instance.StartConversation(myCanversation);
                camer.SetActive(true);
                pleer.SetActive(false);
                anim.SetBool("anim", true);
        }
        
    }
     
}
