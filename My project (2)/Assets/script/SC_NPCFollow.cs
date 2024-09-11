using UnityEngine;
using UnityEngine.AI;

public class SC_NPCFollow : MonoBehaviour
{
    //Transform that NPC has to follow
    public Transform transformToFollow;
    //NavMesh Agent variable
    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    //void Update()
    //{
    //    //Follow the player
    //    agent.SetDestination(transformToFollow.position);
    //}
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           agent.SetDestination(transformToFollow.position); // Код, который будет выполняться, когда триггер срабатывает на объект с тегом "Enemy" 
        }
        

    }

}
