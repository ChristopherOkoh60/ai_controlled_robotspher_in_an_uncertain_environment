using UnityEngine;
using UnityEngine.AI;


public class AIController : MonoBehaviour
{
    public Transform destination;
    private NavMeshAgent agent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = destination.position;
    }
}