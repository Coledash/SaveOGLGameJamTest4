using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMain : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform destination;
    public GameObject myFace;
    public int destinationNumber;
    

    void Start()
    {
        destinationNumber = Random.Range(0, GameManager.instance.agentDestinations.Length);
        agent = GetComponent<NavMeshAgent>();
        destination = GameManager.instance.agentDestinations[destinationNumber];
        agent.destination = destination.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {

        if(Vector3.Distance(agent.destination, transform.position) < 2)
        {
            destinationNumber++;
            if(destinationNumber >= GameManager.instance.agentDestinations.Length)
                destinationNumber = 0;
            agent.destination = GameManager.instance.agentDestinations[destinationNumber].position;
        }

        
    }

}
